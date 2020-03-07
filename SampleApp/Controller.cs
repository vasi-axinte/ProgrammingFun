using System;

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
            var StudentToBeAdded = new Student(s.FirstName, s.LastName, s.UserName, s.Age);
            _repository.AddStudent(StudentToBeAdded);
        }

        public void ShowAllStudents()
        {
            _repository.ShowAllStudents();
        }
    }
}