using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Course
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public virtual IList<Student> Students { get; set; } = new List<Student>();
    }
}
