using System.Collections.Generic;

namespace SampleApp
{
    public class Controller
    {
        private RepositoryDB _repositoryDB;

        public Controller()
        {
            _repositoryDB = new RepositoryDB();
        }

        public void AddStudent(Student s)
        {
            _repositoryDB.AddStudent(s);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = _repositoryDB.GetAllStudents();
            return students;
        }

        public void DeleteStudent(int idToBeDeleted)
        {
            _repositoryDB.DeleteStudent(idToBeDeleted);
        }
    }
}