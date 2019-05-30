using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class BackItem : MenuItem
    {
        public enum eBackType
        {
            Exit,
            Back,
        }

        public BackItem(string i_Title) : base(i_Title)
        {
        }
    }
}
