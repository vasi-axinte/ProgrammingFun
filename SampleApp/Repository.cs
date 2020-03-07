using System.IO;
namespace SampleApp
{
    public class Repository
    {

        public void InsertStudent(Student s)
        {



            StreamWriter tsw = new StreamWriter("C:\\Users\\Cristi\\source\\repos\\ThisIs\\Users.Text", true);
            tsw.WriteLine("{0}, {1} , {2} , {3} ", s.FirstName, s.LastName, s.UserName, s.UserAge);
            tsw.Close();





        }
    }
}