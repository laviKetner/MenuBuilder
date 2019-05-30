using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ExecutableItem
    {
        private string m_Title;

        public event Action<ExecutableItem> Clicked;

        public ExecutableItem(string i_Title)
        {
            m_Title = i_Title;

            // Clear the screen after Clicking this item.
            Clicked += this.ClearScreen;
        }

        private void ClearScreen(ExecutableItem i_ItemInMenuSender)
        {
            Console.Clear();
        }

        public string Title
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

        public virtual void DoWhenClicked()
        {
            OnClicked();
        }

        protected virtual void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke(this);
            }
        }
    }
}
