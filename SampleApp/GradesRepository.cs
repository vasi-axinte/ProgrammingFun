using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace SampleApp
{
    public class GradesRepository
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristi\source\repos\ThisIs\ThisIs\Students.mdf;Integrated Security=False";
        SqlConnection connection = new SqlConnection(connectionString);

        public void AddGrade(Grade g)
        {
            connection.Open();
            SqlCommand studentGrade = new SqlCommand("INSERT INTO Grades (Value, Date, IdStudent) VALUES (@value, @date, @studentId)", connection);
            studentGrade.Parameters.Add("@value", g.Value);
            studentGrade.Parameters.Add("@date", g.Date); ;
            studentGrade.Parameters.Add("@studentId", g.IdStudent);
            studentGrade.ExecuteNonQuery();
            connection.Close();
        }

        public List<Grade> GetAllGrades()
        {
            connection.Open();
            List<Grade> grades = new List<Grade>();
            SqlCommand gradeDetails = new SqlCommand("SELECT * FROM Grades", connection);
            SqlDataReader gradeReader = gradeDetails.ExecuteReader();
            while (gradeReader.Read())
            {
                var gradeId = gradeReader["Id"];
                var studentId = gradeReader["IdStudent"];
                var value = gradeReader["Value"];
                var date = gradeReader["Date"];

                Grade grade = new Grade(int.Parse(gradeId.ToString().Trim()), int.Parse(value.ToString().Trim()), date.ToString().Trim(), int.Parse(studentId.ToString().Trim()));
                grades.Add(grade);
            }
            connection.Close();
            return grades;
        }

        public void DeleteGrade(int gradeId)
        {
            connection.Open();
            SqlCommand grade = new SqlCommand("DELETE FROM Grades where Id=@gradeId ", connection);
            grade.Parameters.Add("@gradeId", gradeId);
            grade.ExecuteNonQuery();
            connection.Close();
        }

        public List<Grade> GetAllGradesForStudent(int studentId)
        {
            List<Grade> grades = new List<Grade>();
            connection.Open();
            SqlCommand studentSelector = new SqlCommand("SELECT * FROM Grades WHERE(IdStudent = @studentId)", connection);
            studentSelector.Parameters.Add("@studentId", studentId);
            SqlDataReader gradeReader = studentSelector.ExecuteReader();
            while (gradeReader.Read())
            {
                var gradeId = gradeReader["Id"];
                var value = gradeReader["Value"];
                var date = gradeReader["Date"];
                var idStudent = gradeReader["IdStudent"];

                Grade grade = new Grade(int.Parse(gradeId.ToString().Trim()), int.Parse(value.ToString().Trim()), date.ToString().Trim(), int.Parse(idStudent.ToString().Trim()));
                grades.Add(grade);
            }
            connection.Close();
            return grades;
        }
    }
}