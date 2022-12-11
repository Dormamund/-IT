using Persistence.EntityTypeConfigurations;
using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class EmployeeDbContext : DbContext, IEmployeeDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
