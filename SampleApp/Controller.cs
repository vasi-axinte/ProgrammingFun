using System.Collections.Generic;
namespace SampleApp
{
    public class Controller
    {
        private Repository _repository;

        public Controller()
        {
            _repository = new Repository();
        }

        public void AddStudent(Student s)
        {
            _repository.AddStudent(s);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = _repository.GetAllStudents();
            return students;
        }

        public void DeleteStudents(int idToBeDeleted)
        {
            _repository.DeleteStudents(idToBeDeleted);
        }
    }
}