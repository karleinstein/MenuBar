namespace LogicNP.ShellObjects
{
    using System;
    using System.Drawing;

    public class WizardPaintEventArgs
    {
        internal LogicNP.ShellObjects.Wizard c1ddc887212aafbd9ba7cb9b75b60e84e;
        internal Rectangle ca21346516471988ee8fa7ff8548da071;
        internal System.Drawing.Graphics cc262ed73696b24e71814781d615231cb;
        internal LogicNP.ShellObjects.WizardPage cde2fc6055d4875d40064c0c1dcd886b3;

        public WizardPaintEventArgs(System.Drawing.Graphics g, Rectangle rc, LogicNP.ShellObjects.Wizard wizard, LogicNP.ShellObjects.WizardPage page)
        {
            this.cc262ed73696b24e71814781d615231cb = g;
            this.ca21346516471988ee8fa7ff8548da071 = rc;
            this.c1ddc887212aafbd9ba7cb9b75b60e84e = wizard;
            this.cde2fc6055d4875d40064c0c1dcd886b3 = page;
        }

        public Rectangle Bounds
        {
            get
            {
                return this.ca21346516471988ee8fa7ff8548da071;
            }
        }

        public System.Drawing.Graphics Graphics
        {
            get
            {
                return this.cc262ed73696b24e71814781d615231cb;
            }
        }

        public LogicNP.ShellObjects.Wizard Wizard
        {
            get
            {
                return this.c1ddc887212aafbd9ba7cb9b75b60e84e;
            }
        }

        public LogicNP.ShellObjects.WizardPage WizardPage
        {
            get
            {
                return this.cde2fc6055d4875d40064c0c1dcd886b3;
            }
        }
    }
}

