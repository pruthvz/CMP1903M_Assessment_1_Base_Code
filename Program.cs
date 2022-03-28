using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CMP1903M_Assessment_1_Base_Code;

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

            manualInput = CMP1903M_Assessment_1_Base_Code.Input.manualTextInput();
          

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            List<int> analyse = new List<int>();
            analyse = CMP1903M_Assessment_1_Base_Code.Analyse.analyseText(manualInput);

            //Receive a list of integers back
          

            //Report the results of the analysis
            CMP1903M_Assessment_1_Base_Code.Report.outputConsole(analyse);


            //TO ADD: Get the frequency of individual letters?
            Console.WriteLine("Frequency of individual letters: "+manualInput);
            while (manualInput.Length > 0) {
                Console.Write(manualInput[0] + " = ");
                int cal = 0;
                for (int j = 0; j < manualInput.Length; j++) {
                    if (manualInput[0] == manualInput[j]) {
                    cal++;
                    }
                }
                Console.WriteLine(cal);
                manualInput = manualInput.Replace(manualInput[0].ToString(), string.Empty);
            }
           
        }
    }
}