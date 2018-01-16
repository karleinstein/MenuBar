namespace LogicNP.ShellObjects
{
    using System;

    public class ShellPopupContextMenuEventArgs : ContextMenuEventArgs
    {
        internal ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba;

        internal ShellPopupContextMenuEventArgs(ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba, ShellContextMenu c2e6a1e6fa1b2666d36110f10f68b715f) : base(c2e6a1e6fa1b2666d36110f10f68b715f)
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

