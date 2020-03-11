namespace SampleApp
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, string userName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.age = age;
            this.id = id;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public int age { get; set; }

        public int id { get; set; }

    }
}