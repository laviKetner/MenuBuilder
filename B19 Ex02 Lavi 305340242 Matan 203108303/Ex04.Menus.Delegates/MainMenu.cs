using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly List<ExecutableItem> m_MenuItems = new List<ExecutableItem>();
        private string m_MainTitle;
        private BackItem m_Exit = new BackItem(eBackType.Exit);

        public MainMenu(string i_MainTitle)
        {
            m_MainTitle = i_MainTitle;

            // The first item in the MainMenu will be the exit item.
            m_MenuItems.Add(m_Exit);
        }

        public string MainTitle
        {
            get
            {
                return m_MainTitle;
            }

            set
            {
                m_MainTitle = value;
            }
        }

        public void AddItemToMenu(ExecutableItem i_ItemToAdd)
        {
            m_MenuItems.Add(i_ItemToAdd);
        }

        public void RemoveItemFromMenu(ExecutableItem i_ItemToRemove)
        {
            m_MenuItems.Remove(i_ItemToRemove);
        }

        public void ChangeExitName(string i_ExitNameToChange)
        {
            m_Exit.Title = i_ExitNameToChange;
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
                    m_MenuItems[userInput].DoWhenClicked();
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

            Console.WriteLine(MainTitle);

            foreach (ExecutableItem item in m_MenuItems)
            {
                Console.WriteLine("{0}) {1}", indexItemOnMenu, m_MenuItems[indexItemOnMenu].Title);
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
    }
}