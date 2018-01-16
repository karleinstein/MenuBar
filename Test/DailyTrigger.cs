namespace LogicNP.ShellObjects
{
    using A;
    using System;

    public class DailyTrigger : Trigger
    {
        public DailyTrigger()
        {
            DateTime now = DateTime.Now;
            base.StartDateTime = now;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.c6768ce598d45e6bd7399e7feb4df956b;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c7323e080551f2a009e13bd1140f501ec.cdeb77f6e24263a12a047ad347cd507f7 = 1;
        }

        internal DailyTrigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11) : base(c1bcefd2d36acffb74e08c24b8a30ee11)
        {
        }

        public DailyTrigger(DateTime runDateTime) : this(runDateTime, 1)
        {
        }

        public DailyTrigger(DateTime runDateTime, short daysInterval)
        {
            base.StartDateTime = runDateTime;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.c6768ce598d45e6bd7399e7feb4df956b;
            this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c7323e080551f2a009e13bd1140f501ec.cdeb77f6e24263a12a047ad347cd507f7 = (ushort) daysInterval;
        }

        public short DaysInterval
        {
            get
            {
                return (short) this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c7323e080551f2a009e13bd1140f501ec.cdeb77f6e24263a12a047ad347cd507f7;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.cba748dee196e4f177167aade012b422a.c3a1a14c33968c507c8c601c888b3aec9.c7323e080551f2a009e13bd1140f501ec.cdeb77f6e24263a12a047ad347cd507f7 = (ushort) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }
    }
}

