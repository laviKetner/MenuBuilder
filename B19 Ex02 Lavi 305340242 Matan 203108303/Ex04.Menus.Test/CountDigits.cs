using System;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test 
{
    public class CountDigits : IClickListener
    {
        public void ReportClick()
        {
            PrintCountDigits();
        }

        public void PrintCountDigits()
        {
            Console.WriteLine("Please enter sentence: ");
            string stringFromUser = Console.ReadLine();

            StringBuilder printCountDigitsToConsole = new StringBuilder();
            printCountDigitsToConsole.AppendLine("The sentence contain: ");
            printCountDigitsToConsole.AppendLine(HowMuchDigits(stringFromUser).ToString());
            printCountDigitsToConsole.AppendLine("Press any key to go back...");

            Console.WriteLine(printCountDigitsToConsole.ToString());
            Console.ReadKey();
        }

        private int HowMuchDigits(string i_StringFromUser)
        {
            int countHowMuchDigit = 0;

            foreach (char currentChar in i_StringFromUser)
            {
                if (currentChar > '0' && currentChar < '9') 
                {
                    countHowMuchDigit++;
                }
            }

            return countHowMuchDigit;
        }
    }
}
