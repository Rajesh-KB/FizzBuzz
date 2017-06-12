using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    public class FizzBuzzlogic
    {
        #region Validating Input
        public double GetValidInput(string input)
        {
            double validInput;

            try
            {
                Regex regex = new Regex(@"^[0-9]*$");

                while (!Double.TryParse(input, out validInput) || !regex.IsMatch(input) || input == "0")
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine(Environment.NewLine + ConfigurationManager.AppSettings["strEmpty"]);
                    }
                    else if (input == "0")
                    {
                        Console.WriteLine(Environment.NewLine + ConfigurationManager.AppSettings["strZerotxt"]);
                    }
                    else
                    {
                        Console.WriteLine(Environment.NewLine + ConfigurationManager.AppSettings["strInvalidInput"], input);
                    }
                    input = Console.ReadLine();
                }
                return validInput;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion

        #region Termination logic for FizzBuzz App
        public void RunFizzBuzz()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(Environment.NewLine + ConfigurationManager.AppSettings["strAskInput"]);

                    // Validates Input and Returns appropriate value to process Fizzbuzz Logic.
                    double Inputvalue = GetValidInput(Console.ReadLine());

                    // Executes fizzBuzz logic on Validated Input.
                    Console.Write(Environment.NewLine + ConfigurationManager.AppSettings["strResult"], GetFizzBuzz(Inputvalue));

                    Console.WriteLine(Environment.NewLine + "Do you want to continue... ?! Y:N?");
                    char Terminat = Console.ReadKey().KeyChar;
                    if (Terminat == 'N' || Terminat == 'n')
                    {
                        Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine(Environment.NewLine + "Thank you for using...I hope you liked it!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region FizzBuzz computing Logic
        public string GetFizzBuzz(double PassedValue)
        {
            try
            {
                string fbString = "";
                int fizzValue = Convert.ToInt16(ConfigurationManager.AppSettings["FizzValue"]);
                int buzzValue = Convert.ToInt16(ConfigurationManager.AppSettings["BuzzValue"]);

                if ((PassedValue % fizzValue == 0) && (PassedValue % buzzValue == 0))
                    fbString = ConfigurationManager.AppSettings["strFizz"] + ConfigurationManager.AppSettings["strBuzz"] + Environment.NewLine;
                else if (PassedValue % fizzValue == 0)
                    fbString = ConfigurationManager.AppSettings["strFizz"] + Environment.NewLine;
                else if (PassedValue % buzzValue == 0)
                    fbString = ConfigurationManager.AppSettings["strBuzz"] + Environment.NewLine;
                else
                    fbString += PassedValue.ToString() + Environment.NewLine;
                return fbString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
