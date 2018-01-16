namespace LogicNP.ShellObjects
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class WizardPaintButtonEventArgs : WizardPaintEventArgs
    {
        internal System.Windows.Forms.Button cb1bdb9e84aeddfa63c4512541e8a56e2;

        public WizardPaintButtonEventArgs(Graphics g, Rectangle rc, Wizard wizard, WizardPage page, System.Windows.Forms.Button button) : base(g, rc, wizard, page)
        {
            this.cb1bdb9e84aeddfa63c4512541e8a56e2 = button;
        }

        public System.Windows.Forms.Button Button
        {
            get
            {
                return this.cb1bdb9e84aeddfa63c4512541e8a56e2;
            }
        }
    }
}

