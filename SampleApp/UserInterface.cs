using System;
using System.IO;

namespace SampleApp
{
    public class UserInterface
    {
        private Controller _controller;

        public UserInterface()
        {
            _controller = new Controller();
        }

        public void Run()
        {
            AddStudent();
            Console.ReadLine();
            string line;
            StreamReader tsr = new StreamReader("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            line = tsr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = tsr.ReadLine();
            }
            tsr.Close();
            Console.ReadLine();
        }

        public void AddStudent()
        {
            Console.Write("First Name: ");
            var firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastName = Console.ReadLine();
            Console.Write("Username: ");
            var userName = Console.ReadLine();
            Console.Write("Age: ");
            var Age = Convert.ToInt32(Console.ReadLine());

            var studentToBeAdded = new Student(firstName, lastName, userName, Age);
            _controller.AddStudent(studentToBeAdded);
        }
    }
}