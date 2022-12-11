using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain;

namespace Application.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<Guid>
    {
           
    }
}
