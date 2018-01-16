﻿namespace LogicNP.ShellObjects
{
    using System;

    [Flags]
    public enum KeyModifiers
    {
        Alt = 1,
        Control = 2,
        None = 0,
        Shift = 4,
        Win = 8
    }
}

