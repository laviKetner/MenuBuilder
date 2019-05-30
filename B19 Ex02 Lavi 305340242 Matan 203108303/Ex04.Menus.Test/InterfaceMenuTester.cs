using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenuTester
    {
        public void RunInterfaceTester()
        {
            Interfaces.MainMenu interfaceMenu;
            InitializeInterfaceMainMenu(out interfaceMenu);
            interfaceMenu.Show();
        }

        public void InitializeInterfaceMainMenu(out Interfaces.MainMenu o_InterfaceMainMenu)
        {
            // Initialize the Main menu
            o_InterfaceMainMenu = new Interfaces.MainMenu("--- Interface Main Menu ---", eMainMenuType.FirstMenu);

            // Initialize the Date/Time menu
            Interfaces.MainMenu dateTimeInterfaceMenu = new Interfaces.MainMenu("Show Date/Time", eMainMenuType.SecondaryMenu);
            Interfaces.ExecutableItem showTimeExe = new ExecutableItem("Show Time");
            Interfaces.ExecutableItem showDateExe = new ExecutableItem("Show Date");

            // Add showTimeExe and showDateExe as a listeners - it mean that when the user click on them the ShowTime and ShowDate method will start.
            showTimeExe.AttachListener(new ShowTime());
            showDateExe.AttachListener(new ShowDate());

            dateTimeInterfaceMenu.AddItemToMenu(showTimeExe);
            dateTimeInterfaceMenu.AddItemToMenu(showDateExe);
            o_InterfaceMainMenu.AddItemToMenu(dateTimeInterfaceMenu);

            Interfaces.MainMenu versionAndCountDigits = new Interfaces.MainMenu("Version and Count Digits", eMainMenuType.SecondaryMenu);
            Interfaces.ExecutableItem countDigitsExe = new ExecutableItem("Count Digits");
            Interfaces.ExecutableItem showVersionExe = new ExecutableItem("Show Version");

            countDigitsExe.AttachListener(new CountDigits());
            showVersionExe.AttachListener(new ShowVersion());

            versionAndCountDigits.AddItemToMenu(countDigitsExe);
            versionAndCountDigits.AddItemToMenu(showVersionExe);
            o_InterfaceMainMenu.AddItemToMenu(versionAndCountDigits);
        }

        // ---------------------- Actions items ----------------------
        private void showTime(Delegates.ExecutableItem i_ItemInMenuSender)
        {
            ShowTime time = new ShowTime();
            time.printTime();
        }

        private void showDate(Delegates.ExecutableItem i_ItemInMenuSender)
        {
            ShowDate date = new ShowDate();
            date.printDate();
        }

        private void showVersion(Delegates.ExecutableItem i_ItemInMenuSender)
        {
            ShowVersion version = new ShowVersion();
            version.PrintVersion();
        }

        private void countDigits(Delegates.ExecutableItem i_ItemInMenuSender)
        {
            CountDigits countDigits = new CountDigits();
            countDigits.PrintCountDigits();
        }

        // --------------------- End Actions items ---------------------
    }
}
