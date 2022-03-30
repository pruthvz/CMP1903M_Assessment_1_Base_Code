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

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {            
            string text;
            Console.Write("Enter sentences ending with * >> "); // asks user for an input
            text = Console.ReadLine(); // reads the input and assigns to text.

            // while loop to check if an * is added to a sentence. if not then it will ask the user to add it.
            while (text.Contains("*") == false) {
                // try and catch statement to catch the error.
                try
                    {
                        Console.Write("Enter sentences ending with * >> ");
                        text = Console.ReadLine();
                    }
                    catch(Exception ex)
                    {
                        Console.Write("Error info: " + ex.Message);
                    }
                 
            } 
            
            while (string.IsNullOrEmpty(text)) // validation to check if something is entered.
                {
                    Console.WriteLine("Can't be empty!");
                    Console.Write("Enter sentences ending with * >> ");
                    text = Console.ReadLine();
                }
            return text; // returns the value of text.
        }
        
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput()
        {
            try
            {
            if (!File.Exists("./FileExampleRead.txt"))
                throw new FileNotFoundException();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File doesn't exist, please create a txt file called 'FileExampleRead.txt'");
            }


            string contents = File.ReadAllText("./FileExampleRead.txt"); // reads the content from the file.
            Console.WriteLine("Text File Output >> " + contents);

            return contents; // returns the contents to be accessed to Program.cs
        }
    }
}
