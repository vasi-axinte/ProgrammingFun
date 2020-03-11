using System.IO;
using System.Collections.Generic;
namespace SampleApp
{
    public class Repository
    {
        public void AddStudent(Student s)
        {
            StreamWriter writeInFile = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            s.Id++;
            writeInFile.WriteLine("{0}  {1}  {2}  {3} {4}", s.Id, s.FirstName, s.LastName, s.UserName, s.Age);
            writeInFile.Close();
        }

        public List<Student> GetAllStudents()
        {
            int Age;
            List<Student> Students = new List<Student>();
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {
                string[] sutdentCredentials = line.Split(' ');
                var Id = int.Parse(sutdentCredentials[0]);
                var firstName = sutdentCredentials[2];
                var lastName = sutdentCredentials[4];
                var userName = sutdentCredentials[6];
                Age = int.Parse(sutdentCredentials[7]);
                var Student = new Student(firstName, lastName, userName, Age, Id);
                Students.Add(Student);
            }
            return Students;
        }
    }
}

