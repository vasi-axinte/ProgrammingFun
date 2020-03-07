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
            // do stuff with student here;
            var StudentToBeInserted = new Student(s.FirstName, s.LastName, s.UserName, s.UserAge);
            _repository.InsertStudent(StudentToBeInserted);
        }
    }
}