using System.Collections.Generic;

namespace SampleApp
{

    public class GradesController
    {
        private GradesRepository _repository;

        public GradesController()
        {
            _repository = new GradesRepository();
        }

        public void AddGrade(Grade g)
        {
            _repository.AddGrade(g);
        }

        public void DeleteGrade(int gradeId)
        {
            _repository.DeleteGrade(gradeId);
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = _repository.GetAllGrades();
            return grades;
        }

        public List<Grade> GetAllGradesForStudent(int studentId)
        {
            List<Grade> grades = _repository.GetAllGradesForStudent(studentId);
            return grades;
        }
    }
}