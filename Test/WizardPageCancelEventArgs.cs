namespace LogicNP.ShellObjects
{
    using System;
    using System.ComponentModel;

    public class WizardPageCancelEventArgs : CancelEventArgs
    {
        private WizardNavigationType cc3d086984168274ae58df188dfb393f8;
        private WizardPage cde2fc6055d4875d40064c0c1dcd886b3;

        public WizardPageCancelEventArgs(WizardPage page, WizardNavigationType reason) : base(false)
        {
            this.cde2fc6055d4875d40064c0c1dcd886b3 = page;
            this.cc3d086984168274ae58df188dfb393f8 = reason;
        }

        public WizardPage NewPage
        {
            get
            {
                return this.cde2fc6055d4875d40064c0c1dcd886b3;
            }
            set
            {
                this.cde2fc6055d4875d40064c0c1dcd886b3 = value;
            }
        }

        public WizardNavigationType Reason
        {
            get
            {
                return this.cc3d086984168274ae58df188dfb393f8;
            }
        }
    }
}

