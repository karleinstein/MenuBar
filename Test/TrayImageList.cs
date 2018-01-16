namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;

    public class TrayImageList
    {
        internal cd920eb165fcac342b813f0f8d69420c7 c86b9294fa317bc153018374ee90a6fa8;
        internal c9feff348729e8410c02baff0b324ecd0 cb5a80450517d05a26c4a42e349a12830;

        internal TrayImageList(c9feff348729e8410c02baff0b324ecd0 cb5a80450517d05a26c4a42e349a12830)
        {
            this.cb5a80450517d05a26c4a42e349a12830 = cb5a80450517d05a26c4a42e349a12830;
            this.c86b9294fa317bc153018374ee90a6fa8 = cb5a80450517d05a26c4a42e349a12830.c86b9294fa317bc153018374ee90a6fa8;
        }

        public void Add(Bitmap bmp)
        {
            IntPtr hbitmap = c1f3ac373189b87d6dcb629efcbe8286b.c09cebff002d11977a8794109d04285fa;
            if (bmp == null)
            {
                goto Label_0023;
            }
        Label_0009:
            switch (2)
            {
                case 0:
                    goto Label_0009;

                default:
                    if (1 == 0)
                    {
                    }
                    hbitmap = bmp.GetHbitmap();
                    break;
            }
        Label_0023:
            if (!(hbitmap != IntPtr.Zero))
            {
                return;
            }
        Label_0032:
            switch (1)
            {
                case 0:
                    goto Label_0032;

                default:
                    this.c86b9294fa317bc153018374ee90a6fa8.c9e15a435d9fdd526c92d44cd3ec44b9c(hbitmap);
                    break;
            }
        }

        public void AddStrip(Bitmap bmp, int width)
        {
            IntPtr ptr = c1f3ac373189b87d6dcb629efcbe8286b.c09cebff002d11977a8794109d04285fa;
            if (bmp == null)
            {
                goto Label_0025;
            }
        Label_0009:
            switch (5)
            {
                case 0:
                    goto Label_0009;

                default:
                    if (1 == 0)
                    {
                    }
                    ptr = bmp.GetHbitmap();
                    break;
            }
        Label_0025:
            if (!(ptr != IntPtr.Zero))
            {
                goto Label_0049;
            }
        Label_0032:
            switch (4)
            {
                case 0:
                    goto Label_0032;

                default:
                    this.c86b9294fa317bc153018374ee90a6fa8.c27de3119b6257cf51afa8d231631786d(ptr, width);
                    break;
            }
        Label_0049:
            c1f3ac373189b87d6dcb629efcbe8286b.c844fa640a77e496a6bc0993c6e97f021(ptr);
        }

        public Bitmap GetAt(int index)
        {
            if (index < 0)
            {
                goto Label_0031;
            }
        Label_0004:
            switch (7)
            {
                case 0:
                    goto Label_0004;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int num2 = this.c86b9294fa317bc153018374ee90a6fa8.c6fb6c993aa193eb2510ab09a7268db89();
                    if (index < num2)
                    {
                        IntPtr ptr2 = this.c86b9294fa317bc153018374ee90a6fa8.c1c92a2218e8d52d1ae361e18a8018671(index);
                        return Image.FromHbitmap(c1f3ac373189b87d6dcb629efcbe8286b.c9d415c898ee4b3506f3af107ad41b3f9(ptr2, 0, 0, 0, 0));
                    }
                    break;
                }
            }
        Label_0027:
            switch (5)
            {
                case 0:
                    goto Label_0027;
            }
        Label_0031:
            throw new IndexOutOfRangeException();
        }

        public void RemoveAll()
        {
            this.c86b9294fa317bc153018374ee90a6fa8.c2b5010745e20f36cc83bab01241c842e();
        }

        public Bitmap RemoveAt(int index)
        {
            if (index < 0)
            {
                goto Label_0031;
            }
        Label_0004:
            switch (6)
            {
                case 0:
                    goto Label_0004;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int num2 = this.c86b9294fa317bc153018374ee90a6fa8.c6fb6c993aa193eb2510ab09a7268db89();
                    if (index < num2)
                    {
                        IntPtr hbitmap = this.c86b9294fa317bc153018374ee90a6fa8.cf88060b93b58e3b464c1a3f5189ae90b(index);
                        return Image.FromHbitmap(hbitmap);
                    }
                    break;
                }
            }
        Label_0027:
            switch (4)
            {
                case 0:
                    goto Label_0027;
            }
        Label_0031:
            throw new IndexOutOfRangeException();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count
        {
            get
            {
                return this.c86b9294fa317bc153018374ee90a6fa8.c6fb6c993aa193eb2510ab09a7268db89();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DefaultValue(typeof(object), "null")]
        public TrayImageListStreamer Streamer
        {
            get
            {
                if (this.c86b9294fa317bc153018374ee90a6fa8.c6fb6c993aa193eb2510ab09a7268db89() <= 0)
                {
                    return null;
                }
                return new TrayImageListStreamer(this);
            }
            set
            {
                if (value != null)
                {
                    try
                    {
                        int num7;
                        object obj3;
                        int num;
                        int num5 = ColorTranslator.ToWin32(value.tClr);
                        this.c86b9294fa317bc153018374ee90a6fa8.c43e113a305e15c4fb96d407f389976bc = num5;
                        if (value.lstImages == null)
                        {
                            return;
                        }
                    Label_0027:
                        switch (6)
                        {
                            case 0:
                                goto Label_0027;

                            default:
                                if (1 == 0)
                                {
                                }
                                num = 0;
                                goto Label_00B8;
                        }
                    Label_003E:
                        obj3 = value.lstImages[num];
                        byte[] buffer = (byte[]) obj3;
                        int length = buffer.Length;
                        cfcedf6504f851bff600c57c3416bb4f6 cfcedffbffccbbf = new cfcedf6504f851bff600c57c3416bb4f6(new MemoryStream(buffer));
                        c5001fc25b22c764c441dbd96c957460f cfcbccdbdcf = null;
                        int num6 = c1f3ac373189b87d6dcb629efcbe8286b.c891712252a2339306c22ba83e1c2507b(cfcedffbffccbbf, length, 0, ref c1f3ac373189b87d6dcb629efcbe8286b.c2887a36300b2bb4aa9ac680aa1369828, out cfcbccdbdcf);
                        cfcedffbffccbbf.c421c8421da70f1345519d2e49fb6e99d();
                        if (cfcbccdbdcf == null)
                        {
                            goto Label_00B4;
                        }
                    Label_0081:
                        switch (5)
                        {
                            case 0:
                                goto Label_0081;

                            default:
                            {
                                IntPtr zero = IntPtr.Zero;
                                zero = cfcbccdbdcf.c6694a18294ee003816eb76b25dc73b1e();
                                this.c86b9294fa317bc153018374ee90a6fa8.c9e15a435d9fdd526c92d44cd3ec44b9c(c1f3ac373189b87d6dcb629efcbe8286b.c9d415c898ee4b3506f3af107ad41b3f9(zero, 0, 0, 0, 0));
                                cfcbccdbdcf = null;
                                break;
                            }
                        }
                    Label_00B4:
                        num++;
                    Label_00B8:
                        num7 = value.lstImages.Count;
                        if (num < num7)
                        {
                            goto Label_003E;
                        }
                    Label_00CB:
                        switch (7)
                        {
                            case 0:
                                goto Label_00CB;
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TransparentColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c86b9294fa317bc153018374ee90a6fa8.c43e113a305e15c4fb96d407f389976bc);
            }
            set
            {
                int num = ColorTranslator.ToWin32(value);
                if (num == this.c86b9294fa317bc153018374ee90a6fa8.c43e113a305e15c4fb96d407f389976bc)
                {
                    return;
                }
            Label_0017:
                switch (4)
                {
                    case 0:
                        goto Label_0017;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c86b9294fa317bc153018374ee90a6fa8.c677c63fc2c7b4bb004f0547d3670ac26(num);
                        break;
                }
            }
        }
    }
}

