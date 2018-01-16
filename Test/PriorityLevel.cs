namespace LogicNP.ShellObjects
{
    using System;

    public enum PriorityLevel
    {
        High = 0x80,
        Idle = 0x40,
        Normal = 0x20,
        RealTime = 0x100
    }
}

