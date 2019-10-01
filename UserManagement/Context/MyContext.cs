using UserManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Context
{
     class MyContext : DbContext
    {
        public MyContext() : base("DbConnectionString")
        {

        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeApplication> EmployeeApplications { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subdistrict> Subdistricts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Village> Villages { get; set; }



    }

}
