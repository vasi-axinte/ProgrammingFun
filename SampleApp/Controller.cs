using System.Collections.Generic;

namespace SampleApp
{
    public class Controller
    {
        private RepositoryDB _repository;

        public Controller()
        {
            _repository = new RepositoryDB();
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

        public void AddGrade(Grade g)
        {
            _repository.AddGrade(g);
        }

        public void DeleteGrade(int studentId, int value)
        {
            _repository.DeleteGrade(studentId, value);
        }

        public List<Grade> ShowStudentsAndGrades()
        {
            List<Grade> students = _repository.ShowStudentsAndGrades();
            return students;
        }
    }
}