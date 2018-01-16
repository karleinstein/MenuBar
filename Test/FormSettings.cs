namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing.Design;

    [Flags, Editor(typeof(c826e1947054dc132ce73d91387ff2197), typeof(UITypeEditor))]
    public enum FormSettings
    {
        All = 7,
        None = 0,
        ResizeOnResolutionChange = 4,
        SavePosition = 1,
        SaveSize = 2
    }
}

