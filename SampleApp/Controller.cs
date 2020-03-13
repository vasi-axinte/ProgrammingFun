using System.Collections.Generic;
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
            _repository.AddStudent(s);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = _repository.GetAllStudents();
            return students;
        }

        public List<Student> StudentsToBeDeleted(int idToBeDeleted)
        {
            List<Student> students = _repository.StudentsToBeDeleted(idToBeDeleted);
            return students;
        }
    }
}