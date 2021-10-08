using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    class Student
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public virtual IList<Course> Courses { get; set; } = new List<Course>();
    }
}
