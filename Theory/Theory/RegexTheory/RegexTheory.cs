using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Theory.RegexTheory
{
    /// <summary>
    /// Regex class offers methods and properties to parse a large text to find 
    /// patterns of characters.
    /// </summary>
    public class RegexTheory
    {
        public void Execute()
        {
            Console.WriteLine(CheckIfNumber(20));
            SearchForMatchAtBeggining();
            SearchForMatchAtTheEnd();
            SearchForMatchNonWords();
            SearchForMatchInRange();
            SearchForMatchWord("Cristi is cool Cristi is dumb too:");
            Console.ReadLine();
        }

        public bool CheckIfNumber(int number)
        {
            Regex numberPattern = new Regex("[^0-9]");
            return !numberPattern.IsMatch(number.ToString());
        }

        /// <summary>
        /// "^" this element search if the word(after this element)  
        /// is at the beggining of the line
        /// Here it will return Administrator if the method finds the word
        /// </summary>
        public void SearchForMatchAtBeggining()
        {
            Regex patternBeggining = new Regex(@"^Administrator");
            Match text = patternBeggining.Match("Administrator has full access");
            if (text.Success)
            {
                Console.WriteLine(text.Value);
            }
        }

        /// <summary>
        /// "$" element search if the word (before this element) is at the
        /// end of the line
        /// here it will return Email if the methods finds the word
        /// </summary>
        public void SearchForMatchAtTheEnd()
        {
            Regex patternEnd = new Regex(@"Email$");
            Match text = patternEnd.Match("This is your Email");
            if (text.Success)
            {
                 Console.WriteLine(text.Value);
            } 
        }
        /// <summary>
        /// "\W" is used to match any non-word character
        /// here it will return "+"
        /// </summary>
        public void SearchForMatchNonWords()
        {
            Regex nonWordPattern = new Regex(@"\W");
            Match text = nonWordPattern.Match("Te+st");
            if (text.Success)
            {
                Console.WriteLine(text.Value);
            }
        }

        /// <summary>
        /// "[]" it is used to match the range of character
        /// This will return one character (a or b or c or d)
        /// "[a-z] it is used to match any character in the range of a-z
        /// </summary>
        public void SearchForMatchInRange()
        {
            Regex inRangePattern = new Regex(@"[abcd]");
            Match text = inRangePattern.Match("zzzzzzzbcdxxxx");
            if (text.Success)
            {
                Console.WriteLine(text.Value);
            }

            Regex inSpecifiedRange = new Regex(@"[c-j]");
            Match text2 = inSpecifiedRange.Match("Acristi");
            if (text2.Success)
            {
                Console.WriteLine(text2.Value);
            }
        }

        /// <summary>
        /// \b element match a word boundary
        /// </summary>
        public void SearchForMatchWord(string text)
        {
            int i = 0;
            MatchCollection match = Regex.Matches(text, @"\bCristi");
            foreach (Match find in match)
            {  
                i++;
                Console.WriteLine(find + " " + "has been found:" + " " + i + " " + "times");
            }
        }
    }
}
