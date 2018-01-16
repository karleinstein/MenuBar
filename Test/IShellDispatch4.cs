namespace LogicNP.ShellObjects
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIDispatch), Guid("EFD84B2D-4BCF-4298-BE25-EB542A59FBDA")]
    internal interface IShellDispatch4
    {
        [DispId(0x60050000)]
        void WindowsSecurity();
        [DispId(0x60050001)]
        void ToggleDesktop();
    }
}

