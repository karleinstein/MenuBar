namespace LogicNP.ShellObjects
{
    using System;

    public class ProgIDVerb
    {
        internal string c0569c59f707e04e3c17e4bd737202624;
        internal string c924a7adae948f7734a40ae82ec69a136;

        public ProgIDVerb(string caption, string command)
        {
            this.c924a7adae948f7734a40ae82ec69a136 = caption;
            this.c0569c59f707e04e3c17e4bd737202624 = command;
        }

        public string Caption
        {
            get
            {
                return this.c924a7adae948f7734a40ae82ec69a136;
            }
            set
            {
                this.c924a7adae948f7734a40ae82ec69a136 = value;
            }
        }

        public string Command
        {
            get
            {
                return this.c0569c59f707e04e3c17e4bd737202624;
            }
            set
            {
                this.c0569c59f707e04e3c17e4bd737202624 = value;
            }
        }
    }
}

