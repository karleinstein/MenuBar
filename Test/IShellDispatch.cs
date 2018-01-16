namespace LogicNP.ShellObjects
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("D8F015C0-C278-11CE-A49E-444553540000"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    internal interface IShellDispatch
    {
        [DispId(0x60020007)]
        void MinimizeAll();
        [DispId(0x60020008)]
        void UndoMinimizeAll();
        [DispId(0x60020009)]
        void FileRun();
        [DispId(0x6002000a)]
        void CascadeWindows();
        [DispId(0x6002000b)]
        void TileVertically();
        [DispId(0x6002000c)]
        void TileHorizontally();
        [DispId(0x6002000d)]
        void ShutdownWindows();
        [DispId(0x60020010)]
        void SetTime();
        [DispId(0x60020011)]
        void TrayProperties();
        [DispId(0x60020012)]
        void Help();
        [DispId(0x60020013)]
        void FindFiles();
        [DispId(0x60020014)]
        void FindComputer();
        [DispId(0x60020016)]
        void ControlPanelItem([MarshalAs(UnmanagedType.BStr)] string itemname);
    }
}

