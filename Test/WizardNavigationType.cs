namespace LogicNP.ShellObjects
{
    using System;

    [Flags]
    public enum WizardNavigationType
    {
        NavigateBack = 3,
        NavigateBackCode = 2,
        NavigateBackUI = 1,
        NavigateNext = 12,
        NavigateNextCode = 8,
        NavigateNextUI = 4,
        None = 0,
        Other = 0x10
    }
}

