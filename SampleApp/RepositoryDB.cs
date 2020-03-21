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
            SqlCommand studentDetails = new SqlCommand("SELECT * FROM Students", connection);
            SqlDataReader studentReader = studentDetails.ExecuteReader();
            while (studentReader.Read())
            {
                var idStudent = studentReader["IdStudent"];
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
            SqlCommand student = new SqlCommand("DELETE FROM Students WHERE IdStudent=@id", connection);
            student.Parameters.Add("@id", id);
            student.ExecuteNonQuery();
            connection.Close();
        }

        public void EditStudentDetails(Student s)
        {
            connection.Open();
            SqlCommand student = new SqlCommand("UPDATE Students SET Firstname=@Firstname, Lastname=@Lastname, Username=@Username, Age=@Age WHERE IdStudent=@IdStudent", connection);
            student.Parameters.Add("@Firstname", s.FirstName);
            student.Parameters.Add("@Lastname", s.LastName);
            student.Parameters.Add("@Username", s.Username);
            student.Parameters.Add("@Age", s.Age);
            student.Parameters.Add("@IdStudent", s.Id);
            student.ExecuteNonQuery();
            connection.Close();
        }
    }
}