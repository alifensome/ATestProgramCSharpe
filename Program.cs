using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program to reverse a string and print it out
            string OldString = "Zebra"; // string which will be reversed
            string NewString = ""; // string to hold 
            // loop over length of chars in string
            for (int i = 0; i < OldString.Length; i++)
            {
                NewString += OldString[OldString.Length-i-1]; // starting at the last index add onto the NewString
            }
            System.Console.WriteLine(NewString); // output to concole
            System.Console.Read(); // Read so as to not close concole

        }
    }
}
