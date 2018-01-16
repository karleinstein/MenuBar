namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    public class ShellMenuItem
    {
        private ShellContextMenu c2e6a1e6fa1b2666d36110f10f68b715f;
        private int cf0836916dccce7c844b0870aa147ff01;

        internal ShellMenuItem(ShellContextMenu c2e6a1e6fa1b2666d36110f10f68b715f, int cf0836916dccce7c844b0870aa147ff01)
        {
            this.c2e6a1e6fa1b2666d36110f10f68b715f = c2e6a1e6fa1b2666d36110f10f68b715f;
            this.cf0836916dccce7c844b0870aa147ff01 = cf0836916dccce7c844b0870aa147ff01;
        }

        public void SetBitmap(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                IntPtr hbitmap = bitmap.GetHbitmap();
                int num1 = c1f3ac373189b87d6dcb629efcbe8286b.ce245fa73da7b6f9ddbe8e23c3e18b045(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 0x400, hbitmap, IntPtr.Zero);
            }
        }

        public bool BarBreak
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x100;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return ((structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f & 0x20) != 0);
            }
            set
            {
                int num4;
                cdfcd3aeca49fbd520317e77812b30da0 cdfcdaecafbdebda;
                cdfcdaecafbdebda = new cdfcd3aeca49fbd520317e77812b30da0 {
                    c08faa9327f04bb2f4ec070217041d8dd = (uint) Marshal.SizeOf(cdfcdaecafbdebda),
                    c540ad1dfab179ea332d378f0ca7f35f4 = 0x100
                };
                int num3 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref cdfcdaecafbdebda);
                if (!value)
                {
                    cdfcdaecafbdebda.caa65ef5ac7fe45d7f40bdebf5dbedb3f &= 0xffffffdf;
                    goto Label_007A;
                }
            Label_0045:
                switch (3)
                {
                    case 0:
                        goto Label_0045;

                    default:
                        if (1 == 0)
                        {
                        }
                        cdfcdaecafbdebda.caa65ef5ac7fe45d7f40bdebf5dbedb3f |= 0x20;
                        break;
                }
            Label_007A:
                num4 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref cdfcdaecafbdebda);
            }
        }

        public bool Break
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x100;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return ((structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f & 0x40) != 0);
            }
            set
            {
                int num4;
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num3 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num3;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x100;
                c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (!value)
                {
                    structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f &= 0xffffffbf;
                    goto Label_007A;
                }
            Label_0045:
                switch (1)
                {
                    case 0:
                        goto Label_0045;

                    default:
                        if (1 == 0)
                        {
                        }
                        structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f |= 0x40;
                        break;
                }
            Label_007A:
                num4 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public string Caption
        {
            get
            {
                byte* numPtr = stackalloc byte[600];
                c1f3ac373189b87d6dcb629efcbe8286b.c9a1d02ab5d9b57f5bfdcbf28bf22716f(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, this.cf0836916dccce7c844b0870aa147ff01, (IntPtr) numPtr, 300, 0x400);
                IntPtr ptr = (IntPtr) numPtr;
                return Marshal.PtrToStringAuto(ptr);
            }
            set
            {
                IntPtr ptr = Marshal.StringToCoTaskMemAuto(value);
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x40;
                structure.c9829370de4ddb2697fd6c241a230d50d = ptr;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        public bool Checked
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 1;
                c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return ((structure.c0213081eba5640047655849019e2bc29 & 8) != 0);
            }
            set
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num3 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num3;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 1;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (!value)
                {
                    structure.c0213081eba5640047655849019e2bc29 &= 0xfffffff7;
                    goto Label_0077;
                }
            Label_0043:
                switch (7)
                {
                    case 0:
                        goto Label_0043;

                    default:
                        if (1 == 0)
                        {
                        }
                        structure.c0213081eba5640047655849019e2bc29 |= 8;
                        break;
                }
            Label_0077:
                c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public bool DefaultItem
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 1;
                c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return ((structure.c0213081eba5640047655849019e2bc29 & 0x1000) != 0);
            }
            set
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 1;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (value)
                {
                    structure.c0213081eba5640047655849019e2bc29 |= 0x1000;
                }
                else
                {
                    structure.c0213081eba5640047655849019e2bc29 &= 0xffffefff;
                }
                int num3 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public bool Enabled
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 cdfcdaecafbdebda;
                cdfcdaecafbdebda = new cdfcd3aeca49fbd520317e77812b30da0 {
                    c08faa9327f04bb2f4ec070217041d8dd = (uint) Marshal.SizeOf(cdfcdaecafbdebda),
                    c540ad1dfab179ea332d378f0ca7f35f4 = 1
                };
                int num1 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref cdfcdaecafbdebda);
                return ((cdfcdaecafbdebda.c0213081eba5640047655849019e2bc29 & 3) != 0);
            }
            set
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 1;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (value)
                {
                    structure.c0213081eba5640047655849019e2bc29 &= 0xfffffffc;
                }
                else
                {
                    structure.c0213081eba5640047655849019e2bc29 |= 3;
                }
                int num3 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public bool HasSubMenu
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 4;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return (structure.c371af7e79cdf9356abc43164bd043d6b != IntPtr.Zero);
            }
            set
            {
                int num8;
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num5 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num5;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 4;
                int num6 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                IntPtr ptr = structure.c371af7e79cdf9356abc43164bd043d6b;
                bool flag2 = ptr != IntPtr.Zero;
                if (value != flag2)
                {
                    if (!value)
                    {
                        structure.c371af7e79cdf9356abc43164bd043d6b = IntPtr.Zero;
                        int num7 = c1f3ac373189b87d6dcb629efcbe8286b.c1ee304d67573818ea21e0fec0320a7f9(ptr);
                        goto Label_009C;
                    }
                Label_006F:
                    switch (7)
                    {
                        case 0:
                            goto Label_006F;
                    }
                    structure.c371af7e79cdf9356abc43164bd043d6b = c1f3ac373189b87d6dcb629efcbe8286b.c80fb683be0b0fc2fa33aeac432730520();
                    goto Label_009C;
                }
            Label_0058:
                switch (1)
                {
                    case 0:
                        goto Label_0058;

                    default:
                        if (1 == 0)
                        {
                        }
                        return;
                }
            Label_009C:
                num8 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public int ID
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 2;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return (int) structure.c22456bfbe71c458876d7724dd41b6598;
            }
        }

        public int Index
        {
            get
            {
                return this.cf0836916dccce7c844b0870aa147ff01;
            }
            set
            {
                if (value == this.cf0836916dccce7c844b0870aa147ff01)
                {
                    return;
                }
                int num = this.c2e6a1e6fa1b2666d36110f10f68b715f.ItemCount;
                if (value < 0)
                {
                    return;
                }
            Label_001C:
                switch (3)
                {
                    case 0:
                        goto Label_001C;

                    default:
                        if (1 == 0)
                        {
                        }
                        if (value < num)
                        {
                            cdfcd3aeca49fbd520317e77812b30da0 cdfcdaecafbdebda;
                            byte* numPtr = stackalloc byte[600];
                            cdfcdaecafbdebda = new cdfcd3aeca49fbd520317e77812b30da0 {
                                c08faa9327f04bb2f4ec070217041d8dd = (uint) Marshal.SizeOf(cdfcdaecafbdebda),
                                cf98c04dd2ec4651adb286fe475fc6a83 = 300,
                                c9829370de4ddb2697fd6c241a230d50d = (IntPtr) numPtr,
                                c540ad1dfab179ea332d378f0ca7f35f4 = 0x1e7
                            };
                            int num5 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref cdfcdaecafbdebda);
                            int num6 = c1f3ac373189b87d6dcb629efcbe8286b.c5d70d7f31b4e5b62c0efe422e59a7a80(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, this.cf0836916dccce7c844b0870aa147ff01, 0x400);
                            c1f3ac373189b87d6dcb629efcbe8286b.c4c7930e5ed2f58322713397be90988fb(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) value, 1, ref cdfcdaecafbdebda);
                            this.cf0836916dccce7c844b0870aa147ff01 = value;
                            return;
                        }
                        break;
                }
            }
        }

        public ShellContextMenu Parent
        {
            get
            {
                return this.c2e6a1e6fa1b2666d36110f10f68b715f;
            }
        }

        public bool RadioChecked
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num3 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num3;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x101;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if ((structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f & 0x200) == 0)
                {
                    return false;
                }
            Label_0053:
                switch (1)
                {
                    case 0:
                        goto Label_0053;
                }
                if (1 == 0)
                {
                }
                return ((structure.c0213081eba5640047655849019e2bc29 & 8) != 0);
            }
            set
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x101;
                c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (value)
                {
                    structure.c0213081eba5640047655849019e2bc29 |= 8;
                    structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f |= 0x200;
                }
                else
                {
                    structure.c0213081eba5640047655849019e2bc29 &= 0xfffffff7;
                    structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f &= 0xfffffdff;
                }
                c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public bool Separator
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x100;
                c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                return ((structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f & 0x800) != 0);
            }
            set
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num1 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num1;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 0x100;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (value)
                {
                    structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f |= 0x800;
                }
                else
                {
                    structure.caa65ef5ac7fe45d7f40bdebf5dbedb3f &= 0xfffff7ff;
                }
                int num3 = c1f3ac373189b87d6dcb629efcbe8286b.c643a3652db709444c383b2de89234c95(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
            }
        }

        public ShellContextMenu SubMenu
        {
            get
            {
                cdfcd3aeca49fbd520317e77812b30da0 structure = new cdfcd3aeca49fbd520317e77812b30da0();
                int num3 = Marshal.SizeOf(structure);
                structure.c08faa9327f04bb2f4ec070217041d8dd = (uint) num3;
                structure.c540ad1dfab179ea332d378f0ca7f35f4 = 4;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.cf8ec13019691bfc0d709d16838f3c73d(this.c2e6a1e6fa1b2666d36110f10f68b715f.c09d4951f74fe0de317af591a1908f902, (uint) this.cf0836916dccce7c844b0870aa147ff01, 1, ref structure);
                if (!(structure.c371af7e79cdf9356abc43164bd043d6b == IntPtr.Zero))
                {
                    return new ShellContextMenu(structure.c371af7e79cdf9356abc43164bd043d6b, this.c2e6a1e6fa1b2666d36110f10f68b715f);
                }
            Label_0053:
                switch (1)
                {
                    case 0:
                        goto Label_0053;
                }
                if (1 == 0)
                {
                }
                return null;
            }
        }
    }
}

