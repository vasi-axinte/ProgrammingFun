using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class StudentGradesController
    {
        private StudentsRepository _repositoryStudents;
        private GradesRepository _repositoryGrades;

        public StudentGradesController()
        {
            _repositoryStudents = new StudentsRepository();
            _repositoryGrades = new GradesRepository();
        }
        public List<StudentWithGrade> GetStudentsWithGradeBiggerThan(int check)
        {
            List<StudentWithGrade> students = _repositoryStudents.GetStudentsWithGradesBiggerThan(check);
            return students;
        }
    }
}