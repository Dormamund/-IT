using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IEmployeeDbContext
    {
        DbSet<Employee> Employees { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
