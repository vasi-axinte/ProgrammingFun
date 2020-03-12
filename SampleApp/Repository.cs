using System.IO;
using System.Collections.Generic;
namespace SampleApp
{
    public class Repository
    {
        public void AddStudent(Student s)
        {
            StreamWriter writeInFile = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            s.id++;
            writeInFile.WriteLine("{0}  {1}  {2}  {3}  {4}", s.id, s.FirstName, s.LastName, s.UserName, s.age);
            writeInFile.Close();
        }

        public List<Student> GetAllStudents()
        {
            int age;
            List<Student> Students = new List<Student>();
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {
                string[] sutdentDetails = line.Split(' ');
                var id = int.Parse(sutdentDetails[0]);
                var firstName = sutdentDetails[2];
                var lastName = sutdentDetails[4];
                var userName = sutdentDetails[6];
                age = int.Parse(sutdentDetails[8]);

                var student = new Student(id, firstName, lastName, userName, age);
                Students.Add(student);
            }
            return Students;
        }

        public void StudentsToBeDeleted(int idToBeDeleted)
        {
            StreamWriter writeInFile = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users2.Text", true);
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {
                int age;
                string[] sutdentDetails = line.Split(' ');
                var id = int.Parse(sutdentDetails[0]);
                var firstName = sutdentDetails[2];
                var lastName = sutdentDetails[4];
                var userName = sutdentDetails[6];
                age = int.Parse(sutdentDetails[8]);
                if (idToBeDeleted != id)
                {
                    writeInFile.WriteLine("{0}  {1}  {2}  {3}  {4}", id, firstName, lastName, userName, age);
                }
            }
            File.Delete("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text");
            writeInFile.Close();
            File.Move("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users2.Text", "C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text");
        }
    }
}

