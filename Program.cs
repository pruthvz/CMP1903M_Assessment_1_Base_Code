using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CMP1903M_Assessment_1_Base_Code; // using CMP1903M_Assessment_1_Base, i am able to use the csharp files from different files such as Program.cs, Report.cs, Input.cs, Analyse.cs because they all had the same namespace.

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file 
            string manualInput;
            // getting the manual input and assigning the return value to manualInput string variable.
            manualInput = CMP1903M_Assessment_1_Base_Code.Input.manualTextInput();
          

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            List<int> analyse = new List<int>();
            analyse = CMP1903M_Assessment_1_Base_Code.Analyse.analyseText(manualInput); // here I initialized a list called analyse, and passed the manualInput variable into the function analyseText. 

            //Receive a list of integers back
            // currently here, the analyse variable already holds the list of integers that are needed to be pass down into outputConsole.

            //Report the results of the analysis
            CMP1903M_Assessment_1_Base_Code.Report.outputConsole(analyse); // Here i've passed the list of integers to outputConsole which is defined in Report.cs


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
    }
}