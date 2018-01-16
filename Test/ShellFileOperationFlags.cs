namespace LogicNP.ShellObjects
{
    using System;

    [Flags]
    public enum ShellFileOperationFlags
    {
        AllowUndo = 0x40,
        DeleteConfirmation = 0x4000,
        FilesOnly = 0x80,
        NoConfirmation = 0x10,
        NoCopySecurityAttributes = 0x800,
        NoErrorUI = 0x400,
        NoMakeDirConfirmation = 0x200,
        None = 0,
        NoProgressDialog = 4,
        NoRecursion = 0x1000,
        RenameOnCollision = 8,
        SimpleProgressDialog = 0x100
    }
}

