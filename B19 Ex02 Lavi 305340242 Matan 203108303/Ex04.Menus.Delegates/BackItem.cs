using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public enum eBackType
    {
        Exit,
        Back,
    }

    public class BackItem : ExecutableItem
    {
        private eBackType m_TypeOfExit;
        private bool m_WasClicked = false;

        public BackItem(eBackType i_TypeOfExit)
            : base(i_TypeOfExit.ToString())
        {
            m_TypeOfExit = i_TypeOfExit;
        }

        public bool WasClicked
        {
            get
            {
                return m_WasClicked;
            }

            set
            {
                m_WasClicked = value;
            }
        }

        public override void DoWhenClicked()
        {
            if (m_WasClicked)
            {
                WasClicked = false;
                OnClicked();
            }
            else
            {
                WasClicked = true;
            }
        }
    }
}
