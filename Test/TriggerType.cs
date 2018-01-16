namespace LogicNP.ShellObjects
{
    using System;

    public enum TriggerType
    {
        RunOnce,
        RunDaily,
        RunWeekly,
        RunMonthly,
        RunMonthlyDOW,
        OnIdle,
        OnSystemStart,
        OnLogon
    }
}

