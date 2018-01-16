namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class ShellPopup
    {
        internal c32c9bc878d9c391059a9d31d8662810a c98e7d52cc27af8bcd28ab44ffa041d39 = new c32c9bc878d9c391059a9d31d8662810a();
        internal c55fc859b2ef86cbc2bc9830b6d750078 cac5ce854381bc91093b88774a899ac6a;
        internal object cd228fedb4b74b92989dfdfdfca521f04;

        public ShellPopup()
        {
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c5dd3655f701702e8bd024f9e7a4dd4ba = this;
        }

        internal void c4273f85264c97de57a862332c79d4dc3()
        {
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c4273f85264c97de57a862332c79d4dc3();
        }

        [Description("Closes the popup notification.")]
        public void Close()
        {
            this.c98e7d52cc27af8bcd28ab44ffa041d39.cba85633e7ecf20052ccbf7cda8a75a02 = false;
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c421c8421da70f1345519d2e49fb6e99d();
        }

        [Description("Returns the area of the popup notification under the specified coordinates.")]
        public ShellPopupAreas HitTest(int x, int y)
        {
            return (ShellPopupAreas) this.c98e7d52cc27af8bcd28ab44ffa041d39.ceadcfab4a10f3b29c5730d06a13a4f6e(new c8803a5fde1b30868bed8db187c3e355b(x, y));
        }

        [Description("Displays a context menu.")]
        public unsafe void InvokeContextMenu()
        {
            c1f3ac373189b87d6dcb629efcbe8286b.ca3dca83d6198a1d485108cfab2fbc689(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle, (IntPtr) 0x3e9);
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c731cb5a34e5b91b1b3c23c9b7cd2b0ee = true;
            IntPtr ptr = c1f3ac373189b87d6dcb629efcbe8286b.c80fb683be0b0fc2fa33aeac432730520();
            int* numPtr = (int*) stackalloc byte[(((IntPtr) 1) * 4)];
            numPtr[0] = 100;
            ShellContextMenu menu = new ShellContextMenu(ptr, null) {
                c86662039014790ce2273d0930c5bdad3 = numPtr
            };
            this.cac5ce854381bc91093b88774a899ac6a.ca3a8c6013a36566388b2e80521bf4a90(this, menu);
            c8803a5fde1b30868bed8db187c3e355b cafdebbeddbceb = new c8803a5fde1b30868bed8db187c3e355b();
            c1f3ac373189b87d6dcb629efcbe8286b.c5d61430e7f3514201eb7ea78e3005e50(ref cafdebbeddbceb);
            IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
            c1f3ac373189b87d6dcb629efcbe8286b.cff00b31a1ff6c97c72b8d9de3ed99d7b(handle);
            int num = c1f3ac373189b87d6dcb629efcbe8286b.c3b8342c7a2f744dd5ed50c4c0402bf6a(ptr, 0x102, cafdebbeddbceb.c7bb708bfe3cb37fa1ebbdbace03ad3c4, cafdebbeddbceb.c2cc94d04c55dd96868ec2a6623a249ca, 0, this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle, c1f3ac373189b87d6dcb629efcbe8286b.c09cebff002d11977a8794109d04285fa);
            if (num == 0)
            {
                goto Label_0107;
            }
        Label_00AB:
            switch (7)
            {
                case 0:
                    goto Label_00AB;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    byte* numPtr2 = stackalloc byte[0x3e8];
                    IntPtr ptr6 = (IntPtr) numPtr2;
                    int num5 = c1f3ac373189b87d6dcb629efcbe8286b.c9a1d02ab5d9b57f5bfdcbf28bf22716f(ptr, num, ptr6, 300, 0);
                    string text2 = Marshal.PtrToStringAuto((IntPtr) numPtr2);
                    this.cac5ce854381bc91093b88774a899ac6a.ced366712de95519cc07b956d4319a113(this, text2, num);
                    int num6 = c1f3ac373189b87d6dcb629efcbe8286b.c1ee304d67573818ea21e0fec0320a7f9(ptr);
                    break;
                }
            }
        Label_0107:
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c731cb5a34e5b91b1b3c23c9b7cd2b0ee = false;
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c821b0e1794b1cb0fe61e5e42fdbfa900();
        }

        [Description("Specifies a cursor for an area (such as the link) of the popup notification.")]
        public void SetAreaCursor(ShellPopupAreas area, Cursor c)
        {
            IntPtr handle = c.Handle;
            this.c98e7d52cc27af8bcd28ab44ffa041d39.cb98477497e941adf1c36e96bc9a663fa((cc92c94c0370c68d1eb5c3f9b14a86b75) area, c1da7f7898278c26dfd53fb7f357401a5.cbc68b50c2432a82d8d45396101927d36, handle);
        }

        [Description("Sets the screen position of the popup notification.")]
        public void SetPosition(int left, int top, int width, int height)
        {
            this.c98e7d52cc27af8bcd28ab44ffa041d39.cdf16ab70ba41859ef5776b06a470017c(left, top, width, height);
        }

        public void Show()
        {
            this.c98e7d52cc27af8bcd28ab44ffa041d39.c29e27b28fb418db9719963b0aee2b4cd(true);
        }

        [DefaultValue(0x7d0), Description("Gets or sets the time duration that the popup notification is shown before it is automatically hidden.")]
        public int ActiveShowTime
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.cf2160d005ff0179032d40d0e3c49e8e7;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0), c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xeb));
                }
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cf2160d005ff0179032d40d0e3c49e8e7 = value;
            }
        }

        [DefaultValue(typeof(bool), "true"), Description("Gets or sets whether the popup notification can be dragged.")]
        public bool AllowDrag
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.cc6e24923fddcdefe324b6b4a84f28c8a;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cc6e24923fddcdefe324b6b4a84f28c8a = value;
                this.c98e7d52cc27af8bcd28ab44ffa041d39.ca7560d8b6a1370969cd53133749cf8e4[7] = this.c98e7d52cc27af8bcd28ab44ffa041d39.cc6e24923fddcdefe324b6b4a84f28c8a ? c1f3ac373189b87d6dcb629efcbe8286b.ce80c8b05ff17646dbe4c698871641352(c1f3ac373189b87d6dcb629efcbe8286b.c09cebff002d11977a8794109d04285fa, c1f3ac373189b87d6dcb629efcbe8286b.cf06b6f7b457db69b3c25154580131a2a) : this.c98e7d52cc27af8bcd28ab44ffa041d39.ca7560d8b6a1370969cd53133749cf8e4[0];
            }
        }

        [Description("Gets or sets the animation style used to show the popup notification."), DefaultValue(typeof(AnimStyles), "Slide")]
        public AnimStyles AnimationStyle
        {
            get
            {
                return (AnimStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.cea1497684b3fb158abd2bfe98b1c7a33;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c7b4b5653b2f301f641d2823628fe0ae6((cd8c4bd82b4ee558f3f2f2c8f5b4b2d5a) value);
            }
        }

        [Description("Gets or sets the time duration of the animation used for the popup notification."), DefaultValue(600)]
        public int AnimTime
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.cba661e70342555b72d71bd592b4069d8;
            }
            set
            {
                if (value < 0)
                {
                    string paramName = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xe0);
                    string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xeb);
                    throw new ArgumentOutOfRangeException(paramName, message);
                }
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cba661e70342555b72d71bd592b4069d8 = value;
            }
        }

        [Description("Gets or sets the back color of the popup notification.")]
        public Color BackColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c19b43848a1f0aea6b028dc6ef313d410);
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c19b43848a1f0aea6b028dc6ef313d410 = ColorTranslator.ToWin32(value);
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0027:
                switch (7)
                {
                    case 0:
                        goto Label_0027;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the second back color of the popup notification, used when gradient or hatch fill styles are specified.")]
        public Color BackColor2
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c812d42eaf7087c5aab5ee3c89869ddf6);
            }
            set
            {
                int num3 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c812d42eaf7087c5aab5ee3c89869ddf6 = num3;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num4 == 0)
                {
                    return;
                }
            Label_0029:
                switch (4)
                {
                    case 0:
                        goto Label_0029;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the background fill style of the popup notification.")]
        public FillStyles BackFillStyle
        {
            get
            {
                return (FillStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.ce09170fb78df71fb8df3eadb3c0ddf1a;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.ce09170fb78df71fb8df3eadb3c0ddf1a = (ceaa518dd6277b7d4710e81d9cf1aedf3) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the gradient style of the popup notification.")]
        public GradientModes BackGradientMode
        {
            get
            {
                return (GradientModes) this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b44463395d1df8a42c5e940e44a2f0b;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b44463395d1df8a42c5e940e44a2f0b = (c98f7f49ca0e7d16af82ad88f80487d6d) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (6)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the hatch style of the popup notification.")]
        public HatchStyles BackHatchStyle
        {
            get
            {
                return (HatchStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.c533f61c7f306aa4cdfe0a381992c091d;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c533f61c7f306aa4cdfe0a381992c091d = (c6df601c5105102f0b48101331a1810dc) value;
                int num1 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num1 != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the background image of the popup notification.")]
        public Bitmap BackImage
        {
            get
            {
                if (!this.c98e7d52cc27af8bcd28ab44ffa041d39.c5fd3bc37c1d039b4a6be17a201c9b3d2.caa44489dc2e122ce0c46d26fcff8c5d3())
                {
                    return Image.FromHbitmap(c1f3ac373189b87d6dcb629efcbe8286b.c9d415c898ee4b3506f3af107ad41b3f9(this.c98e7d52cc27af8bcd28ab44ffa041d39.c5fd3bc37c1d039b4a6be17a201c9b3d2.c35944a77c120e64ac4f8bd6358d186c0, 0, 0, 0, 0));
                }
            Label_0012:
                switch (7)
                {
                    case 0:
                        goto Label_0012;
                }
                if (1 == 0)
                {
                }
                return null;
            }
            set
            {
                IntPtr ptr = c1f3ac373189b87d6dcb629efcbe8286b.c09cebff002d11977a8794109d04285fa;
                if (value == null)
                {
                    goto Label_0025;
                }
            Label_0009:
                switch (3)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        ptr = cf6ad7aa942b6f1af1ed3ac2f2623b999.cdc1365cdbf122b5bd6d723ab7b46b988(value);
                        break;
                }
            Label_0025:
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c5fd3bc37c1d039b4a6be17a201c9b3d2.cf7729d24daa998e0f5871c952c5ff2d3(this.c98e7d52cc27af8bcd28ab44ffa041d39.c953050057011e5a4f17e3dd328c87487, ptr, this.c98e7d52cc27af8bcd28ab44ffa041d39.c9940cc8d01a0c40d4dd2ff2d8e851234);
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0060:
                switch (6)
                {
                    case 0:
                        goto Label_0060;

                    default:
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(typeof(HAlignments), "Center"), Description("Gets or sets the horizontal alignment of the background image of the popup notification.")]
        public HAlignments BackImageHAlign
        {
            get
            {
                return (HAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.c3458c096401d7f89361a78bb84d85e2c;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c3458c096401d7f89361a78bb84d85e2c = (c09c345fe99aafe7ea8b53f49cb5f95ca) value;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0020:
                switch (7)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(typeof(bool), "true"), Description("Gets or sets whether the background image of the popup notification is drawn transparently.")]
        public bool BackImageIsTransparent
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c953050057011e5a4f17e3dd328c87487;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c953050057011e5a4f17e3dd328c87487 = value;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0020:
                switch (5)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(typeof(Color), "Black"), Description("Gets or sets the transparent color used to draw the background image of the popup notification.")]
        public Color BackImageTransparentColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c9940cc8d01a0c40d4dd2ff2d8e851234);
            }
            set
            {
                int num3 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c9940cc8d01a0c40d4dd2ff2d8e851234 = num3;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num4 == 0)
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
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the vertical alignment of the background image of the popup notification."), DefaultValue(typeof(VAlignments), "Center")]
        public VAlignments BackImageVAlign
        {
            get
            {
                return (VAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.cea63e61d951c7778217e01435ea5f249;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cea63e61d951c7778217e01435ea5f249 = (c7a97930cb711ac72c8d6c7cf6c1bfa4e) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (3)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the border color of the popup notification.")]
        public Color BorderColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c4308504114c921b148ab1c3a349b21e5);
            }
            set
            {
                int num1 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c4308504114c921b148ab1c3a349b21e5 = num1;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the second border color of the popup notification, used when a 3D border style is specified.")]
        public Color BorderColor3D
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c04ada44ec12234d1833826546adbc7e3);
            }
            set
            {
                int num1 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c04ada44ec12234d1833826546adbc7e3 = num1;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num2 != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the border style of the popup notification.")]
        public BorderStyles BorderStyle
        {
            get
            {
                return (BorderStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.cd0bfa995f5461d340d70fe97adcfc038;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cd0bfa995f5461d340d70fe97adcfc038 = (cd3ad059530999d68f31c71b0a59be9da) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0020:
                switch (2)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the gripper color of the popup notification.")]
        public Color GripperColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.cc1c04c681e982e8f986bf6076abaaa94);
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.ccb7b8bbaee026f975af0916a18deae0f = ColorTranslator.ToWin32(value);
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle) == 0)
                {
                    return;
                }
            Label_0023:
                switch (2)
                {
                    case 0:
                        goto Label_0023;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the second gripper color of the popup notification.")]
        public Color GripperColor2
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.ccb7b8bbaee026f975af0916a18deae0f);
            }
            set
            {
                int num2 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.ccb7b8bbaee026f975af0916a18deae0f = num2;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0027:
                switch (1)
                {
                    case 0:
                        goto Label_0027;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the gradient style used for the gripper of the popup notification.")]
        public GradientModes GripperGradientMode
        {
            get
            {
                return (GradientModes) this.c98e7d52cc27af8bcd28ab44ffa041d39.ccc3cc91ed8a63a4a91bf1187910f6833;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.ccc3cc91ed8a63a4a91bf1187910f6833 = (c98f7f49ca0e7d16af82ad88f80487d6d) value;
                int num1 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num1 != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the height of the popup notification.")]
        public int Height
        {
            get
            {
                return (this.c98e7d52cc27af8bcd28ab44ffa041d39.cbf4e3ac714f18c91399c06995c80e3c0 - this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5);
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cdf16ab70ba41859ef5776b06a470017c(this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba, this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5, this.c98e7d52cc27af8bcd28ab44ffa041d39.cb3ca8ee4b7018e3e9402fdd5d3dee04e - this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba, this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5 + value);
            }
        }

        [Description("Gets or sets the left position of the popup notification.")]
        public int Left
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cdf16ab70ba41859ef5776b06a470017c(value, this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5, this.c98e7d52cc27af8bcd28ab44ffa041d39.cb3ca8ee4b7018e3e9402fdd5d3dee04e - this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba, this.c98e7d52cc27af8bcd28ab44ffa041d39.cbf4e3ac714f18c91399c06995c80e3c0 - this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5);
            }
        }

        [Description("Gets or sets the color of the link of the popup notification.")]
        public Color LinkColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.cd62492191176db9ddb948df8366e800c);
            }
            set
            {
                int num3 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cd62492191176db9ddb948df8366e800c = num3;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num4 == 0)
                {
                    return;
                }
            Label_0029:
                switch (7)
                {
                    case 0:
                        goto Label_0029;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the color of the hot-state link of the popup notification.")]
        public Color LinkColorHot
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.caeec0e5c53b95fa5b8d9e76e4518da86);
            }
            set
            {
                int num2 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.caeec0e5c53b95fa5b8d9e76e4518da86 = num2;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0027:
                switch (5)
                {
                    case 0:
                        goto Label_0027;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the font name of the popup notification.")]
        public string LinkFontName
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c3b58f3642eaeacbaeaae9bf9b0c20354;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c3b58f3642eaeacbaeaae9bf9b0c20354 = value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (6)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the font size of the link of the popup notification.")]
        public int LinkFontSize
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.cc47bace3901041624a823534900447c7;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cc47bace3901041624a823534900447c7 = value;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle) == 0)
                {
                    return;
                }
            Label_001E:
                switch (2)
                {
                    case 0:
                        goto Label_001E;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the font style of the link of the popup notification.")]
        public FontStyles LinkFontStyle
        {
            get
            {
                return (FontStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.c529dd4dc2c65e5bb7b2dc504880c25f4;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c529dd4dc2c65e5bb7b2dc504880c25f4 = (c1c56fdf5e5786b07f40743d18cf96b34) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (7)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the font style of the hot-state link of the popup notification.")]
        public FontStyles LinkFontStyleHot
        {
            get
            {
                return (FontStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.c8a60ab13a089387b39920d1ad2ebb094;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c8a60ab13a089387b39920d1ad2ebb094 = (c1c56fdf5e5786b07f40743d18cf96b34) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (6)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the horizontal alignment of the link of the popup notification.")]
        public HAlignments LinkHAlign
        {
            get
            {
                return (HAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.c4d48fb83f0f348c272b22ace89e0a18d;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c4d48fb83f0f348c272b22ace89e0a18d = (c09c345fe99aafe7ea8b53f49cb5f95ca) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0020:
                switch (7)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(""), Description("Gets or sets the link text shown in the popup notification.")]
        public string LinkString
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c8f204248f3be03579a09d3feea59f420;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c8f204248f3be03579a09d3feea59f420 = value;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle) == 0)
                {
                    return;
                }
            Label_001E:
                switch (3)
                {
                    case 0:
                        goto Label_001E;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the vertical alignment of the link of the popup notification.")]
        public VAlignments LinkVAlign
        {
            get
            {
                return (VAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.c276e7e67a0b29c69241140b8b8be08e9;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c276e7e67a0b29c69241140b8b8be08e9 = (c7a97930cb711ac72c8d6c7cf6c1bfa4e) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (6)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the logo image of the popup notification.")]
        public Bitmap LogoImage
        {
            get
            {
                if (this.c98e7d52cc27af8bcd28ab44ffa041d39.c50547734dbb82039062eeecfa5c42a73.caa44489dc2e122ce0c46d26fcff8c5d3())
                {
                    return null;
                }
                return Image.FromHbitmap(c1f3ac373189b87d6dcb629efcbe8286b.c9d415c898ee4b3506f3af107ad41b3f9(this.c98e7d52cc27af8bcd28ab44ffa041d39.c50547734dbb82039062eeecfa5c42a73.c35944a77c120e64ac4f8bd6358d186c0, 0, 0, 0, 0));
            }
            set
            {
                IntPtr ptr = c1f3ac373189b87d6dcb629efcbe8286b.c09cebff002d11977a8794109d04285fa;
                if (value != null)
                {
                    ptr = cf6ad7aa942b6f1af1ed3ac2f2623b999.cdc1365cdbf122b5bd6d723ab7b46b988(value);
                }
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c50547734dbb82039062eeecfa5c42a73.cf7729d24daa998e0f5871c952c5ff2d3(this.c98e7d52cc27af8bcd28ab44ffa041d39.cfed08b89ccf8963cfb7b330737fcf96a, ptr, this.c98e7d52cc27af8bcd28ab44ffa041d39.c984a20578610545b7a9f54f248f0f48f);
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_004D:
                switch (3)
                {
                    case 0:
                        goto Label_004D;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(typeof(HAlignments), "Left"), Description("Gets or sets the horizontal alignment of the logo image of the popup notification.")]
        public HAlignments LogoImageHAlign
        {
            get
            {
                return (HAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.c5ced2354795742613ab4e756775a2044;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c5ced2354795742613ab4e756775a2044 = (c09c345fe99aafe7ea8b53f49cb5f95ca) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (2)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets whether the logo image of the popup notification is drawn transparently."), DefaultValue(typeof(bool), "true")]
        public bool LogoImageIsTransparent
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.cfed08b89ccf8963cfb7b330737fcf96a;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cfed08b89ccf8963cfb7b330737fcf96a = value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the transparent color of the logo image of the popup notification."), DefaultValue(typeof(Color), "Black")]
        public Color LogoImageTransparentColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c984a20578610545b7a9f54f248f0f48f);
            }
            set
            {
                int num3 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c984a20578610545b7a9f54f248f0f48f = num3;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num4 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num4 == 0)
                {
                    return;
                }
            Label_0029:
                switch (1)
                {
                    case 0:
                        goto Label_0029;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(typeof(VAlignments), "Top"), Description("Gets or sets the vertical alignment of the logo image of the popup notification.")]
        public VAlignments LogoImageVAlign
        {
            get
            {
                return (VAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.cea764d8c63824bf18b9557635b840826;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cea764d8c63824bf18b9557635b840826 = (c7a97930cb711ac72c8d6c7cf6c1bfa4e) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (2)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the maximum opacity of the popup notification when they are fully shown."), DefaultValue(0xff)]
        public int MaxOpacity
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c0a9f2665877fedae6969e5cf7333dcab;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c0a9f2665877fedae6969e5cf7333dcab = value;
            }
        }

        [Description("Gets or sets whether the close button is shown in the popup notification."), DefaultValue(typeof(bool), "true")]
        public bool ShowCloseButton
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c9c5f5755f62bf64ce1a09997e4733d01;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c9c5f5755f62bf64ce1a09997e4733d01 = value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (3)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets whether the options button is shown in the popup notification."), DefaultValue(typeof(bool), "false")]
        public bool ShowOptionsButton
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.cc76d3b0abd808ac711b27a63a842b049;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cc76d3b0abd808ac711b27a63a842b049 = value;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0020:
                switch (5)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [DefaultValue(typeof(SlideStyles), "Default"), Description("Gets or sets the slide style used for animating the popup notification.")]
        public SlideStyles SlideStyle
        {
            get
            {
                return (SlideStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.cf3d1dde94b28def2b3a26ed8e00e19a2;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cf3d1dde94b28def2b3a26ed8e00e19a2 = (ccac148b17289ee913ceb30d7568b56f6) value;
            }
        }

        public string SoundFile
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c463661962a82efdad8cb00770b367a7e;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c463661962a82efdad8cb00770b367a7e = value;
            }
        }

        [Description("Gets or sets the text color of the popup notification.")]
        public Color TextColor
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c937669d4fbd6d3a80021bf33634a73a4);
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c937669d4fbd6d3a80021bf33634a73a4 = ColorTranslator.ToWin32(value);
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0025:
                switch (7)
                {
                    case 0:
                        goto Label_0025;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the hot-state text color of the popup notification.")]
        public Color TextColorHot
        {
            get
            {
                return ColorTranslator.FromWin32(this.c98e7d52cc27af8bcd28ab44ffa041d39.c3f6c2fac4b3fd8c4f8770ef50e39ddef);
            }
            set
            {
                int num1 = ColorTranslator.ToWin32(value);
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c3f6c2fac4b3fd8c4f8770ef50e39ddef = num1;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle) != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the font name of the text of the popup notification.")]
        public string TextFontName
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c6745c8456ab574c11ca3592a537b6302;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c6745c8456ab574c11ca3592a537b6302 = value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (7)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the font size of the text of the popup notification.")]
        public int TextFontSize
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.ca6d796064a2d9543efd4164bfd2cac41;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.ca6d796064a2d9543efd4164bfd2cac41 = value;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0020:
                switch (7)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the font style of the text of the popup notification.")]
        public FontStyles TextFontStyle
        {
            get
            {
                return (FontStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.cf1cd307971926cd363dc66369191e348;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cf1cd307971926cd363dc66369191e348 = (c1c56fdf5e5786b07f40743d18cf96b34) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num1 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num1 != 0)
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                }
            }
        }

        [Description("Gets or sets the font style of the hot-state text of the popup notification.")]
        public FontStyles TextFontStyleHot
        {
            get
            {
                return (FontStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.c7b0392da2b8ed891b658b0ef01dcfb71;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c7b0392da2b8ed891b658b0ef01dcfb71 = (c1c56fdf5e5786b07f40743d18cf96b34) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                int num2 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle);
                if (num2 == 0)
                {
                    return;
                }
            Label_0022:
                switch (7)
                {
                    case 0:
                        goto Label_0022;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the horizontal alignment of the text of the popup notification.")]
        public HAlignments TextHAlign
        {
            get
            {
                return (HAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.c9ea90f5660eabaa13d87ce9f680bfd73;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c9ea90f5660eabaa13d87ce9f680bfd73 = (c09c345fe99aafe7ea8b53f49cb5f95ca) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0020:
                switch (7)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the text shown in the popup notification."), DefaultValue("LogicNP Software Shell Popup Notification")]
        public string TextString
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.c60d883365dbc8354eea92b78c4cc9fd4;
            }
            set
            {
                if ((value == null) || !value.StartsWith(c8501506cd6fad4aa5297d71ae6dcee33.cb13d2c289fefc007bfade9fec73cdc72))
                {
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c60d883365dbc8354eea92b78c4cc9fd4 = value;
                    int num4 = c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle);
                    if (num4 == 0)
                    {
                        return;
                    }
                Label_005F:
                    switch (3)
                    {
                        case 0:
                            goto Label_005F;
                    }
                    this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                    return;
                }
            Label_0012:
                switch (4)
                {
                    case 0:
                        goto Label_0012;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        int length = c8501506cd6fad4aa5297d71ae6dcee33.cb13d2c289fefc007bfade9fec73cdc72.Length;
                        string text2 = value.Substring(length);
                        c8501506cd6fad4aa5297d71ae6dcee33.c67f408f3d24307edeed3f50af3e50427 = text2;
                        return;
                    }
                }
            }
        }

        [Description("Gets or sets the vertical alignment of the text of the popup notification.")]
        public VAlignments TextVAlign
        {
            get
            {
                return (VAlignments) this.c98e7d52cc27af8bcd28ab44ffa041d39.c9bb9054523a9ab46d5f0caf6453f04be;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c9bb9054523a9ab46d5f0caf6453f04be = (c7a97930cb711ac72c8d6c7cf6c1bfa4e) value;
                IntPtr handle = this.c98e7d52cc27af8bcd28ab44ffa041d39.Handle;
                if (c1f3ac373189b87d6dcb629efcbe8286b.c0a564d568ac7a0bb2380eb95ca13129b(handle) == 0)
                {
                    return;
                }
            Label_0020:
                switch (3)
                {
                    case 0:
                        goto Label_0020;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.c98e7d52cc27af8bcd28ab44ffa041d39.c23c9d7daa93927b8e3a906503f8c6e24();
                        break;
                }
            }
        }

        [Description("Gets or sets the top position of the popup notification.")]
        public int Top
        {
            get
            {
                return this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cdf16ab70ba41859ef5776b06a470017c(this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba, value, this.c98e7d52cc27af8bcd28ab44ffa041d39.cb3ca8ee4b7018e3e9402fdd5d3dee04e - this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba, this.c98e7d52cc27af8bcd28ab44ffa041d39.cbf4e3ac714f18c91399c06995c80e3c0 - this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5);
            }
        }

        [Description("Gets or sets programmer defined data associated with the popup notification.")]
        public object UserData
        {
            get
            {
                return this.cd228fedb4b74b92989dfdfdfca521f04;
            }
            set
            {
                this.cd228fedb4b74b92989dfdfdfca521f04 = value;
            }
        }

        [DefaultValue(typeof(VisualStyles), "MSN"), Description("Gets or sets the visual style of the popup notification.")]
        public VisualStyles VisualStyle
        {
            get
            {
                return (VisualStyles) this.c98e7d52cc27af8bcd28ab44ffa041d39.c629bc760e2bf85cb6f4aec8ccf8f7ad9;
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.c970cc1c1daf057764ffd53f9f8f243bd((int) value);
            }
        }

        [Description("Gets or sets the width of the popup notification.")]
        public int Width
        {
            get
            {
                return (this.c98e7d52cc27af8bcd28ab44ffa041d39.cb3ca8ee4b7018e3e9402fdd5d3dee04e - this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba);
            }
            set
            {
                this.c98e7d52cc27af8bcd28ab44ffa041d39.cdf16ab70ba41859ef5776b06a470017c(this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba, this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5, this.c98e7d52cc27af8bcd28ab44ffa041d39.c2b9ac8053c25b1a2e32a1601650064ba + value, this.c98e7d52cc27af8bcd28ab44ffa041d39.cbf4e3ac714f18c91399c06995c80e3c0 - this.c98e7d52cc27af8bcd28ab44ffa041d39.ca0b40831ee9d4ab326240c076f1fc3b5);
            }
        }
    }
}

