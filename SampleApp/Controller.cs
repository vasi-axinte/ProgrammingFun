using System;
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
            var StudentToBeAdded = new Student(s.FirstName, s.LastName, s.UserName, s.Age);
            _repository.AddStudent(StudentToBeAdded);
        }

        public List<string> GetAllStudents()
        {
            List<string> Users = _repository.GetAllStudents();
            return Users;
        }
    }
}