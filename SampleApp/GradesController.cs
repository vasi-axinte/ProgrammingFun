using System.Collections.Generic;

namespace SampleApp
{
    public class GradesController
    {
        private GradesRepository _gradesRepository;

        public GradesController()
        {
            _gradesRepository = new GradesRepository();
        }

        public void AddGrade(Grade g)
        {
            _gradesRepository.AddGrade(g);
        }

        public void DeleteGrade(int gradeId)
        {
            _gradesRepository.DeleteGrade(gradeId);
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = _gradesRepository.GetAllGrades();
            return grades;
        }

        public List<Grade> GetAllGradesForStudent(int studentId)
        {
            List<Grade> grades = _gradesRepository.GetAllGradesForStudent(studentId);
            return grades;
        }
    }
}