using System;
using System.IO;
using System.Collections.Generic;

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
            MenuCommands();
            Console.ReadLine();
        }

        public void MenuCommands()
        {
            Console.WriteLine("Main menu:");
            Console.WriteLine("1.Add new student");
            Console.WriteLine("2.Show all students");
            int command = int.Parse(Console.ReadLine());
            if (command == 1)
            {
                AddStudent();
                Console.WriteLine();
                BactToMenu();
            }
            else if (command == 2)
            {
                _controller.GetAllStudents();
                ShowAllStudents();
                Console.WriteLine();
                BactToMenu();
            }
            else Console.WriteLine("Not a valid command");
        }

        public void BactToMenu()
        {
            Console.WriteLine("Would you like to return to main menu? ( Y or N )");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                Console.WriteLine();
                MenuCommands();
            }
            else if (answer == "N")
            {
                Console.WriteLine();
                Console.WriteLine("See you next time!");
                return;
            }
            else return;
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
            int age = Convert.ToInt32(Console.ReadLine());
            int id = 0;

            var studentToBeAdded = new Student(id, firstName, lastName, userName, age);
            _controller.AddStudent(studentToBeAdded);
        }

        public void ShowAllStudents()
        {
            foreach (var studentList in _controller.GetAllStudents())
            {

                Console.WriteLine(studentList.id + " " + studentList.FirstName + " " + studentList.LastName);
            }
        }
    }
}