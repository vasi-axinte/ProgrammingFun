namespace SampleApp
{
    public class Grade
    {
        public Grade(int idGrade, int value, string date, int idStudent)
        {
            this.IdGrade = idGrade;
            this.Value = value;
            this.Date = date;
            this.IdStudent = idStudent;
        }
        public int Value { get; set; }

        public string Date { get; set; }

        public int IdStudent { get; set; }

        public int IdGrade { get; set; }
    }
}