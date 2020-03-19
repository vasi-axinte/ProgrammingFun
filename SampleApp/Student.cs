namespace SampleApp
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, string username, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Age = age;
            this.Id = id;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

    }
}