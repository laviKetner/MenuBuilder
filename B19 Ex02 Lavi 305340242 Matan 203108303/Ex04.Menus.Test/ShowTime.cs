using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IClickListener
    {
        public void ReportClick()
        {
            printTime();
        }

        public void printTime()
        {
            Console.WriteLine(
@"Current time is: {0}.
Press any key to go back...",
               DateTime.Now.TimeOfDay);
            Console.ReadKey();
        }
    }
}