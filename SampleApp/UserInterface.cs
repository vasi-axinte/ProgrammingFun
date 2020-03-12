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
            bool commandExecution = true;
            while (commandExecution == true)
            {
                MenuCommands();
                int command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    AddStudent();
                    Console.WriteLine();
                }
                else if (command == 2)
                {
                    _controller.GetAllStudents();
                    ShowAllStudents();
                    Console.WriteLine();
                }
                else if (command == 3)
                {
                    int idToBeDeleted;
                    Console.WriteLine("Enter the id that you want to delete");
                    idToBeDeleted = int.Parse(Console.ReadLine());
                    _controller.StudentsToBeDeleted(idToBeDeleted);
                    ShowAllStudents();
                }
                else
                {
                    Console.WriteLine("Not a valid command");
                    commandExecution = false;
                }
            }
        }

        public void MenuCommands()
        {
            Console.WriteLine("Main menu:");
            Console.WriteLine("1.Add new student");
            Console.WriteLine("2.Show all students");
            Console.WriteLine("3.Delete students by id");
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