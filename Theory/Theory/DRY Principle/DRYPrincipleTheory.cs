using System;

namespace Theory.DRYPrinciple
{
    /// <summary>
    /// DRY - Don`t repeat yourself 
    /// DRY principle says : a pice of logic should only be represented once in an aplication
    /// A code that is common to at least two parts of your system, should be factored out into
    /// a single location so, that both parts call it.
    /// This repetition is often solved by using methods and classes
    /// </summary>
    public class DRYPrincipleTheory
    {
        /// <summary>
        /// In our example, we have our class Student, and we know that all of our students
        /// have the same university and specialization, so, instead of making a constructor
        /// with 4 parameters and repeat the same value over and over again, we can make a 
        /// constructor with only 2 parameters
        /// </summary>
        public void Execute()
        {
            Student firstStudent = new Student("Cristi", "Axinte");
            firstStudent.WriteAllStudentDetails("Cristi", "Axinte");

            Student secondStudent = new Student("Mihai", "Ion");
            secondStudent.WriteAllStudentDetails("Mihai", "Ion");

            Console.ReadLine();
        }
    }
}
