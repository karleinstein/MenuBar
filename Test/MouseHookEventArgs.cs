namespace LogicNP.ShellObjects
{
    using System;
    using System.Windows.Forms;

    public class MouseHookEventArgs : MouseEventArgs
    {
        internal bool c5d704182c529871e2baa5c2bec711612;

        public MouseHookEventArgs(MouseButtons buttons, int clicks, int x, int y, int delta) : base(buttons, clicks, x, y, delta)
        {
        }

        public bool Handled
        {
            get
            {
                return this.c5d704182c529871e2baa5c2bec711612;
            }
            set
            {
                this.c5d704182c529871e2baa5c2bec711612 = value;
            }
        }
    }
}

