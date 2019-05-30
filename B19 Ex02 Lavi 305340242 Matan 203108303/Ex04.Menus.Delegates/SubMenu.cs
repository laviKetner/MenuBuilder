using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : ExecutableItem
    {
        private MainMenu m_MainMenu;
        private BackItem m_Back = new BackItem(eBackType.Back);

        public SubMenu(string i_Title, SubMenu i_PreviousMenu)
            : base(i_Title)
        {
            m_MainMenu = new MainMenu(i_Title);
            m_MainMenu.ChangeExitName(eBackType.Back.ToString());
        }

        public void AddItemToMenu(ExecutableItem i_MenuItemToAdd)
        {
            m_MainMenu.AddItemToMenu(i_MenuItemToAdd);
        }

        public void ShowMenu()
        {
            Console.Clear();
            m_MainMenu.Show();
        }

        public void RemoveFromMenu(ExecutableItem i_MenuItemToRemove)
        {
            m_MainMenu.RemoveItemFromMenu(i_MenuItemToRemove);
        }

        public override void DoWhenClicked()
        {
            OnClicked();
            ShowMenu();
        }
    }
}
