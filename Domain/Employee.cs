using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
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
