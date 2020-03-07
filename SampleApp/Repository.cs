using System.IO;
using System;
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
        public void ShowAllStudents()
        {
            string line;
            StreamReader readFromFile = new StreamReader("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            line = readFromFile.ReadLine();
            while (line != null)
            {
                //Console.WriteLine(line);
                line = readFromFile.ReadLine();
            }
            readFromFile.Close();
            Console.ReadLine();
        }
     }
}