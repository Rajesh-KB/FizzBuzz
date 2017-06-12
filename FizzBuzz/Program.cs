using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("****************************************************************************************");
                Console.WriteLine("---------------------------------Welcome to FizzBuzz------------------------------------");
                Console.WriteLine("****************************************************************************************");
                FizzBuzzlogic obj = new FizzBuzzlogic();
                obj.RunFizzBuzz();             
               
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}