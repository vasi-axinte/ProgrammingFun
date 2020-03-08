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
            List<string> lines = new List<string>();
            foreach (string line in File.ReadLines("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text"))
            {
                lines.Add(line);
                lines.ToString();
            }
            return lines;

        }
    }
}

