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
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            bool mainMenu = true;
            while (mainMenu == true)
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
                    Console.WriteLine("Student list:");
                    ShowAllStudents();
                    ShowGradesMenu();
                }
                if (command == 'x')
                {
                    mainMenu = false;
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

        public void ShowAllStudents()
        {
            foreach (var student in _controller.GetAllStudents())
            {
                Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName);
            }
        }

        public void DeleteStudent()
        {
            int id;
            Console.WriteLine("Enter the student id that you want to delete");
            id = int.Parse(Console.ReadLine());
            _controller.DeleteStudent(id);
        }

        public void ShowGradesMenu()
        {
            Console.WriteLine();
            bool gradesMenu = true;
            while (gradesMenu == true)
            {
                ShowGradesMenuCommands();
                int gradesCommand = int.Parse(Console.ReadLine());
                if (gradesCommand == 1)
                {
                    AddGrade();
                    Console.WriteLine();
                }
                if (gradesCommand == 2)
                {
                    DeleteGrade();
                    Console.WriteLine();
                }
                if (gradesCommand == 3)
                {
                    ShowStudentsAndGrades();
                    Console.WriteLine();
                }
                if (gradesCommand == 4)
                {
                    ShowMainMenu();
                    Console.WriteLine();
                }
                if (gradesCommand == 'x')
                {
                    gradesMenu = false;
                }
            }
        }

        public void ShowGradesMenuCommands()
        {
            Console.WriteLine("Grades menu:");
            Console.WriteLine("1.Add grade");
            Console.WriteLine("2.Delete grade");
            Console.WriteLine("3.Show all students");
            Console.WriteLine("4.Back to main menu");
        }

        public void AddGrade()
        {
            Console.WriteLine("Insert Student Id");
            var studentId = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert the grade that you want to be added");
            var value = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert date");
            DateTime dateReader = DateTime.Parse(Console.ReadLine());
            var date = dateReader.ToString();

            var gradeDetails = new Grade(value, date, studentId);
            _controller.AddGrade(gradeDetails);
        }

        public void DeleteGrade()
        {
            Console.WriteLine("Insert student id");
            int studentId = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert the grade that you want to be delelted");
            int value = (int.Parse(Console.ReadLine()));
            _controller.DeleteGrade(studentId, value);
        }

        public void ShowStudentsAndGrades()
        {
            foreach (var student in _controller.ShowStudentsAndGrades())
            {
                Console.WriteLine(student.IdStudent + " " + student.Value + " " + student.Date);
            }
        }
    }
}