using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public  List<int> analyseText(string input)
        {
            // local variables defined.
            int vowelsTotal = 0;
            int constantTotal = 0;
            int numOfSentences = 0;
            int numOfLowercase = 0;
            input = input.Replace(" ", String.Empty); // this will remove any whitespaces.

            //List of integers to hold the first six measurements: since i added an extra value I changed it to six
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }

            // string characters
            int length = input.Length; // finds the length of the input
            values[0] = length; // pushes the value to values at index of 0


            // number of words in the sentence
            string[] words = input.Split(" ");
            // Console.WriteLine("Count of words: " + words.Length); 

            // find number of sentence
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == '*') // if an * is placed at the end of a sentence it will be treated as the end of the sentence.
                {
                    numOfSentences++;
                }
            }
            values[1] = numOfSentences; // pushes the final value to values at index of 1

            
            // find number of vowels in sentence;
            // for loop which checks the entire sentences and then an if statement to check if it matches the vowels which are defined.
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vowelsTotal++;
                }
            }

            values[2] = vowelsTotal; // pushes vowelsTotal to values at index of 2

            // find number of constant in sentence;
            for (int i = 0; i < input.Length; i++) // gets all the characters in the sentence.
            {
                constantTotal++;
            }

            constantTotal = constantTotal - vowelsTotal; // removes the constant by vowels which only leaves out all the constants.

            values[3] = constantTotal; // pushes the constantTotal to values at index of 3

            // find number of uppercase case;
            // Here i run a for loop to loop through all the characters in the sentence that is inputted.
            int counter = 0;
            for(int i=0; i< input.Length;i++)
            {
                //if character is upper add +1 to counter
                if(char.IsUpper(input[i])) // using the IsUpper built in function. if it finds a uppercase it will +=1 to counter.
                {
                    counter++;
                }
            }
            values[4] = counter; // pushes the counter value to values at index of 4

            // find number of lowercase;
            for (int i = 0; i < input.Length; i++) // similar to constants. i run a for loop through all the characters.
            {
                numOfLowercase++;
            }

            numOfLowercase = numOfLowercase - counter; // take away number of lowercase by the number of uppercase we get the final answer of all the lowercases.
            values[5] = numOfLowercase; // pushes the lowercase value to values at index of 5

            return values; // returns the list with all the values.
        }
    }
}
