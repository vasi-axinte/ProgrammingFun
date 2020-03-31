namespace SampleApp
{
    public class StudentAverage
    {
        public StudentAverage(string lastName, string firstName, int average)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Average = average;
        }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int Average { get; set; }

    }
}