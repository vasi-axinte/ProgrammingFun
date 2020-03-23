using System.Collections.Generic;

namespace SampleApp
{
    public class StudentsController
    {
        private StudentsRepository _repository;

        public StudentsController()
        {
            _repository = new StudentsRepository();
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

        public void DeleteStudent(int id)
        {
            _repository.DeleteStudent(id);
        }

        public void UpdateStudentDetails(Student s)
        {
            _repository.UpdateStudentDetails(s);
        }
    }
}