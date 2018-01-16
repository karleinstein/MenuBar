namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public abstract class Trigger : ICloneable
    {
        private c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c0ff2a0f662370187990134afa39cf42c;
        internal c5745f9695e29862e1f6b961e309e42fe cba748dee196e4f177167aade012b422a;

        protected Trigger()
        {
            this.c0ff2a0f662370187990134afa39cf42c = null;
            this.cba748dee196e4f177167aade012b422a = new c5745f9695e29862e1f6b961e309e42fe();
            this.cba748dee196e4f177167aade012b422a.c7cae55aac99338b664dc26b67533bccc = (ushort) Marshal.SizeOf(this.cba748dee196e4f177167aade012b422a);
            DateTime now = DateTime.Now;
            this.StartDateTime = this.EndDate = now;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.cb933a97bc3f37c1e9257005787b1254c;
        }

        internal Trigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11)
        {
            if (c1bcefd2d36acffb74e08c24b8a30ee11 != null)
            {
                this.cba748dee196e4f177167aade012b422a = new c5745f9695e29862e1f6b961e309e42fe();
                int num2 = Marshal.SizeOf(this.cba748dee196e4f177167aade012b422a);
                this.cba748dee196e4f177167aade012b422a.c7cae55aac99338b664dc26b67533bccc = (ushort) num2;
                c1bcefd2d36acffb74e08c24b8a30ee11.cc183ac3fb0fb187e8886fd5ac15c580d(ref this.cba748dee196e4f177167aade012b422a);
                this.c0ff2a0f662370187990134afa39cf42c = c1bcefd2d36acffb74e08c24b8a30ee11;
                return;
            }
        Label_0009:
            switch (4)
            {
                case 0:
                    goto Label_0009;
            }
            if (1 == 0)
            {
            }
            throw new ArgumentNullException();
        }

        internal void c2ffcc2be8cbb4559d8fa35d2c9369a60(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c0ff2a0f662370187990134afa39cf42c)
        {
            if (this.c0ff2a0f662370187990134afa39cf42c == null)
            {
                this.c0ff2a0f662370187990134afa39cf42c = c0ff2a0f662370187990134afa39cf42c;
                c0ff2a0f662370187990134afa39cf42c.c34d4567f7882cfdb36c6d4b6df6191f1(ref this.cba748dee196e4f177167aade012b422a);
                return;
            }
        Label_0008:
            switch (5)
            {
                case 0:
                    goto Label_0008;
            }
            if (1 == 0)
            {
            }
            throw new ArgumentException();
        }

        internal void c2ffcc2be8cbb4559d8fa35d2c9369a60(Trigger c932bbfa3eeb1970e71e1ba84bf6cef4b)
        {
            this.c2ffcc2be8cbb4559d8fa35d2c9369a60(c932bbfa3eeb1970e71e1ba84bf6cef4b.c0ff2a0f662370187990134afa39cf42c);
        }

        internal static Trigger c7bfc2b235ca5eb1d25d87201e49cdf93(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c0ff2a0f662370187990134afa39cf42c)
        {
            if (c0ff2a0f662370187990134afa39cf42c != null)
            {
                c5745f9695e29862e1f6b961e309e42fe structure = new c5745f9695e29862e1f6b961e309e42fe();
                int num2 = Marshal.SizeOf(structure);
                structure.c7cae55aac99338b664dc26b67533bccc = (ushort) num2;
                c0ff2a0f662370187990134afa39cf42c.cc183ac3fb0fb187e8886fd5ac15c580d(ref structure);
                switch (structure.cf3cec8364bf7ea51b06e8476162c16d7)
                {
                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.cb933a97bc3f37c1e9257005787b1254c:
                        return new RunOnceTrigger(c0ff2a0f662370187990134afa39cf42c);

                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.c6768ce598d45e6bd7399e7feb4df956b:
                        return new DailyTrigger(c0ff2a0f662370187990134afa39cf42c);

                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.c0cf8ce89482fda8ab32791c0eadd4651:
                        return new WeeklyTrigger(c0ff2a0f662370187990134afa39cf42c);

                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.cc8dc1ad5aca13ac798a18b60bcba9498:
                        return new MonthlyTrigger(c0ff2a0f662370187990134afa39cf42c);

                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.c8d8c03d81a683fd54234aa6954b02fa5:
                        return new MonthlyDOWTrigger(c0ff2a0f662370187990134afa39cf42c);

                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.ca9fb191126580331b4599f7f9764b9a4:
                    {
                        EventTrigger trigger = new EventTrigger(c0ff2a0f662370187990134afa39cf42c);
                        trigger.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.ca9fb191126580331b4599f7f9764b9a4;
                        return trigger;
                    }
                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.caacaae46dd9f8bc5b87b7aed5f5da42b:
                    {
                        EventTrigger trigger2 = new EventTrigger(c0ff2a0f662370187990134afa39cf42c);
                        trigger2.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.caacaae46dd9f8bc5b87b7aed5f5da42b;
                        return trigger2;
                    }
                    case c99aa0190a0afbe3a7dc4401dbf13a6b5.c8c5cdd5499e2f211df0f6a19182c2671:
                    {
                        EventTrigger trigger3 = new EventTrigger(c0ff2a0f662370187990134afa39cf42c);
                        trigger3.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.c8c5cdd5499e2f211df0f6a19182c2671;
                        return trigger3;
                    }
                }
                throw new ArgumentException();
            }
        Label_0003:
            switch (4)
            {
                case 0:
                    goto Label_0003;
            }
            if (1 == 0)
            {
            }
            throw new ArgumentNullException();
        }

        internal void cc7545322bad566fb28feaca58d69b33f()
        {
            if (this.c0ff2a0f662370187990134afa39cf42c != null)
            {
                this.c0ff2a0f662370187990134afa39cf42c.c34d4567f7882cfdb36c6d4b6df6191f1(ref this.cba748dee196e4f177167aade012b422a);
            }
        }

        internal void cfab69a397aedbc93489a509309b87405()
        {
            if (this.c0ff2a0f662370187990134afa39cf42c == null)
            {
                return;
            }
        Label_0008:
            switch (5)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    Marshal.ReleaseComObject(this.c0ff2a0f662370187990134afa39cf42c);
                    this.c0ff2a0f662370187990134afa39cf42c = null;
                    break;
            }
        }

        public object Clone()
        {
            object obj1 = base.MemberwiseClone();
            Trigger trigger = (Trigger) obj1;
            trigger.c0ff2a0f662370187990134afa39cf42c = null;
            return trigger;
        }

        internal bool c9518ed52a114e714e16c06ffdde12706
        {
            get
            {
                return (this.c0ff2a0f662370187990134afa39cf42c != null);
            }
        }

        public DateTime EndDate
        {
            get
            {
                if (!this.IsEndDateValid)
                {
                    return DateTime.Now;
                }
            Label_000A:
                switch (5)
                {
                    case 0:
                        goto Label_000A;
                }
                if (1 == 0)
                {
                }
                return new DateTime(this.cba748dee196e4f177167aade012b422a.c7bc56a336078b99623f0f47cc109f250, this.cba748dee196e4f177167aade012b422a.c041ec44c11e55b844b5682bad4db75cb, this.cba748dee196e4f177167aade012b422a.c5977596d2cd9a837278eb6dba4b97321);
            }
            set
            {
                int year = value.Year;
                this.cba748dee196e4f177167aade012b422a.c7bc56a336078b99623f0f47cc109f250 = (ushort) year;
                int month = value.Month;
                this.cba748dee196e4f177167aade012b422a.c041ec44c11e55b844b5682bad4db75cb = (ushort) month;
                int day = value.Day;
                this.cba748dee196e4f177167aade012b422a.c5977596d2cd9a837278eb6dba4b97321 = (ushort) day;
                this.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        public bool IsEndDateValid
        {
            get
            {
                return ((this.cba748dee196e4f177167aade012b422a.c35d2c68395a8575aab425760b38325e7 & 1) != 0);
            }
            set
            {
                if (value)
                {
                    this.cba748dee196e4f177167aade012b422a.c35d2c68395a8575aab425760b38325e7 |= 1;
                }
                else
                {
                    this.cba748dee196e4f177167aade012b422a.c35d2c68395a8575aab425760b38325e7 &= 0xfffffffe;
                }
                this.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        public DateTime StartDateTime
        {
            get
            {
                return new DateTime(this.cba748dee196e4f177167aade012b422a.c482aca2b316b12bd0a9fc537eaf69af0, this.cba748dee196e4f177167aade012b422a.c2d88cd0b4693e8954f11a57a01a94896, this.cba748dee196e4f177167aade012b422a.c9cd9d83b82340d1ec3c8655fd7e90f7d, this.cba748dee196e4f177167aade012b422a.c1fea074241e881b56b013c15cb06a588, this.cba748dee196e4f177167aade012b422a.cff322cc1a937e1f89ecf65530d1505a7, 0);
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.c482aca2b316b12bd0a9fc537eaf69af0 = (ushort) value.Year;
                int month = value.Month;
                this.cba748dee196e4f177167aade012b422a.c2d88cd0b4693e8954f11a57a01a94896 = (ushort) month;
                int day = value.Day;
                this.cba748dee196e4f177167aade012b422a.c9cd9d83b82340d1ec3c8655fd7e90f7d = (ushort) day;
                int hour = value.Hour;
                this.cba748dee196e4f177167aade012b422a.c1fea074241e881b56b013c15cb06a588 = (ushort) hour;
                int minute = value.Minute;
                this.cba748dee196e4f177167aade012b422a.cff322cc1a937e1f89ecf65530d1505a7 = (ushort) minute;
                this.cc7545322bad566fb28feaca58d69b33f();
            }
        }

        [Browsable(false)]
        public TriggerType Type
        {
            get
            {
                return (TriggerType) this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7;
            }
        }
    }
}

