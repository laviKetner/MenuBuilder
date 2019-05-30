using System;

namespace Ex04.Menus.Test
{
    public class DelegateMenuTester
    {
        public void RunDelegateTester()
        {
            Delegates.MainMenu delegateMenu;
            InitializeDelegateMenu(out delegateMenu);
            delegateMenu.Show();
        }

        private void InitializeDelegateMenu(out Delegates.MainMenu o_menu)
        {
            o_menu = new Delegates.MainMenu(" --- Delegate Main Menu --- ");

            // Initialize SubMenu - showTimeAndDateSubMenu:
            Delegates.ExecutableItem showTimeAndDateSubMenu = new Delegates.SubMenu("Show Date/Time", null);

            Delegates.ExecutableItem showTimeMenuAction = new Delegates.ExecutableItem("Show Time");
            showTimeMenuAction.Clicked += this.showTime;

            Delegates.ExecutableItem showDateMenuAction = new Delegates.ExecutableItem("Show Date");
            showDateMenuAction.Clicked += this.showDate;

            // Add showTimeMenuAction and showDateMenuAction to SubMenu
            ((Delegates.SubMenu)showTimeAndDateSubMenu).AddItemToMenu(showTimeMenuAction);
            ((Delegates.SubMenu)showTimeAndDateSubMenu).AddItemToMenu(showDateMenuAction);

            // Initialize SubMenu - versionAndCountDigitSubMenu:
            Delegates.ExecutableItem showVersionAndcountDigitsSubMenu = new Delegates.SubMenu("Version and Count Digits", null);

            Delegates.ExecutableItem countDigitsMenuAction = new Delegates.ExecutableItem("Count Digits");
            countDigitsMenuAction.Clicked += this.countDigits;

            Delegates.ExecutableItem versionMenuAction = new Delegates.ExecutableItem("Show Version");
            versionMenuAction.Clicked += this.showVersion;

            // Add versionMenuAction and countDigitsMenuAction to SubMenu
            ((Delegates.SubMenu)showVersionAndcountDigitsSubMenu).AddItemToMenu(countDigitsMenuAction);
            ((Delegates.SubMenu)showVersionAndcountDigitsSubMenu).AddItemToMenu(versionMenuAction);

            // Add showTimeAndDateSubMenu and ShowVersionAndcountDigitsSubMenu to the MainMenu.
            o_menu.AddItemToMenu(showTimeAndDateSubMenu);
            o_menu.AddItemToMenu(showVersionAndcountDigitsSubMenu);
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
