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
            List<Student> student = _repository.GetAllStudents();
            return student;
        }
    }
}