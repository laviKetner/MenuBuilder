using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IClickListener
    {
        public void ReportClick()
        {
            PrintVersion();
        }

        public void PrintVersion()
        {
            Console.WriteLine(
@"Version: 19.2.4.32
Press any key to go back...");
            Console.ReadKey();
        }
    }
}
