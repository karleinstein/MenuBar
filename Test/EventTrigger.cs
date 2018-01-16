namespace LogicNP.ShellObjects
{
    using A;
    using System;

    public class EventTrigger : Trigger
    {
        public EventTrigger()
        {
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.ca9fb191126580331b4599f7f9764b9a4;
        }

        internal EventTrigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11) : base(c1bcefd2d36acffb74e08c24b8a30ee11)
        {
        }

        public EventTrigger(LogicNP.ShellObjects.EventType eventType)
        {
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = (c99aa0190a0afbe3a7dc4401dbf13a6b5) eventType;
        }

        public LogicNP.ShellObjects.EventType EventType
        {
            get
            {
                return (LogicNP.ShellObjects.EventType) this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7;
            }
            set
            {
                this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = (c99aa0190a0afbe3a7dc4401dbf13a6b5) value;
                base.cc7545322bad566fb28feaca58d69b33f();
            }
        }
    }
}

