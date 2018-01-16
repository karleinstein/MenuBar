namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing.Design;

    public class MonthlyTrigger : Trigger
    {
        public MonthlyTrigger()
        {
            base.StartDateTime = DateTime.Now;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.cc8dc1ad5aca13ac798a18b60bcba9498;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c46708d12f42703fa0b8a0fb7a9beee9a = 0xfff;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c803937eb4705cd546e6c9229d44cf56a = 1;
        }

        internal MonthlyTrigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11) : base(c1bcefd2d36acffb74e08c24b8a30ee11)
        {
        }

        public MonthlyTrigger(DateTime runDateTime, int daysOfMonth) : this(runDateTime, daysOfMonth, LogicNP.ShellObjects.MonthsOfTheYear.All)
        {
        }

        public MonthlyTrigger(DateTime runDateTime, int daysOfMonth, LogicNP.ShellObjects.MonthsOfTheYear months)
        {
            base.StartDateTime = runDateTime;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.cc8dc1ad5aca13ac798a18b60bcba9498;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c46708d12f42703fa0b8a0fb7a9beee9a = (ushort) months;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c803937eb4705cd546e6c9229d44cf56a = (uint) daysOfMonth;
        }

        public LogicNP.ShellObjects.DaysOfTheMonth DaysOfTheMonth
        {
            get
            {
                return (LogicNP.ShellObjects.DaysOfTheMonth) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c803937eb4705cd546e6c9229d44cf56a;
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c803937eb4705cd546e6c9229d44cf56a = (uint) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        [Editor(typeof(c826e1947054dc132ce73d91387ff2197), typeof(UITypeEditor))]
        public LogicNP.ShellObjects.MonthsOfTheYear MonthsOfTheYear
        {
            get
            {
                return (LogicNP.ShellObjects.MonthsOfTheYear) ((short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c46708d12f42703fa0b8a0fb7a9beee9a);
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c81ff2f59d9be99bda392ebfb7c6da644.c46708d12f42703fa0b8a0fb7a9beee9a = (ushort) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }
    }
}

