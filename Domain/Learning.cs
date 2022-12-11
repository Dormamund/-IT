using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Learning
    {
        public Guid Id { get; set; }
        public Employee Person { get; set; }
        public Course Education { get; set; }
        public string Status { get; set; }
    }
}
