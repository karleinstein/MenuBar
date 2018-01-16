namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing.Design;

    public class WeeklyTrigger : Trigger
    {
        public WeeklyTrigger() : this(DateTime.Now, LogicNP.ShellObjects.DaysOfTheWeek.Monday, 1)
        {
        }

        internal WeeklyTrigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11) : base(c1bcefd2d36acffb74e08c24b8a30ee11)
        {
        }

        public WeeklyTrigger(DateTime runDateTime, LogicNP.ShellObjects.DaysOfTheWeek daysOfTheWeek) : this(runDateTime, daysOfTheWeek, 1)
        {
        }

        public WeeklyTrigger(DateTime runDateTime, LogicNP.ShellObjects.DaysOfTheWeek daysOfTheWeek, short weeksInterval)
        {
            base.StartDateTime = runDateTime;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.c0cf8ce89482fda8ab32791c0eadd4651;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c0dfeb9f60ae0e3bcf8353559de1d7860.cb4418ca10a16d2213df27fbc322d43e0 = (ushort) weeksInterval;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c0dfeb9f60ae0e3bcf8353559de1d7860.c296005083590d59afe783c6e633aec0b = (ushort) daysOfTheWeek;
        }

        [Editor(typeof(c826e1947054dc132ce73d91387ff2197), typeof(UITypeEditor))]
        public LogicNP.ShellObjects.DaysOfTheWeek DaysOfTheWeek
        {
            get
            {
                return (LogicNP.ShellObjects.DaysOfTheWeek) ((short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c0dfeb9f60ae0e3bcf8353559de1d7860.c296005083590d59afe783c6e633aec0b);
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c0dfeb9f60ae0e3bcf8353559de1d7860.c296005083590d59afe783c6e633aec0b = (ushort) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        public short WeeksInterval
        {
            get
            {
                return (short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c0dfeb9f60ae0e3bcf8353559de1d7860.cb4418ca10a16d2213df27fbc322d43e0;
            }
            set
            {
                if (value > 0)
                {
                    this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c0dfeb9f60ae0e3bcf8353559de1d7860.cb4418ca10a16d2213df27fbc322d43e0 = (ushort) value;
                    base.cc7545322bad566fb28feaca58d69b33f();
                    return;
                }
            Label_0004:
                switch (1)
                {
                    case 0:
                        goto Label_0004;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentException();
            }
        }
    }
}

