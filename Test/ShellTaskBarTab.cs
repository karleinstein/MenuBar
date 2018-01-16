namespace LogicNP.ShellObjects
{
    using System;

    public class ShellTaskBarTab
    {
        private IntPtr c295ab4cbbdfaa63825dfad9931c46900;
        private string cd36b95361dd7401129e269b07102bff1;

        internal ShellTaskBarTab(string cd36b95361dd7401129e269b07102bff1, IntPtr c295ab4cbbdfaa63825dfad9931c46900)
        {
            this.cd36b95361dd7401129e269b07102bff1 = cd36b95361dd7401129e269b07102bff1;
            this.c295ab4cbbdfaa63825dfad9931c46900 = c295ab4cbbdfaa63825dfad9931c46900;
        }

        public override string ToString()
        {
            return this.cd36b95361dd7401129e269b07102bff1;
        }

        public string WindowCaption
        {
            get
            {
                return this.cd36b95361dd7401129e269b07102bff1;
            }
        }

        public IntPtr WindowHandle
        {
            get
            {
                return this.c295ab4cbbdfaa63825dfad9931c46900;
            }
        }
    }
}

