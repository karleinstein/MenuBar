namespace LogicNP.ShellObjects
{
    using System;
    using System.ComponentModel;

    [Description("Specifies ShellAppBar Docking Edge")]
    public enum DockingEdges
    {
        Bottom = 0x10,
        Left = 2,
        Right = 4,
        Top = 8,
        UnDocked = 1
    }
}

