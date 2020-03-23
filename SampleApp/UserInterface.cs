using System;

namespace SampleApp
{
    public class UserInterface
    {
        private StudentsController _controllerStudents;
        private GradesController _controllerGrades;
        private StudentGradesController _controllerStudentGrades;

        public UserInterface()
        {
            _controllerStudents = new StudentsController();
            _controllerGrades = new GradesController();
            _controllerStudentGrades = new StudentGradesController();
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
                if (command == 5)
                {
                    ShowAllStudents();
                    Console.WriteLine();
                    UpdateStudentDetails();
                    Console.WriteLine();
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
            Console.WriteLine("5.Edit student details");
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
            _controllerStudents.AddStudent(studentToBeAdded);
        }

        public void ShowAllStudents()
        {
            foreach (var student in _controllerStudents.GetAllStudents())
            {
                Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName);
            }
        }

        public void DeleteStudent()
        {
            int id;
            Console.WriteLine("Enter the student id that you want to delete");
            id = int.Parse(Console.ReadLine());
            _controllerStudents.DeleteStudent(id);
        }

        public void UpdateStudentDetails()
        {
            Console.WriteLine("Insert student Id");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert new fristname");
            var firstName = Console.ReadLine();
            Console.WriteLine("Insert new lastname");
            var lastName = Console.ReadLine();
            Console.WriteLine("Insert new username");
            var username = Console.ReadLine();
            Console.WriteLine("Insert new age");
            int age = int.Parse(Console.ReadLine());

            var student = new Student(studentId, firstName, lastName, username, age);
            _controllerStudents.UpdateStudentDetails(student);
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
                    ShowGrades();
                    DeleteGrade();
                    Console.WriteLine();
                }
                if (gradesCommand == 3)
                {
                    ShowGrades();
                    Console.WriteLine();
                }
                if (gradesCommand == 4)
                {
                    ShowAllGradesForStudent();
                    Console.WriteLine();
                }
                if (gradesCommand == 5)
                {
                    ShowStudentsWithGradesBiggerThan();
                    Console.WriteLine();
                }
                if (gradesCommand == 6)
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
            Console.WriteLine("3.Show all grades");
            Console.WriteLine("4.Show all grades for student");
            Console.WriteLine("5.Show all students with grades bigger than");
            Console.WriteLine("6.Back to main menu");
        }

        public void AddGrade()
        {
            Console.WriteLine("Insert Student Id");
            int studentId = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert the grade that you want to be added");
            var value = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert date");
            DateTime dateReader = DateTime.Parse(Console.ReadLine());
            var date = dateReader.ToString();
            int gradeId = 0;

            var gradeDetails = new Grade(gradeId, value, date, studentId);
            _controllerGrades.AddGrade(gradeDetails);
        }

        public void ShowGrades()
        {
            foreach (var student in _controllerGrades.GetAllGrades())
            {
                Console.WriteLine(student.IdGrade + " " + student.Value + " " + student.Date + " " + student.IdStudent);
            }
        }

        public void DeleteGrade()
        {
            Console.WriteLine("Insert gradeId");
            int gradeId = (int.Parse(Console.ReadLine()));
            _controllerGrades.DeleteGrade(gradeId);
        }

        public void ShowAllGradesForStudent()
        {
            Console.WriteLine("Insert IdStudent");
            int studentId = int.Parse(Console.ReadLine());
            foreach (var grade in _controllerGrades.GetAllGradesForStudent(studentId))
            {
                Console.WriteLine(grade.IdGrade + " " + grade.Value + " " + grade.IdStudent);
            }

        }

        public void ShowStudentsWithGradesBiggerThan()
        {
            Console.WriteLine("Insert value");
            int check = int.Parse(Console.ReadLine());
            foreach (var studentAndGrade in _controllerStudentGrades.GetStudentsWithGradeBiggerThan(check))
            {
                Console.WriteLine(studentAndGrade.IdGrade + " " + studentAndGrade.Value + " " + studentAndGrade.FirstName + " " + studentAndGrade.LastName + " " + studentAndGrade.IdStudent);
            }
        }
    }
}