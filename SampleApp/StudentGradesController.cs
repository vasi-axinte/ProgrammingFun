using System;
using System.Collections.Generic;

namespace SampleApp
{
    public class StudentGradesController
    {
        private StudentsRepository _studentsRepository;
        private GradesRepository _gradesRepository;

        public StudentGradesController()
        {
            _studentsRepository = new StudentsRepository();
            _gradesRepository = new GradesRepository();
        }

        public List<StudentWithGrade> GetStudentsWithGradeBiggerThan(int limitGrade)
        {
            List<StudentWithGrade> students = _studentsRepository.GetStudentsWithGradesBiggerThan(limitGrade);
            return students;
        }

        public List<StudentAverage> GetAllStudents()
        {
            List<Student> students = _studentsRepository.GetAllStudents();
            List<StudentAverage> studentsWithAverage = new List<StudentAverage>();
            foreach (var student in students)
            {
                var average = GetAverageForStudent(student.Id);
                var studentWithAverage = new StudentAverage(student.LastName, student.FirstName, average);
                studentsWithAverage.Add(studentWithAverage);
            }
            studentsWithAverage.Sort((student1, student2) => student1.Average.CompareTo(student2.Average));
            return studentsWithAverage;
        }

        public int GetAverageForStudent(int studentId)
        {
            List<Grade> grades = _gradesRepository.GetAllGradesForStudent(studentId);
            var sum = 0;
            var gradesNumber = 0;
            int average;
            foreach (var grade in grades)
            {
                sum = sum + grade.Value;
                gradesNumber++;
            }
            if (gradesNumber > 1)
            {
                average = sum / gradesNumber;
            }
            else average = sum;
            return average;
        }
    }
}