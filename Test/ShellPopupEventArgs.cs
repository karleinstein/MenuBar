namespace LogicNP.ShellObjects
{
    using System;

    public class ShellPopupEventArgs : EventArgs
    {
        private ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba;

        internal ShellPopupEventArgs(ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba)
        {
            this.c5dd3655f701702e8bd024f9e7a4dd4ba = c5dd3655f701702e8bd024f9e7a4dd4ba;
        }

        public ShellPopup Popup
        {
            get
            {
                return this.c5dd3655f701702e8bd024f9e7a4dd4ba;
            }
        }
    }
}

