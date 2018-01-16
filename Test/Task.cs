namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing.Design;
    using System.IO;
    using System.Runtime.InteropServices;

    public class Task : IDisposable
    {
        internal static TimeSpan c1a2b4c701a9cb194edee0c36fb8a595b = new TimeSpan(0x3e7fffffc18L);
        private ce00c0c0cf6fda959b5e473451484f374 c314ce52ce2ae293d8113116cadfd940f;
        private string c4a11be50ecee7466636e5d549577c703;
        private TriggerList cc775fd5739c78ff65258165b7d0d4fd2;

        internal Task(ce00c0c0cf6fda959b5e473451484f374 c314ce52ce2ae293d8113116cadfd940f, string cbde085e547fa33ff007e97c323718d3f)
        {
            this.c314ce52ce2ae293d8113116cadfd940f = c314ce52ce2ae293d8113116cadfd940f;
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(290);
            if (cbde085e547fa33ff007e97c323718d3f.EndsWith(text1))
            {
                string text2 = cbde085e547fa33ff007e97c323718d3f.Substring(0, cbde085e547fa33ff007e97c323718d3f.Length - 4);
                this.c4a11be50ecee7466636e5d549577c703 = text2;
            }
            else
            {
                this.c4a11be50ecee7466636e5d549577c703 = cbde085e547fa33ff007e97c323718d3f;
            }
            this.cc775fd5739c78ff65258165b7d0d4fd2 = null;
            bool flag2 = this.cbbfc4243186a03ded17cbb953311cc39();
            this.c36c229b4ef46f571340bd843fe2fce5c = flag2;
        }

        private void c894060faa8045c33eabd114fa7aeda46(bool c1422c2d80375123f514855d01bc243c0)
        {
            string str;
            ((UCOMIPersistFile) this.c314ce52ce2ae293d8113116cadfd940f).GetCurFile(out str);
            FileAttributes fileAttributes = File.GetAttributes(str);
            if (!c1422c2d80375123f514855d01bc243c0)
            {
                fileAttributes &= ~FileAttributes.Hidden;
                goto Label_003C;
            }
        Label_001E:
            switch (6)
            {
                case 0:
                    goto Label_001E;

                default:
                    if (1 == 0)
                    {
                    }
                    fileAttributes |= FileAttributes.Hidden;
                    break;
            }
        Label_003C:
            File.SetAttributes(str, fileAttributes);
        }

        private bool cbbfc4243186a03ded17cbb953311cc39()
        {
            string str;
            ((UCOMIPersistFile) this.c314ce52ce2ae293d8113116cadfd940f).GetCurFile(out str);
            try
            {
                FileAttributes attributes = File.GetAttributes(str);
                return ((attributes & FileAttributes.Hidden) != 0);
            }
            catch
            {
                return false;
            }
        }

        public void Close()
        {
            if (this.cc775fd5739c78ff65258165b7d0d4fd2 == null)
            {
                goto Label_0026;
            }
        Label_0008:
            switch (3)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.cc775fd5739c78ff65258165b7d0d4fd2.Dispose();
                    break;
            }
        Label_0026:
            this.Save();
            Marshal.ReleaseComObject(this.c314ce52ce2ae293d8113116cadfd940f);
            this.c314ce52ce2ae293d8113116cadfd940f = null;
        }

        public void DisplayPropertiesUI()
        {
            this.c314ce52ce2ae293d8113116cadfd940f.c0477b1a22f3e9113cac51ee6bf85070c(0, 0);
        }

        public void Dispose()
        {
            this.Close();
        }

        public string GetAccountInformation()
        {
            IntPtr zero = IntPtr.Zero;
            int num1 = this.c314ce52ce2ae293d8113116cadfd940f.c321f205e701493f24f218328f62201d8(out zero);
            return c913c9607bcd1849f59ca854dff6b6d8c.c60fb8f4634ed89c671494e4e4e404f28(zero);
        }

        public void Run()
        {
            this.c314ce52ce2ae293d8113116cadfd940f.c773018b95be1f5baa2b5f2bd7fb23f6f();
        }

        public void Save()
        {
            ((UCOMIPersistFile) this.c314ce52ce2ae293d8113116cadfd940f).Save(null, false);
            bool flag1 = this.c36c229b4ef46f571340bd843fe2fce5c;
            this.c894060faa8045c33eabd114fa7aeda46(flag1);
        }

        public void SetAccountInformation(string accountName, string password)
        {
            int num1 = this.c314ce52ce2ae293d8113116cadfd940f.c11e5a67be9c2c4ee61609c2e007be18d(accountName, password);
            this.Save();
        }

        public void Terminate()
        {
            this.c314ce52ce2ae293d8113116cadfd940f.c9815b182f3e4b060309fb8827ef8aa7e();
        }

        public override string ToString()
        {
            return this.c4a11be50ecee7466636e5d549577c703;
        }

        [Editor("LogicNP.ShellObjects.Design.TaskSchedulerAccntInfoDlgEditor, LogicNP.ShellObjects.Design", typeof(UITypeEditor))]
        public string ApplicationName
        {
            get
            {
                IntPtr ptr;
                this.c314ce52ce2ae293d8113116cadfd940f.c2c0173581f608704b1b909ae8872d037(out ptr);
                return c913c9607bcd1849f59ca854dff6b6d8c.c60fb8f4634ed89c671494e4e4e404f28(ptr);
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.cbfca0a6a1f128857bccc6fbb39ebaf51(value);
            }
        }

        internal bool c36c229b4ef46f571340bd843fe2fce5c
        {
            get
            {
                TaskFlags flags = this.Flags;
                return ((flags & TaskFlags.Hidden) != 0);
            }
            set
            {
                if (value)
                {
                    this.Flags |= TaskFlags.Hidden;
                }
                else
                {
                    TaskFlags flags = this.Flags;
                    this.Flags = flags & ~TaskFlags.Hidden;
                }
            }
        }

        public string Comment
        {
            get
            {
                IntPtr ptr;
                this.c314ce52ce2ae293d8113116cadfd940f.ce42eebcc258d4bae01886779b44164b7(out ptr);
                return c913c9607bcd1849f59ca854dff6b6d8c.c60fb8f4634ed89c671494e4e4e404f28(ptr);
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.cc2a4e28abcc4cef1e228183a496069f0(value);
            }
        }

        public string Creator
        {
            get
            {
                IntPtr ptr;
                this.c314ce52ce2ae293d8113116cadfd940f.c7875c3f54fce2ec972ec4cdd4d61de52(out ptr);
                return c913c9607bcd1849f59ca854dff6b6d8c.c60fb8f4634ed89c671494e4e4e404f28(ptr);
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.cd68fda9e8bfea49e1911b1506a936b24(value);
            }
        }

        public int ExitCode
        {
            get
            {
                uint num = 0;
                this.c314ce52ce2ae293d8113116cadfd940f.c3b3278c8588352d2b4ffd9746dcdf0ed(out num);
                return (int) num;
            }
        }

        [Editor(typeof(c826e1947054dc132ce73d91387ff2197), typeof(UITypeEditor))]
        public TaskFlags Flags
        {
            get
            {
                uint num;
                this.c314ce52ce2ae293d8113116cadfd940f.c3e8f084b71bd85209ea32022eeb5afc7(out num);
                return (TaskFlags) num;
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.c2bd445afdd7c6377cd0e4374b0bb4445((uint) value);
            }
        }

        public short IdleWaitDeadlineMinutes
        {
            get
            {
                ushort num;
                ushort num2;
                this.c314ce52ce2ae293d8113116cadfd940f.cf5d2814626a53f56714c94219d04c92e(out num2, out num);
                return (short) num;
            }
            set
            {
                short idleWaitMinutes = this.IdleWaitMinutes;
                ushort num = (ushort) idleWaitMinutes;
                this.c314ce52ce2ae293d8113116cadfd940f.c2768f2050e2c543321c9be3535029b12(num, (ushort) value);
            }
        }

        public short IdleWaitMinutes
        {
            get
            {
                ushort num;
                ushort num2;
                this.c314ce52ce2ae293d8113116cadfd940f.cf5d2814626a53f56714c94219d04c92e(out num, out num2);
                return (short) num;
            }
            set
            {
                short idleWaitDeadlineMinutes = this.IdleWaitDeadlineMinutes;
                ushort num = (ushort) idleWaitDeadlineMinutes;
                this.c314ce52ce2ae293d8113116cadfd940f.c2768f2050e2c543321c9be3535029b12((ushort) value, num);
            }
        }

        public static TimeSpan InfiniteRunTime
        {
            get
            {
                return c1a2b4c701a9cb194edee0c36fb8a595b;
            }
        }

        public TimeSpan MaxRunTime
        {
            get
            {
                uint num;
                this.c314ce52ce2ae293d8113116cadfd940f.cef1b8a9c8ee5ec6390fbc4628f8c44f5(out num);
                return new TimeSpan(num * 0x2710L);
            }
            set
            {
                double num = value.TotalMilliseconds;
                if (num < 4294967295)
                {
                    this.c314ce52ce2ae293d8113116cadfd940f.c65e5aae6200af0a41ff89499f7751bad((uint) num);
                    return;
                }
            Label_0016:
                switch (3)
                {
                    case 0:
                        goto Label_0016;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public DateTime MostRecentRunTime
        {
            get
            {
                cd3c15ce922e93808349174d82c714988 cdcceedc = new cd3c15ce922e93808349174d82c714988();
                int num2 = this.c314ce52ce2ae293d8113116cadfd940f.c081cb39bb98078e5c94b02c552b2e75b(ref cdcceedc);
                if (num2 != 0)
                {
                    return new DateTime(cdcceedc.c506ad0cecceccc13ee493a8c18d9828d, cdcceedc.cb3d784c869c67c600f65b810756cec46, cdcceedc.c6b7a686b99d95c3db608a83c6d875cc2, cdcceedc.cd4ce92ccd30bfa8a6785f49182ad43b3, cdcceedc.c2099fbb45100fd45650726354537a862, cdcceedc.c1da90a6d6319dd510be90e983ca31339, cdcceedc.c22a64a8ef5f0cdf425e3693777adc481);
                }
            Label_001B:
                switch (2)
                {
                    case 0:
                        goto Label_001B;
                }
                if (1 == 0)
                {
                }
                return DateTime.MinValue;
            }
        }

        public string Name
        {
            get
            {
                return this.c4a11be50ecee7466636e5d549577c703;
            }
        }

        public DateTime NextRunTime
        {
            get
            {
                cd3c15ce922e93808349174d82c714988 cdcceedc = new cd3c15ce922e93808349174d82c714988();
                int num1 = this.c314ce52ce2ae293d8113116cadfd940f.c9617861ca46ba60a0f93aac26ed6e6a1(ref cdcceedc);
                if (num1 == 0)
                {
                    return DateTime.MinValue;
                }
                return new DateTime(cdcceedc.c506ad0cecceccc13ee493a8c18d9828d, cdcceedc.cb3d784c869c67c600f65b810756cec46, cdcceedc.c6b7a686b99d95c3db608a83c6d875cc2, cdcceedc.cd4ce92ccd30bfa8a6785f49182ad43b3, cdcceedc.c2099fbb45100fd45650726354537a862, cdcceedc.c1da90a6d6319dd510be90e983ca31339, cdcceedc.c22a64a8ef5f0cdf425e3693777adc481);
            }
        }

        public string Parameters
        {
            get
            {
                IntPtr ptr;
                this.c314ce52ce2ae293d8113116cadfd940f.c17ea3882a255fc78dc12dd5891081954(out ptr);
                return c913c9607bcd1849f59ca854dff6b6d8c.c60fb8f4634ed89c671494e4e4e404f28(ptr);
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.c028984b70c9fffa555e37db8b626b12d(value);
            }
        }

        public PriorityLevel Priority
        {
            get
            {
                uint num;
                this.c314ce52ce2ae293d8113116cadfd940f.c65547a40e1c5c74081b412c6ca17de91(out num);
                return (PriorityLevel) num;
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.c460c1f6f7a2bddc9b66a0c0a50dacc55((uint) value);
            }
        }

        public TaskStatus Status
        {
            get
            {
                int num;
                this.c314ce52ce2ae293d8113116cadfd940f.c2f1213e21f08797ef231010aec3fea17(out num);
                return (TaskStatus) num;
            }
        }

        [Editor("LogicNP.ShellObjects.Design.TriggerCollectionEditor, LogicNP.ShellObjects.Design", typeof(UITypeEditor))]
        public TriggerList Triggers
        {
            get
            {
                if (this.cc775fd5739c78ff65258165b7d0d4fd2 != null)
                {
                    goto Label_002C;
                }
            Label_0008:
                switch (6)
                {
                    case 0:
                        goto Label_0008;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.cc775fd5739c78ff65258165b7d0d4fd2 = new TriggerList(this.c314ce52ce2ae293d8113116cadfd940f);
                        break;
                }
            Label_002C:
                return this.cc775fd5739c78ff65258165b7d0d4fd2;
            }
        }

        [Editor("LogicNP.ShellObjects.Design.TaskSchedulerWorkingDirectoryEditor, LogicNP.ShellObjects.Design", typeof(UITypeEditor))]
        public string WorkingDirectory
        {
            get
            {
                IntPtr ptr;
                this.c314ce52ce2ae293d8113116cadfd940f.cd7f65ef855d6346092c7e55c0a3106e7(out ptr);
                return c913c9607bcd1849f59ca854dff6b6d8c.c60fb8f4634ed89c671494e4e4e404f28(ptr);
            }
            set
            {
                this.c314ce52ce2ae293d8113116cadfd940f.c400af6d389c6a845c4034411e62a8349(value);
            }
        }
    }
}

