namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing.Design;

    public class MonthlyDOWTrigger : Trigger
    {
        public MonthlyDOWTrigger()
        {
            DateTime now = DateTime.Now;
            base.StartDateTime = now;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.c8d8c03d81a683fd54234aa6954b02fa5;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c97ce9a6d0ad242ff47571b77c8053e4b = 1;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c296005083590d59afe783c6e633aec0b = 2;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c46708d12f42703fa0b8a0fb7a9beee9a = 0xfff;
        }

        internal MonthlyDOWTrigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11) : base(c1bcefd2d36acffb74e08c24b8a30ee11)
        {
        }

        public MonthlyDOWTrigger(DateTime runDateTime, LogicNP.ShellObjects.DaysOfTheWeek daysOfTheWeek, LogicNP.ShellObjects.WeeksOfTheMonth whichWeeks) : this(runDateTime, daysOfTheWeek, whichWeeks, LogicNP.ShellObjects.MonthsOfTheYear.All)
        {
        }

        public MonthlyDOWTrigger(DateTime runDateTime, LogicNP.ShellObjects.DaysOfTheWeek daysOfTheWeek, LogicNP.ShellObjects.WeeksOfTheMonth whichWeeks, LogicNP.ShellObjects.MonthsOfTheYear months)
        {
            base.StartDateTime = runDateTime;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.c8d8c03d81a683fd54234aa6954b02fa5;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c97ce9a6d0ad242ff47571b77c8053e4b = (ushort) whichWeeks;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c296005083590d59afe783c6e633aec0b = (ushort) daysOfTheWeek;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c46708d12f42703fa0b8a0fb7a9beee9a = (ushort) months;
        }

        public LogicNP.ShellObjects.DaysOfTheWeek DaysOfTheWeek
        {
            get
            {
                return (LogicNP.ShellObjects.DaysOfTheWeek) ((short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c296005083590d59afe783c6e633aec0b);
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c296005083590d59afe783c6e633aec0b = (ushort) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        [Editor(typeof(c826e1947054dc132ce73d91387ff2197), typeof(UITypeEditor))]
        public LogicNP.ShellObjects.MonthsOfTheYear MonthsOfTheYear
        {
            get
            {
                return (LogicNP.ShellObjects.MonthsOfTheYear) ((short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c46708d12f42703fa0b8a0fb7a9beee9a);
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c46708d12f42703fa0b8a0fb7a9beee9a = (ushort) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        public LogicNP.ShellObjects.WeeksOfTheMonth WeeksOfTheMonth
        {
            get
            {
                return (LogicNP.ShellObjects.WeeksOfTheMonth) ((short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c97ce9a6d0ad242ff47571b77c8053e4b);
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c586a086fac60b2f90a9444f979f31fcf.c97ce9a6d0ad242ff47571b77c8053e4b = (ushort) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }
    }
}

