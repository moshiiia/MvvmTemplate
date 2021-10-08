using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Entities;


namespace Models.DataProviders.SqlServer
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) 
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DBSRV\MSSQL2021;Initial Catalog=MI;Integrated Security=True");

        }
    }
}
