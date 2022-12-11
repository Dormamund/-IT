using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Application.Employees.Commands.UpdateEmployee
{
    //public class UpdateEmployeeCommandHandler
    //    : IRequestHandler<UpdateEmployeeCommand>
    //{
    //    private readonly IEmployeeDbContext _dbContext;
    //    public UpdateEmployeeCommandHandler(IEmployeeDbContext dbContext) =>
    //        _dbContext = dbContext;
    //    public async Task<Unit> Handle(UpdateEmployeeCommand request,
    //        CancellationToken cancellationToken)
    //    {
    //        var entity =
    //            await _dbContext.Employees.FirstOrDefaultAsync(employee =>
    //            employee.Id == request.Id, cancellationToken);

    //        return Unit.Value;
    //    }
    //}
}
