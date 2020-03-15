using System.Data.SqlClient;
using System.Collections.Generic;

namespace SampleApp
{
    public class RepositoryDB
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
            SqlCommand getStudent = new SqlCommand("SELECT * FROM Students", connection);
            SqlDataReader readstudent = getStudent.ExecuteReader();
            while (readstudent.Read())
            {
                var idStudent = readstudent["IdStudent"];
                var firstName = readstudent["Firstname"];
                var lastName = readstudent["Lastname"];
                var userName = readstudent["Username"];
                var age = readstudent["Age"];
                Student student = new Student(int.Parse(idStudent.ToString().Trim()), firstName.ToString().Trim(), lastName.ToString().Trim(), userName.ToString().Trim(), int.Parse(age.ToString()));

                students.Add(student);

            }
            connection.Close();

            return students;
        }

        public void DeleteStudent(int id)
        {
            connection.Open();
            SqlCommand student = new SqlCommand("DELETE FROM Students WHERE IdStudent=@id", connection);
            student.Parameters.Add("@id", id);
            student.ExecuteNonQuery();
            connection.Close();
        }

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
    }
}