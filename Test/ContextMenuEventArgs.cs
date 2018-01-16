namespace LogicNP.ShellObjects
{
    using System;

    public class ContextMenuEventArgs : EventArgs
    {
        internal ShellContextMenu c2e6a1e6fa1b2666d36110f10f68b715f;

        internal ContextMenuEventArgs(ShellContextMenu c2e6a1e6fa1b2666d36110f10f68b715f)
        {
            this.c2e6a1e6fa1b2666d36110f10f68b715f = c2e6a1e6fa1b2666d36110f10f68b715f;
        }

        public ShellContextMenu Menu
        {
            get
            {
                return this.c2e6a1e6fa1b2666d36110f10f68b715f;
            }
        }
    }
}

