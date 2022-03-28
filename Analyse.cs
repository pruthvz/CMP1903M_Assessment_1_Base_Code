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
        public static List<int> analyseText(string input)
        {
            int vowelsTotal = 0;
            int constantTotal = 0;
            int numOfSentences = 0;
            int numOfLowercase = 0;
            input = input.Replace(" ", String.Empty);

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }

            // string characters
            int length = input.Length;
            values[0] = length;


            // number of words in the sentence
            string[] words = input.Split(" ");
            // Console.WriteLine("Count of words: " + words.Length); 

            // find number of sentence
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == '*')
                {
                    numOfSentences++;
                }
            }
            // Console.WriteLine("Number of sentences: " + numOfSentences);
            values[1] = numOfSentences;

            
            // find number of vowels in sentence;
            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vowelsTotal++;
                }
            }

            // Console.WriteLine("Vowels count: " + vowelsTotal);
            values[2] = vowelsTotal;

            // find number of constant in sentence;
            for (int i = 0; i < input.Length; i++)
            {
                constantTotal++;
            }

            constantTotal = constantTotal - vowelsTotal;

            // Console.WriteLine("Constant count: " + constantTotal);
            values[3] = constantTotal;

            // find number of uppercase case;
            int counter = 0;
            for(int i=0; i< input.Length;i++)
            {
                //if character is upper add +1 to counter
                if(char.IsUpper(input[i]))
                {
                    counter++;
                }
            }
            // Console.WriteLine("The sentence has " + counter + " uppercases.");
            values[4] = counter;

            // find number of lowercase;

            for (int i = 0; i < input.Length; i++)
            {
                numOfLowercase++;
            }

            numOfLowercase = numOfLowercase - counter;
            // Console.WriteLine("Lowercase count: " + numOfLowercase);
            values[5] = numOfLowercase;

            return values;
        }
    }
}
