using System.Collections.Generic;

namespace SampleApp
{
    public class StudentsController
    {
        private StudentsRepository _studentsRepository;

        public StudentsController()
        {
            _studentsRepository = new StudentsRepository();
        }

        public void AddStudent(Student s)
        {
            _studentsRepository.AddStudent(s);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = _studentsRepository.GetAllStudents();
            SortAllStudents(students);
            return students;
        }

        public List<Student> SortAllStudents(List<Student> students)
        {
            List<Student> sortedStudents = new List<Student>();

            students.Sort((student1, student2) => student1.LastName.CompareTo(student2.LastName));
            sortedStudents = students;
            return sortedStudents;
        }

        public void DeleteStudent(int id)
        {
            _studentsRepository.DeleteStudent(id);
        }

        public void UpdateStudentDetails(Student s)
        {
            _studentsRepository.UpdateStudentDetails(s);
        }
    }
}