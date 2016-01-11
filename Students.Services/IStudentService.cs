using Students.DataModel.Models;
using System.Linq;

namespace Students.Services
{
    public interface IStudentService
    {
        void Insert(Student student);
        Student Get(int i);
        IQueryable<Student> GetAll();
        void Delete(int id);
        void Update(Student student);
    }
}
