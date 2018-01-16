namespace LogicNP.ShellObjects
{
    using System;
    using System.ComponentModel;

    [Description("Specifies the border style of FolderView")]
    public enum Hotkey
    {
        Alt = 0x400,
        Control = 0x200,
        Ext = 0x800,
        KeyCodeMask = 0xff,
        None = 0,
        Shift = 0x100
    }
}

