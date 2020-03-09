using System.IO;
using System;
using System.Collections.Generic;
namespace SampleApp
{
    public class Repository
    {
        public void AddStudent(Student s)
        {
            StreamWriter writeInFile = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            writeInFile.WriteLine("{0}  {1}  {2}  {3} ", s.FirstName, s.LastName, s.UserName, s.Age);
            writeInFile.Close();
        }

        public List<string> GetAllStudents()

        {
            string firstName;
            string lastName;
            string userName;
            int Age;
            List<string> Students = new List<string>();
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {
                string[] sutdentCredentials = line.Split(' ');
                firstName = sutdentCredentials[0];
                lastName = sutdentCredentials[2];
                userName = sutdentCredentials[4];
                Age = int.Parse(sutdentCredentials[6]);

                var Student = new Student(firstName, lastName, userName, Age);
                Students.Add(Student.FirstName + " " + Student.LastName + " " + Student.UserName + " " + Student.Age.ToString() + "\n");
            }
            return Students;
        }
    }
}

