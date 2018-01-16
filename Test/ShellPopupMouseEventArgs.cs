namespace LogicNP.ShellObjects
{
    using System;

    public class ShellPopupMouseEventArgs : ShellPopupEventArgs
    {
        private int c2cc94d04c55dd96868ec2a6623a249ca;
        private int c7bb708bfe3cb37fa1ebbdbace03ad3c4;
        private MouseKeyStates c88215f6b05804e8ffef9acb403d42f75;

        internal ShellPopupMouseEventArgs(ShellPopup c5dd3655f701702e8bd024f9e7a4dd4ba, MouseKeyStates c88215f6b05804e8ffef9acb403d42f75, int c7bb708bfe3cb37fa1ebbdbace03ad3c4, int c2cc94d04c55dd96868ec2a6623a249ca) : base(c5dd3655f701702e8bd024f9e7a4dd4ba)
        {
            this.c88215f6b05804e8ffef9acb403d42f75 = c88215f6b05804e8ffef9acb403d42f75;
            this.c7bb708bfe3cb37fa1ebbdbace03ad3c4 = c7bb708bfe3cb37fa1ebbdbace03ad3c4;
            this.c2cc94d04c55dd96868ec2a6623a249ca = c2cc94d04c55dd96868ec2a6623a249ca;
        }

        public MouseKeyStates MouseKeyState
        {
            get
            {
                return this.c88215f6b05804e8ffef9acb403d42f75;
            }
        }

        public int X
        {
            get
            {
                return this.c7bb708bfe3cb37fa1ebbdbace03ad3c4;
            }
        }

        public int Y
        {
            get
            {
                return this.c2cc94d04c55dd96868ec2a6623a249ca;
            }
        }
    }
}

