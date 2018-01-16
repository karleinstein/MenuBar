namespace LogicNP.ShellObjects
{
    using System;
    using System.ComponentModel;

    public class ShellPopupCancelEventArgs : CancelEventArgs
    {
        private ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba;

        internal ShellPopupCancelEventArgs(ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba)
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

