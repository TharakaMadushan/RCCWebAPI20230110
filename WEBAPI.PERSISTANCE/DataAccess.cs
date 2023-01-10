using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.PERSISTANCE
{
    public class DataAccess : DbContext
    {
        public DataAccess(DbContextOptions<DataAccess> options) : base(options) { }

        public DbSet<SkillType> tblRefSkillType { get; set; }
        public DbSet <Designation> tblRefDesignation { get; set; }
        public DbSet<CustomerProject> tblRefProject { get; set; }
        public DbSet<Employee> tblRefEmployee { get; set; }
        public DbSet<DayType> tblRefDayType { get; set; }
        public DbSet<ActiveCarder> tblRefEmployeeCalender { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillType>().HasKey(o => o.Code);
            modelBuilder.Entity<Designation>().HasKey(o => o.DesigCode);
            modelBuilder.Entity<CustomerProject>().HasKey(o => o.ProjectCode);
            modelBuilder.Entity<Employee>().HasKey(o => o.EmployeeCode);
            modelBuilder.Entity<DayType>().HasKey(o => o.DayTypeCode);
        }

    }
}
