namespace SampleApp
{
    public class Student
    {
        public Student(string firstName, string lastName, string userName, string userAge)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.UserAge = userAge;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string UserAge { get; set; }
    }
}