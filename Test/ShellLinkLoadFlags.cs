namespace LogicNP.ShellObjects
{
    using System;

    [Flags]
    public enum ShellLinkLoadFlags
    {
        NoLinkInfo = 0x40,
        None = 0,
        NoSearch = 0x10,
        NoTracking = 0x20,
        NoUpdate = 8,
        NoUserInterface = 1
    }
}

