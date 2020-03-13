namespace SampleApp
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, string userName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Age = age;
            this.Id = id;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

    }
}