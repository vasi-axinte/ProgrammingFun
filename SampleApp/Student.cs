namespace SampleApp
{
    public class Student
    {
        public Student(string firstName, string lastName, string userName, int Age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Age = Age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }
    }
}