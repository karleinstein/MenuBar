namespace LogicNP.ShellObjects
{
    using System;

    public class NewInstanceEventArgs : EventArgs
    {
        private bool c762f6491373049176a2a0c48de84030e;
        private object cf19320623a0274ff9a12894a1f0da097;

        internal NewInstanceEventArgs(bool ce43095dd842caf8a3b0db560ca7f6ba7, object cf19320623a0274ff9a12894a1f0da097)
        {
            this.c762f6491373049176a2a0c48de84030e = ce43095dd842caf8a3b0db560ca7f6ba7;
            this.cf19320623a0274ff9a12894a1f0da097 = cf19320623a0274ff9a12894a1f0da097;
        }

        public bool AllowInstance
        {
            get
            {
                return this.c762f6491373049176a2a0c48de84030e;
            }
            set
            {
                this.c762f6491373049176a2a0c48de84030e = value;
            }
        }

        public object Data
        {
            get
            {
                return this.cf19320623a0274ff9a12894a1f0da097;
            }
        }
    }
}

