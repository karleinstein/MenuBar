namespace LogicNP.ShellObjects
{
    using System;

    public class ContextMenuItemEventArgs : EventArgs
    {
        internal string c179b6b5756a86e7e82610ea64887e1f0;
        internal int cfc56349b18f430cf61d5985b21a5a888;

        internal ContextMenuItemEventArgs(string c179b6b5756a86e7e82610ea64887e1f0, int cfc56349b18f430cf61d5985b21a5a888)
        {
            this.c179b6b5756a86e7e82610ea64887e1f0 = c179b6b5756a86e7e82610ea64887e1f0;
            this.cfc56349b18f430cf61d5985b21a5a888 = cfc56349b18f430cf61d5985b21a5a888;
        }

        public int CommandID
        {
            get
            {
                return this.cfc56349b18f430cf61d5985b21a5a888;
            }
        }

        public string CommandText
        {
            get
            {
                return this.c179b6b5756a86e7e82610ea64887e1f0;
            }
        }
    }
}

