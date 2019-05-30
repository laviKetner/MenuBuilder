using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        private readonly List<MenuItem> m_MenuItems = new List<MenuItem>();

        public MainMenu(string i_Title, eMainMenuType i_MenuType)
             : base(i_Title)
        {
            string backTitle = i_MenuType == eMainMenuType.FirstMenu ? BackItem.eBackType.Exit.ToString() : BackItem.eBackType.Back.ToString();
            BackItem backItem = new BackItem(backTitle);
            m_MenuItems.Add(backItem);
        }

        public void AddItemToMenu(MenuItem m_MenuItem)
        {
            m_MenuItems.Add(m_MenuItem);
        }

        public void Show()
        {
            bool IsUserPressExitOrBack = false;
            while (!IsUserPressExitOrBack)
            {
                Console.Clear();
                printMenuItems();

                try
                {
                    int userInput = GetUserChoiceInput();
                    if (m_MenuItems[userInput] is BackItem)
                    {
                        IsUserPressExitOrBack = true;
                    }

                    // User pick item from menu
                    applyMenuItem(m_MenuItems[userInput], out IsUserPressExitOrBack);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter currect option number.");
                    Console.ReadKey();
                }
            }
        }

        private void printMenuItems()
        {
            byte indexItemOnMenu = 0;

            Console.WriteLine(MenuTitle);

            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine("{0}) {1}", indexItemOnMenu, m_MenuItems[indexItemOnMenu].MenuTitle);
                indexItemOnMenu++;
            }
        }

        private int GetUserChoiceInput()
        {
            Console.Write("Your Choice is: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= m_MenuItems.Count || userInput < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return userInput;
        }

        private void applyMenuItem(MenuItem i_MenuItem, out bool o_ExitMenu)
        {
            o_ExitMenu = false;
            if (i_MenuItem is BackItem)
            {
                o_ExitMenu = true;
            }
            else if (i_MenuItem is MainMenu)
            {
                (i_MenuItem as MainMenu).Show();
            }
            else if (i_MenuItem is ExecutableItem)
            {
                (i_MenuItem as ExecutableItem).DoWhenClicked();
            }
        }
    }
}
