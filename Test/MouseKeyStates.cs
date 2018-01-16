namespace LogicNP.ShellObjects
{
    using System;

    [Flags]
    public enum MouseKeyStates
    {
        ControlKey = 8,
        LeftButton = 1,
        MiddleButton = 0x10,
        RightButton = 2,
        ShiftKey = 4,
        XButton1 = 0x20,
        XButton2 = 0x40
    }
}

