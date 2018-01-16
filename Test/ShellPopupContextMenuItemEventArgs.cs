namespace LogicNP.ShellObjects
{
    using System;

    public class ShellPopupContextMenuItemEventArgs : ContextMenuItemEventArgs
    {
        private ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba;

        internal ShellPopupContextMenuItemEventArgs(ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba, string c179b6b5756a86e7e82610ea64887e1f0, int cfc56349b18f430cf61d5985b21a5a888) : base(c179b6b5756a86e7e82610ea64887e1f0, cfc56349b18f430cf61d5985b21a5a888)
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

