namespace SampleApp
{
    public class Grade
    {
        public Grade(int value, string date, int idStudent)
        {
            this.Value = value;
            this.Date = date;
            this.IdStudent = idStudent;
        }
        public int Value { get; set; }
        public string Date { get; set; }
        public int IdStudent { get; set; }
    }
}
