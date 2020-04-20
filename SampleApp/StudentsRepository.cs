using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace SampleApp
{
    public class StudentsRepository
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristi\source\repos\ThisIs\ThisIs\Students.mdf;Integrated Security=False";
        SqlConnection connection = new SqlConnection(connectionString);


        public void AddStudent(Student s)
        {
            connection.Open();

            SqlCommand insertStudent = new SqlCommand("INSERT INTO Students (Firstname, Lastname, Username, Age) VALUES (@Firstname, @Lastname, @Username, @Age)", connection);
            insertStudent.Parameters.Add("@Firstname", s.FirstName);
            insertStudent.Parameters.Add("@Lastname", s.LastName);
            insertStudent.Parameters.Add("@Username", s.Username);
            insertStudent.Parameters.Add("@Age", s.Age);
            insertStudent.ExecuteNonQuery();

            connection.Close();
        }

        public List<Student> GetAllStudents()
        {
            connection.Open();
            List<Student> students = new List<Student>();
            SqlCommand studentDetails = new SqlCommand("SELECT * FROM Students", connection);
            SqlDataReader studentReader = studentDetails.ExecuteReader();
            while (studentReader.Read())
            {
                var idStudent = studentReader["Id"];
                var firstName = studentReader["Firstname"];
                var lastName = studentReader["Lastname"];
                var userName = studentReader["Username"];
                var age = studentReader["Age"];
                Student student = new Student(int.Parse(idStudent.ToString().Trim()), firstName.ToString().Trim(), lastName.ToString().Trim(), userName.ToString().Trim(), int.Parse(age.ToString()));

                students.Add(student);
            }
            connection.Close();
            return students;
        }

        public void DeleteStudent(int id)
        {
            connection.Open();
            SqlCommand student = new SqlCommand("DELETE FROM Students WHERE Id=@id", connection);
            student.Parameters.Add("@id", id);
            student.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateStudentDetails(Student s)
        {
            connection.Open();
            SqlCommand student = new SqlCommand("UPDATE Students SET Firstname=@Firstname, Lastname=@Lastname, Username=@Username, Age=@Age WHERE IdStudent=@IdStudent", connection);
            student.Parameters.Add("@Firstname", s.FirstName);
            student.Parameters.Add("@Lastname", s.LastName);
            student.Parameters.Add("@Username", s.Username);
            student.Parameters.Add("@Age", s.Age);
            student.Parameters.Add("@Id", s.Id);
            student.ExecuteNonQuery();
            connection.Close();
        }

        public List<StudentWithGrade> GetStudentsWithGradesBiggerThan(int limitGrade)
        {
            List<StudentWithGrade> students = new List<StudentWithGrade>();
            connection.Open();
            SqlCommand studentAndGradeSelector = new SqlCommand("SELECT Grades.Id, Grades.Value, Grades.IdStudent, Students.Firstname, Students.Lastname FROM Grades,Students WHERE (Grades.Value >= @limitGrade) AND (Grades.IdStudent = Students.Id)", connection);
            studentAndGradeSelector.Parameters.Add("@limitGrade", limitGrade);
            SqlDataReader studentAndGradeReader = studentAndGradeSelector.ExecuteReader();
            while (studentAndGradeReader.Read())
            {

                var firstName = studentAndGradeReader["Firstname"];
                var lastName = studentAndGradeReader["Lastname"];
                var id = studentAndGradeReader["Id"];
                var value = studentAndGradeReader["Value"];
                var idStudent = studentAndGradeReader["IdStudent"];

                var student = new StudentWithGrade(int.Parse(id.ToString().Trim()), int.Parse(value.ToString().Trim()), firstName.ToString().Trim(), lastName.ToString().Trim(), int.Parse(idStudent.ToString().Trim()));
                students.Add(student);
            }
            connection.Close();
            return students;
        }
    }
}