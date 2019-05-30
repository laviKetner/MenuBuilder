using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public interface IClickListener
    {
        void ReportClick();
    }

    public class ExecutableItem : MenuItem, IClickListener
    {
        private readonly List<IClickListener> m_ClickObservers = new List<IClickListener>();

        public ExecutableItem(string i_Title)
             : base(i_Title)
        {
            m_ClickObservers.Add(this);
        }

        private void NotifyAllClickObservers()
        {
            foreach (IClickListener observer in m_ClickObservers)
            {
                observer.ReportClick();
            }
        }

        public void ReportClick()
        {
            cleanScreen();
        }

        private void cleanScreen()
        {
            Console.Clear();
        }

        public void DoWhenClicked()
        {
            NotifyAllClickObservers();
        }

        public void AttachListener(IClickListener i_ClickObserver)
        {
            m_ClickObservers.Add(i_ClickObserver);
        }
    }
}
