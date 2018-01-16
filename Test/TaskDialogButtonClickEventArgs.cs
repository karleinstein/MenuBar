namespace LogicNP.ShellObjects
{
    using System;
    using System.ComponentModel;

    public class TaskDialogButtonClickEventArgs : CancelEventArgs
    {
        internal int cb47cfda78b3f4baab6078f07f91881f4;

        internal TaskDialogButtonClickEventArgs(int cdd9eb708913623fb0bc1135bde3eb59d)
        {
            base.Cancel = false;
            this.cb47cfda78b3f4baab6078f07f91881f4 = cdd9eb708913623fb0bc1135bde3eb59d;
        }

        public int ButtonID
        {
            get
            {
                return this.cb47cfda78b3f4baab6078f07f91881f4;
            }
        }
    }
}

