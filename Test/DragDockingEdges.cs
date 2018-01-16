namespace LogicNP.ShellObjects
{
    using System;
    using System.ComponentModel;

    [Flags, Description("Specifies ShellAppBar Drag-Docking Edge")]
    public enum DragDockingEdges
    {
        All = 0x1f,
        Bottom = 0x10,
        Left = 2,
        None = 0,
        Right = 4,
        Top = 8,
        UnDocked = 1
    }
}

