using System;
using Microsoft.EntityFrameworkCore;

namespace sampleCRUD
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) :base(options)
        {

        }
        public DbSet<Model.Employee> Employees { get; set; }
    }
}
