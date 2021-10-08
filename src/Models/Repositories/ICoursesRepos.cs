using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    interface ICoursesRepos
    {
        IQueryable<Course> Items();
        Course GetItemById(Guid id);
        void Delete(Guid id);
        void Update(Course course);
    }
}
