using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string Description { get; set; }
    }
}
