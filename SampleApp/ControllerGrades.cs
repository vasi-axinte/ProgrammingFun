using System.Collections.Generic;

namespace SampleApp
{

    public class ControllerGrades
    {
        private RepositoryGrades _repository;

        public ControllerGrades()
        {
            _repository = new RepositoryGrades();
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