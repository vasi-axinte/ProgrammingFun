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
            bool commandExecution = true;
            while (commandExecution == true)
            {
                ShowMainMenuCommands();
                int command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    AddStudent();
                    Console.WriteLine();
                }
                if (command == 2)
                {
                    ShowAllStudents();
                    Console.WriteLine();
                }
                if (command == 3)
                {
                    DeleteStudent();
                    Console.WriteLine();
                }
                if (command == 4)
                {
                    ShowAllStudents();
                    Console.WriteLine();
                    while (commandExecution == true)
                    {
                        ShowGradesMenuCommands();
                        int gradesCommand = int.Parse(Console.ReadLine());
                        if (gradesCommand == 1)
                        {
                            AddGrade();
                        }
                        if (gradesCommand == 'x')
                        {
                            commandExecution = false;
                        }
                    }
                }
                if (command == 'x')
                {
                    commandExecution = false;
                }
            }
        }

        public void ShowMainMenuCommands()
        {
            Console.WriteLine("Main menu:");
            Console.WriteLine("1.Add new student");
            Console.WriteLine("2.Show all students");
            Console.WriteLine("3.Delete student by id");
            Console.WriteLine("4.Grades");
        }

        public void ShowGradesMenuCommands()
        {
            Console.WriteLine("Grades menu:");
            Console.WriteLine("1.Add grade");
        }

        public void AddStudent()
        {
            Console.Write("First Name: ");
            var firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastName = Console.ReadLine();
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int id = 0;

            var studentToBeAdded = new Student(id, firstName, lastName, username, age);
            _controller.AddStudent(studentToBeAdded);
        }

        public void AddGrade()
        {
            Console.WriteLine("Insert Student Id");
            int studentId = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert the grade that you want to be added");
            int grade = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert date");
            DateTime dateReader = DateTime.Parse(Console.ReadLine());
            string date = dateReader.ToString();
            _controller.AddGrade(studentId, grade, date);
        }

        public void ShowAllStudents()
        {
            foreach (var studentList in _controller.GetAllStudents())
            {
                Console.WriteLine(studentList.Id + " " + studentList.FirstName + " " + studentList.LastName);
            }
        }

        public void DeleteStudent()
        {
            int id;
            Console.WriteLine("Enter the student id that you want to delete");
            id = int.Parse(Console.ReadLine());
            _controller.DeleteStudent(id);
        }
    }
}