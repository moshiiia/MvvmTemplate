using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;


namespace Models.Repositories
{
    public interface IStudentsRepos
    {
        IQueryable<Student> Items();
        Student GetItemById(Guid id);
        void Delete(Guid id);
        void Update(Student student);
    }
}
