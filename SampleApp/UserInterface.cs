using System;

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
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public void AddStudent()
        {
            Console.Write("First Name: ");
            var firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastName = Console.ReadLine();

            var studentToBeAdded = new Student(firstName, lastName);
            _controller.AddStudent(studentToBeAdded);
        }
    }
}