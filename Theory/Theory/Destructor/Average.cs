using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Destructor
{
    /// <summary>
    /// Constructor Average will get some grades
    /// </summary>
    public class Average
    {
        public Average(int grade1, int grade2, int grade3)
        {
            this.Grade1 = grade1;
            this.Grade2 = grade2;
            this.Grade3 = grade3;
        }

        /// <summary>
        /// Method MakeAverage will make the average from the grades that Constructor Average got
        /// </summary>
        public void MakeAverage()
        {
            int result = (Grade1 + Grade2 + Grade3) / 3;
            Console.WriteLine(result);
        }

        public int Grade1 { get; set; }

        public int Grade2 { get; set; }

        public int Grade3 { get; set; }

        /// <summary>
        /// This is our destructor
        /// </summary>
        ~Average()
        {
            Console.WriteLine("Destructor was called");
            Console.ReadLine();
        }


    }
}
