using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CMP1903M_Assessment_1_Base_Code; // using CMP1903M_Assessment_1_Base, i am able to use the csharp files from different files such as Program.cs, Report.cs, Input.cs, Analyse.cs because they all had the same namespace.
using static CMP1903M_Assessment_1_Base_Code.Input; 
using static CMP1903M_Assessment_1_Base_Code.Analyse; 
using static CMP1903M_Assessment_1_Base_Code.Report; 

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            string manualInput;
            string fileInput;
            string userChoice;
            // From the reviews I got, i was asked to see if file reading works too. So i added a if statement where the user can choose between Manual input && text file input
            Console.WriteLine("Choose 1 for Manual Input && 2 for Text File Input.");
            userChoice = Console.ReadLine();

            //Create an 'Create' 'Analyse' 'Report' object
            Input inputObject = new Input();
            Analyse anaylseObject = new Analyse();
            Report reportObject = new Report();

            // 1 = manual text input
            if (userChoice == "1"){
                //Get either manually entered text, or text from a file 
                // getting the manual input and assigning the return value to manualInput string variable.
                manualInput = inputObject.manualTextInput();

                //Pass the text input to the 'analyseText' method
                List<int> analyse = new List<int>();
                analyse = anaylseObject.analyseText(manualInput); // here I initialized a list called analyse, and passed the manualInput variable into the function analyseText. 

                //Report the results of the analysis
                reportObject.outputConsole(analyse); // Here i've passed the list of integers to outputConsole which is defined in Report.cs

                //TO ADD: Get the frequency of individual letters?
                Console.WriteLine("Frequency of individual letters: "+manualInput); // using the manualInput 
                while (manualInput.Length > 0) {
                    Console.Write(manualInput[0] + " = ");
                    int cal = 0;
                    for (int j = 0; j < manualInput.Length; j++) {
                        if (manualInput[0] == manualInput[j]) {
                        cal++;
                        }
                    }
                    Console.WriteLine(cal); // logs out all the letters with a number that shows how many times a letter was used in the manualInput
                    manualInput = manualInput.Replace(manualInput[0].ToString(), string.Empty); 
                }
                }
            // or text file input.
            else if (userChoice == "2") {
                // reads text files and outputs the entire message.
                fileInput = inputObject.fileTextInput(); 

                //Pass the text input to the 'analyseText' method
                List<int> analyse = new List<int>();
                analyse = anaylseObject.analyseText(fileInput); // here I initialized a list called analyse, and passed down what the file read into the function analyseText. 

                //Report the results of the analysis
                reportObject.outputConsole(analyse); // Here i've passed the list of integers to outputConsole which is defined in Report.cs
            }

            else{
                Console.WriteLine("Please enter from the choices above!");
            }

           
        }
    }
}