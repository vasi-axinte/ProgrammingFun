using System.IO;
using System.Collections.Generic;
namespace SampleApp
{
    public class Repository
    {
        public void AddStudent(Student s)
        {
            StreamWriter inFile = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            s.Id++;
            inFile.WriteLine("{0}  {1}  {2}  {3}  {4}", s.Id, s.FirstName, s.LastName, s.UserName, s.Age);
            inFile.Close();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {

                string[] sutdentDetails = line.Split(' ');
                var id = int.Parse(sutdentDetails[0]);
                var firstName = sutdentDetails[2];
                var lastName = sutdentDetails[4];
                var userName = sutdentDetails[6];
                int age = int.Parse(sutdentDetails[8]);
                var student = new Student(id, firstName, lastName, userName, age);
                students.Add(student);
            }
            return students;
        }

        public void DeleteStudents(int idToBeDeleted)
        {
            List<Student> students = new List<Student>();
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {
                string[] sutdentDetails = line.Split(' ');
                int id = int.Parse(sutdentDetails[0]);
                var firstName = sutdentDetails[2];
                var lastName = sutdentDetails[4];
                var userName = sutdentDetails[6];
                int age = int.Parse(sutdentDetails[8]);
                var student = new Student(id, firstName, lastName, userName, age);
                if (id != idToBeDeleted)
                {
                    students.Add(student);
                }
            }
            File.Delete("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text");
            foreach (var student in students)
            {
                StreamWriter inFile = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
                inFile.WriteLine("{0}  {1}  {2}  {3}  {4}", student.Id.ToString(), student.LastName, student.FirstName, student.UserName, student.Age);
                inFile.Close();
            }
        }
    }
}