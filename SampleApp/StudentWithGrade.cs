using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class StudentWithGrade
    {
        public StudentWithGrade(int idGrade, int value, string firstName, string lastName, int idStudent)
        {
            this.IdGrade = idGrade;
            this.IdStudent = idStudent;
            this.Value = value;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int IdGrade { get; set; }

        public int IdStudent { get; set; }

        public int Value { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}