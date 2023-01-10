using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;
using WEBAPI.PERSISTANCE;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.SERVICES
{
    public class ProjectAllocationServices :IProjectAllocationServices
    {
        private readonly DataAccess dataAccess;

        public ProjectAllocationServices(DataAccess _dataAccess)
        {
            dataAccess = _dataAccess;
        }

        public DataTable GetAllocationData(DateTime FromDate, DateTime ToDate, string EmpData)
        {
            try
            {
                DataTable ds = new DataTable();

                var connection = (SqlConnection)dataAccess.Database.GetDbConnection();
                using (SqlCommand cmd = new SqlCommand("SPC_HRM_ProjectAllocationData", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    SqlParameter paramIns = new SqlParameter();
                    cmd.Parameters.AddWithValue("@FromDate", FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", ToDate);
                    cmd.Parameters.AddWithValue("@EmpDate", EmpData);
                    
                    connection.Open();

                    SqlDataAdapter da = new SqlDataAdapter();

                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    connection.Close();
                }

                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int PostAllocationData(int SegmentID, int LastModifyUser, List<PostProjectAllocationDTO> projectAllocationDTOs)
        {
            DataTable dataTable = ToDataTable(projectAllocationDTOs);

            var connection = (SqlConnection)dataAccess.Database.GetDbConnection();
            SqlCommand cmd = new SqlCommand("SP_TransactionEmployeeProjectAllocationActualDetails_InsertUpdate_Bulk", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RetText", "");
            cmd.Parameters["@RetText"].Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@RetID", -1);
            cmd.Parameters["@RetID"].Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@LastModifyUser", LastModifyUser);
            cmd.Parameters.AddWithValue("@SegmentID", SegmentID);
            cmd.Parameters.AddWithValue("@DataTableDetails", dataTable);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            if (i != 0)
            {
                return i;
            }

            return 0;
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }

}
