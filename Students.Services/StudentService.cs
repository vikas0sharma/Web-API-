using Students.DataModel.Models;
using Students.DataModel.UnitOfWork;
using System.Linq;

namespace Students.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentsUnitOfWork _sUnitOfwork;

        public StudentService()
        {
            _sUnitOfwork = new StudentsUnitOfWork();
        }

        public Student Get(int i)
        {
           return _sUnitOfwork.Students.Get(i);
        }

        public IQueryable<Student> GetAll()
        {
            return _sUnitOfwork.Students.GetAll();
        }

        public void Delete(int id)
        {
            _sUnitOfwork.Students.Delete(s => s.StudentID,id);
        }

        public void Insert(Student student)
        {
            _sUnitOfwork.Students.Add(student);
        }

        public void Update(Student student)
        {
            _sUnitOfwork.Students.Update(s => s.StudentID,student.StudentID, student);
        }

    }
}
