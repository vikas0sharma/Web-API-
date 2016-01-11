using MongoDB.Driver;
using Students.DataModel.Models;
using Students.DataModel.StudentRepository;
using System.Configuration;

namespace Students.DataModel.UnitOfWork
{
    public class StudentsUnitOfWork
    {
        private MongoDatabase _database;

        protected StudentRepository<Student> _students;

        public StudentsUnitOfWork()
        {
            var connectionString = ConfigurationManager.AppSettings["MongoDBConectionString"];
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var databaseName = ConfigurationManager.AppSettings["MongoDBDatabaseName"];
            _database = server.GetDatabase(databaseName);
        }
        public StudentRepository<Student> Students
        {
            get
            {
                if (_students == null)
                    _students = new StudentRepository<Student>(_database, "students");

                return _students;
            }
        }
    }
}
