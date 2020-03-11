namespace SampleApp
{
    public class Student
    {
        public Student(string firstName, string lastName, string userName, int Age, int Id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Age = Age;
            this.Id = Id;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

    }
}