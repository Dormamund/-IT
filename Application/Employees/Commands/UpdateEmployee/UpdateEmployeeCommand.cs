using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Domain;

namespace Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Guid>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }
        public Employee Chief { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
