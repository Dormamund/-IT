using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Application.Interfaces;

using System.Threading;
using System.Threading.Tasks;

namespace Application.Employees.Commands.DeleteEmployee
{
    //public class DeleteEmployeeCommandHandler
    //    : IRequestHandler<DeleteEmployeeCommand>
    //{
    //    private readonly IEmployeeDbContext _dbContext;
    //    public DeleteEmployeeCommandHandler(IEmployeeDbContext dbContext) =>
    //        _dbContext = dbContext;
    //    public async Task<Unit> Handle (DeleteEmployeeCommand request,
    //        CancellationToken cancellationToken)
    //    {
    //        var entity = await _dbContext.Employees
    //            .FindAsync(new object[] {request.Id}, cancellationToken);
    //        if (entity == null)
    //        {

    //        }
    //        _dbContext.Employees.Remove(entity);
    //        await _dbContext.SaveChangesAsync(cancellationToken);
    //    }
    //}
}
