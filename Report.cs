using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        List<int> values = new List<int>();
		public void outputConsole(List<int> values){ // outputConsole, needed a parameter of values to access all the integers to console log to the user.
            // I defined a list of all output messages. 
            string[] words = {"Total Number of Characters: ","Sentences: ", "Vowels in sentences: ", "Consonants in sentences: ", "Upper case: ", "Lower case: " };

            // using a foreach loop. I was able to place the correct message with the correct value.
            foreach (var tuple in values.Zip(words, (x, y) => (Num: x, Word: y)))
            {
                Console.WriteLine($"{tuple.Word}: {tuple.Num}"); // displays the message with the value according to it.
            }
        }

    }
}
