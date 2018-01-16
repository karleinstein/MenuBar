namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Runtime.InteropServices;

    public class ShellContextMenu
    {
        internal IntPtr c09d4951f74fe0de317af591a1908f902;
        internal ShellContextMenu c8291914306caaadc5c40096e0137389f;
        internal unsafe int* c86662039014790ce2273d0930c5bdad3;

        internal unsafe ShellContextMenu(IntPtr c09d4951f74fe0de317af591a1908f902, ShellContextMenu c8291914306caaadc5c40096e0137389f)
        {
            this.c09d4951f74fe0de317af591a1908f902 = c09d4951f74fe0de317af591a1908f902;
            this.c8291914306caaadc5c40096e0137389f = c8291914306caaadc5c40096e0137389f;
            if (c8291914306caaadc5c40096e0137389f == null)
            {
                return;
            }
        Label_0017:
            switch (5)
            {
                case 0:
                    goto Label_0017;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c86662039014790ce2273d0930c5bdad3 = c8291914306caaadc5c40096e0137389f.c86662039014790ce2273d0930c5bdad3;
                    break;
            }
        }

        public unsafe ShellMenuItem AddItem(string caption)
        {
            int itemCount = this.ItemCount;
            IntPtr ptr = Marshal.StringToCoTaskMemAuto(caption);
            IntPtr ptr2 = (IntPtr) this.c86662039014790ce2273d0930c5bdad3++;
            int num1 = c1f3ac373189b87d6dcb629efcbe8286b.cdec08eb2f4b5deb59b48561e6d216d96(this.c09d4951f74fe0de317af591a1908f902, 0, ptr2, ptr);
            Marshal.FreeCoTaskMem(ptr);
            return new ShellMenuItem(this, itemCount);
        }

        public void Clear()
        {
            int num = this.ItemCount;
            for (int i = num - 1; i >= 0; i--)
            {
                IntPtr ptr = c1f3ac373189b87d6dcb629efcbe8286b.c2471dc030ae803008c5026f73ae6bd5b(this.c09d4951f74fe0de317af591a1908f902, i);
                c1f3ac373189b87d6dcb629efcbe8286b.c5d70d7f31b4e5b62c0efe422e59a7a80(this.c09d4951f74fe0de317af591a1908f902, i, 0x400);
                if (!(ptr != IntPtr.Zero))
                {
                    continue;
                }
            Label_003F:
                switch (5)
                {
                    case 0:
                        goto Label_003F;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        int num5 = c1f3ac373189b87d6dcb629efcbe8286b.c1ee304d67573818ea21e0fec0320a7f9(ptr);
                        break;
                    }
                }
            }
        }

        public unsafe ShellMenuItem FindItem(string caption)
        {
            // This item is obfuscated and can not be translated.
            string expressionStack_B6_0;
            string expressionStack_9B_0;
            int itemCount = this.ItemCount;
            byte* numPtr = stackalloc byte[300];
            string text6 = caption.ToLower();
            caption = text6;
            int num3 = 0;
            goto Label_00AE;
        Label_009B:
            return new ShellMenuItem(this, num3);
            string expressionStack_A8_0 = expressionStack_9B_0;
        Label_00A8:
            num3++;
            string expressionStack_AE_0 = expressionStack_A8_0;
        Label_00AE:
            if (num3 < itemCount)
            {
                string expressionStack_49_0;
                string expressionStack_88_0;
                string expressionStack_95_0;
                string expressionStack_24_0 = expressionStack_AE_0;
                IntPtr ptr3 = (IntPtr) numPtr;
                int num5 = c1f3ac373189b87d6dcb629efcbe8286b.c9a1d02ab5d9b57f5bfdcbf28bf22716f(this.c09d4951f74fe0de317af591a1908f902, num3, ptr3, 300, 0x400);
                if (num5 == 0)
                {
                    expressionStack_A8_0 = expressionStack_24_0;
                    goto Label_00A8;
                }
                else
                {
                    expressionStack_49_0 = expressionStack_24_0;
                }
                IntPtr ptr = (IntPtr) numPtr;
                string str = Marshal.PtrToStringAuto(ptr);
                str = str.ToLower();
                string oldValue = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x10ed);
                string text10 = str.Replace(oldValue, string.Empty);
                int index = text10.IndexOf(caption);
                if (index == -1)
                {
                    expressionStack_A8_0 = expressionStack_49_0;
                    goto Label_00A8;
                }
                else
                {
                    expressionStack_88_0 = expressionStack_49_0;
                }
            Label_0088:
                switch (4)
                {
                    case 0:
                        goto Label_0088;
                }
                string expressionStack_92_0 = expressionStack_88_0;
                if (1 != 0)
                {
                    expressionStack_9B_0 = expressionStack_92_0;
                    goto Label_009B;
                }
                else
                {
                    expressionStack_95_0 = expressionStack_92_0;
                }
                expressionStack_9B_0 = expressionStack_95_0;
                goto Label_009B;
            }
            else
            {
                expressionStack_B6_0 = expressionStack_AE_0;
            }
        Label_00B6:
            switch (6)
            {
                case 0:
                    goto Label_00B6;
            }
            string expressionStack_C0_0 = expressionStack_B6_0;
            return null;
        }

        public ShellMenuItem Getitem(int index)
        {
            int num = this.ItemCount;
            if (index < 0)
            {
                goto Label_0024;
            }
            if (index < num)
            {
                return new ShellMenuItem(this, index);
            }
        Label_0011:
            switch (5)
            {
                case 0:
                    goto Label_0011;

                default:
                    if (1 == 0)
                    {
                    }
                    break;
            }
        Label_0024:
            return null;
        }

        public unsafe ShellMenuItem InsertItem(string caption, int index)
        {
            int num = this.ItemCount;
            if (num != index)
            {
                if (index < 0)
                {
                    goto Label_003A;
                }
                if (index <= num)
                {
                    long num5 = c1f3ac373189b87d6dcb629efcbe8286b.cbf92feef932e1c73f80d42979e527602(this.c09d4951f74fe0de317af591a1908f902, index, 0x400, (int) this.c86662039014790ce2273d0930c5bdad3++, caption);
                    return new ShellMenuItem(this, index);
                }
            Label_0030:
                switch (3)
                {
                    case 0:
                        goto Label_0030;
                }
                goto Label_003A;
            }
        Label_000D:
            switch (2)
            {
                case 0:
                    goto Label_000D;

                default:
                    if (1 == 0)
                    {
                    }
                    return this.AddItem(caption);
            }
        Label_003A:
            return null;
        }

        public void RemoveItem(int index)
        {
            int itemCount = this.ItemCount;
            if (index < 0)
            {
                return;
            }
        Label_000B:
            switch (4)
            {
                case 0:
                    goto Label_000B;

                default:
                    if (1 == 0)
                    {
                    }
                    if (index < itemCount)
                    {
                        IntPtr ptr = c1f3ac373189b87d6dcb629efcbe8286b.c2471dc030ae803008c5026f73ae6bd5b(this.c09d4951f74fe0de317af591a1908f902, index);
                        int num3 = c1f3ac373189b87d6dcb629efcbe8286b.c5d70d7f31b4e5b62c0efe422e59a7a80(this.c09d4951f74fe0de317af591a1908f902, index, 0x400);
                        if (ptr != IntPtr.Zero)
                        {
                            int num4 = c1f3ac373189b87d6dcb629efcbe8286b.c1ee304d67573818ea21e0fec0320a7f9(ptr);
                        }
                        return;
                    }
                    break;
            }
        Label_0022:
            switch (3)
            {
                case 0:
                    goto Label_0022;
            }
        }

        public int ItemCount
        {
            get
            {
                return c1f3ac373189b87d6dcb629efcbe8286b.c95f47c324f47d7c5a49ee5210ff8d2e5(this.c09d4951f74fe0de317af591a1908f902);
            }
        }

        public ShellContextMenu Parent
        {
            get
            {
                return this.c8291914306caaadc5c40096e0137389f;
            }
        }
    }
}

