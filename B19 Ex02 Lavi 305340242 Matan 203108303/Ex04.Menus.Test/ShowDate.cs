using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IClickListener
    {
        public void ReportClick()
        {
            printDate();
        }

        public void printDate()
        {
            Console.WriteLine(
@"Current date is: {0}.
Press any key to go back....",
           DateTime.Now.Date.ToShortDateString());
            Console.ReadKey();
        }
    }
}
