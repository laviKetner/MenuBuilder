namespace Ex04.Menus.Interfaces
{
    public enum eMainMenuType
    {
        FirstMenu,
        SecondaryMenu,
    }

    public class MenuItem
    {
        private string m_Title;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        public string MenuTitle
        {
            get
            {
                return m_Title;
            }

            set
            {
                m_Title = value;
            }
        }
    }
}
