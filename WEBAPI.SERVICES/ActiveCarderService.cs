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
    public class ActiveCarderService : IActiveCarderService
    {
        private readonly DataAccess dataAccess;

        public ActiveCarderService(DataAccess _dataAccess)
        {
            dataAccess = _dataAccess;
        }
        public int AddEmployeeCarder(List<ActiveCarderDTO> activecarder)
        {
            DataTable dataTable = ToDataTable(activecarder);

            var connection = (SqlConnection)dataAccess.Database.GetDbConnection();
            SqlCommand cmd = new SqlCommand("SPC_PostActiveCarder_InsertUpdate", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RetText", "");
            cmd.Parameters["@RetText"].Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@RetID", -1);
            cmd.Parameters["@RetID"].Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@DataTable", dataTable);
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
