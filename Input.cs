using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        static readonly string textFile = "inputText.txt";


        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public static string manualTextInput()
        {            
            string text;
            Console.WriteLine("Enter a sentence : ");
            text = Console.ReadLine();

            while (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Can't be empty!");
                    Console.Write("Enter sentences ending with * : ");
                    text = Console.ReadLine();
                }
            return text;
        }
        
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text);

            // read a text file line by ReadLine
            // string [] lines = File.ReadAllLines(fileName);
            // foreach(string line in lines)
            // Console.WriteLine(line); 
            return text;
        }
    }
}
