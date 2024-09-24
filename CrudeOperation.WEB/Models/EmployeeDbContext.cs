using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CrudeOperation.WEB.Models
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }  
        public DbSet<Employee>Employees { get; set; }
    }
}
