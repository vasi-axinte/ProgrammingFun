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
            string text = "Extended kindness kindness trifling 55 remember he confined outlived if. Assistance sentiments yet unpleasing say. Open they an busy they my such high. An active dinner wishes at unable hardly no talked on." +
                " Immediate him her resolving his favourite.Wished denote  += abroad at branch at.Delightful remarkably mr on announcing themselves entreaties favourable. About to in so terms voice at. Equal an would is found seems of." +
                "The the particular friendship friendship one sufficient ++ terminated frequently 43 themselves.It more shed went up is roof if loud case. Delay music in lived noise an.Beyond genius really enough passed is up.";

            SearchForNumbers(text);
            SearchForSpecificWord(text);
            SearchForRepeatedWords(text);
            SearchForWordsThatStartWith(text);
            SearcForNonWords(text);
            Console.ReadLine();
        }

        /// <summary>
        /// This method is looking for numbers in our text
        /// </summary>
        /// <param name="text"></param>
        public void SearchForNumbers(string text)
        {
            Regex numberPattern = new Regex(@"\d+");
            MatchCollection found = numberPattern.Matches(text);
            Console.WriteLine("we found {0} numbers in your text", found.Count);
            Console.WriteLine("The numbers are:");
            foreach (var number in found)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// This method is looking for a specified word in our text
        /// </summary>
        public void SearchForSpecificWord(string text)
        {
            Regex specificWordPattern = new Regex(@"\bEmail");
            Match found = specificWordPattern.Match(text);
            if (found.Success)
            {
                Console.WriteLine("We found Email in your text!");
            }
            else Console.WriteLine("We couldn`t find Email in our text"); 
        }

        /// <summary>
        /// This method is looking for 2 words that are repeated one after another
        /// (Example: I have a car car)
        /// </summary>
        public void SearchForRepeatedWords(string text)
        {
            Regex repeatedWordsPattern = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.IgnoreCase);
            MatchCollection found = repeatedWordsPattern.Matches(text);
            Console.WriteLine("{0} repeated words in your text", found.Count);
            foreach(Match repeatedWord in found)
            {
                GroupCollection repeatedWords = repeatedWord.Groups;
                Console.WriteLine("{0} is repeated", repeatedWords["word"].Value);
            }
        }

        /// <summary>
        /// This method is looking for any word that starts with C 
        /// </summary>
        public void SearchForWordsThatStartWith(string text)
        {
            Regex wordsThatStartWithPattern = new Regex(@"\b[C]\w+", RegexOptions.IgnoreCase);
            MatchCollection found = wordsThatStartWithPattern.Matches(text);
            Console.WriteLine("We found {0} words that start with C", found.Count);
        }

        /// <summary>
        /// This method is looking for some special characters ( we decided which )
        /// </summary>
        /// <param name="text"></param>
        public void SearcForNonWords(string text)
        {
            Regex nonWordsPattern = new Regex(@"[$&+:;=#<>^%-]", RegexOptions.IgnorePatternWhitespace);
            MatchCollection found = nonWordsPattern.Matches(text);
            foreach(var nonWord in found)
            {
                Console.WriteLine("{0} is a nonword that has been found in your text", nonWord);  
            } 
        }
    }
}
