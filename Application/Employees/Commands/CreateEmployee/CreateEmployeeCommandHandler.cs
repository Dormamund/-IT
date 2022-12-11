using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Application.Interfaces;
using Domain;

namespace Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler
        :IRequestHandler<CreateEmployeeCommand, Guid>
    {
        private readonly IEmployeeDbContext _dbContext;
        public CreateEmployeeCommandHandler(IEmployeeDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateEmployeeCommand request,
            CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                LastName = request.LastName,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                DateOfBirth = request.DateOfBirth,
                JobTitle = request.JobTitle,
                Chief = request.Chief,
                Email = request.Email,
                Password = request.Password
            };
            await _dbContext.Employees.AddAsync(employee, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return employee.Id;
        }
    }
}
