namespace LogicNP.ShellObjects
{
    using A;
    using System;

    public class RunOnceTrigger : Trigger
    {
        public RunOnceTrigger()
        {
            DateTime now = DateTime.Now;
            base.StartDateTime = now;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.cb933a97bc3f37c1e9257005787b1254c;
        }

        internal RunOnceTrigger(c60ef56b1c0a7e1d5ec52b0d39d9d16b6 c1bcefd2d36acffb74e08c24b8a30ee11) : base(c1bcefd2d36acffb74e08c24b8a30ee11)
        {
        }

        public RunOnceTrigger(DateTime runDateTime)
        {
            base.StartDateTime = runDateTime;
            this.cba748dee196e4f177167aade012b422a.cf3cec8364bf7ea51b06e8476162c16d7 = c99aa0190a0afbe3a7dc4401dbf13a6b5.cb933a97bc3f37c1e9257005787b1254c;
        }
    }
}

