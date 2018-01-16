namespace LogicNP.ShellObjects
{
    using System;

    [Flags]
    public enum TaskDialogCommonButtons
    {
        Cancel = 8,
        Close = 0x20,
        No = 4,
        None = 0,
        OK = 1,
        Retry = 0x10,
        Yes = 2
    }
}

