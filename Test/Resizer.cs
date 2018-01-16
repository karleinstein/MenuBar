namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows.Forms;

    [Designer("LogicNP.ShellObjects.Design.ShellLinkDesigner, LogicNP.ShellObjects.Design"), ProvideProperty("ResizerSettings", typeof(Control)), Description("Add automatic resizing and resolution independence to your forms.")]
    public class Resizer : Component, IExtenderProvider
    {
        internal double c1b3a2cfa804b6c224c7d96add98d5924;
        internal float c212fb0c987b10b58bd5ad28e5c083848;
        internal bool c26b2716da80af4d17377df9e739a6cb8;
        internal License c2c8c1d405b90c481b6f4d60ea9de18fd;
        private ControlResizeEventHandler c42434208166e256d5456d96bd591765b;
        internal Size c461ffd83a9e24e2033e0134079451fc6;
        internal Size c54ef7d55fa032392c212a7072aafad25;
        private FormSettings c67f362df8362cc0d636d3a3a82e270b8;
        internal double ca2c8e8ca465a003d3ba5e1a59b9a0cae;
        internal Hashtable ca94f633701e3d87b874b2ac1b07619aa;
        internal double cba12be90625ab675d5d106a3fad8e441;
        internal Control cbed110561744aa3644e690d049e61bf6;
        internal double cc5dde2ecb98aba24816981c499c8a9bf;
        internal bool cd0f0c0712a4c6094ae7df37295756330;
        private EventHandler cd7d42f151a83f3f036fa570079acffb7;
        internal float ce57a1f6c17313c6239d748e38dc22262;

        [Browsable(true)]
        public event ControlResizeEventHandler ControlResize
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.c42434208166e256d5456d96bd591765b, value);
                this.c42434208166e256d5456d96bd591765b = (ControlResizeEventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                Delegate delegate1 = Delegate.Remove(this.c42434208166e256d5456d96bd591765b, value);
                this.c42434208166e256d5456d96bd591765b = (ControlResizeEventHandler) delegate1;
            }
        }

        public event EventHandler ResizeComplete
        {
            [MethodImpl(MethodImplOptions.Synchronized)] add
            {
                Delegate delegate1 = Delegate.Combine(this.cd7d42f151a83f3f036fa570079acffb7, value);
                this.cd7d42f151a83f3f036fa570079acffb7 = (EventHandler) delegate1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)] remove
            {
                this.cd7d42f151a83f3f036fa570079acffb7 = (EventHandler) Delegate.Remove(this.cd7d42f151a83f3f036fa570079acffb7, value);
            }
        }

        public Resizer()
        {
            this.cc5dde2ecb98aba24816981c499c8a9bf = 1.0;
            this.cba12be90625ab675d5d106a3fad8e441 = 1.0;
            this.c212fb0c987b10b58bd5ad28e5c083848 = 1f;
            this.ca94f633701e3d87b874b2ac1b07619aa = new Hashtable();
            this.cd0f0c0712a4c6094ae7df37295756330 = false;
            this.Enabled = true;
        }

        public Resizer(IContainer container) : this()
        {
            container.Add(this);
        }

        internal static bool c0409ed75b1030f8f574ff78ed515d2fc(FormSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & (FormSettings.SaveSize | FormSettings.SavePosition)) != FormSettings.None);
        }

        internal Control c0c96e9d6e8b2ab90c7957835bd19428f()
        {
            Control control = null;
            IDesignerHost host;
            if (!base.DesignMode)
            {
                return control;
            }
        Label_000C:
            switch (7)
            {
                case 0:
                    goto Label_000C;

                default:
                    if (1 == 0)
                    {
                    }
                    if (this.Site == null)
                    {
                        return control;
                    }
                    break;
            }
        Label_0029:
            switch (4)
            {
                case 0:
                    goto Label_0029;

                default:
                {
                    object service = this.Site.GetService(typeof(IDesignerHost));
                    host = (IDesignerHost) service;
                    if (host == null)
                    {
                        return control;
                    }
                    break;
                }
            }
        Label_0055:
            switch (5)
            {
                case 0:
                    goto Label_0055;
            }
            IComponent rootComponent = host.RootComponent;
            return (rootComponent as Control);
        }

        internal static bool c14bc6b043cbb2a4aed03031d246a2bbd(FormSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & FormSettings.SavePosition) != FormSettings.None);
        }

        internal void c1cf26777e05549d47c739e9f92096493(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            if (!this.c26b2716da80af4d17377df9e739a6cb8)
            {
                return;
            }
        Label_000B:
            switch (2)
            {
                case 0:
                    goto Label_000B;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int height = this.cbed110561744aa3644e690d049e61bf6.ClientSize.Height;
                    Size size2 = this.cbed110561744aa3644e690d049e61bf6.ClientSize;
                    int width = size2.Width;
                    if (!((height != 0) & (width != 0)))
                    {
                        return;
                    }
                    Size size3 = this.cbed110561744aa3644e690d049e61bf6.ClientSize;
                    int num9 = size3.Height;
                    int num10 = this.c461ffd83a9e24e2033e0134079451fc6.Height;
                    this.ca2c8e8ca465a003d3ba5e1a59b9a0cae = ((double) num9) / ((double) num10);
                    Size size4 = this.cbed110561744aa3644e690d049e61bf6.ClientSize;
                    int num11 = size4.Width;
                    int num12 = this.c461ffd83a9e24e2033e0134079451fc6.Width;
                    this.c1b3a2cfa804b6c224c7d96add98d5924 = ((double) num11) / ((double) num12);
                    this.ce57a1f6c17313c6239d748e38dc22262 = (float) Math.Min(this.ca2c8e8ca465a003d3ba5e1a59b9a0cae, this.c1b3a2cfa804b6c224c7d96add98d5924);
                    this.cb877c343a04f6cbb1998a5d0e8d44c4a(this.cbed110561744aa3644e690d049e61bf6);
                    if (!this.cd0f0c0712a4c6094ae7df37295756330)
                    {
                        this.cc5dde2ecb98aba24816981c499c8a9bf = 1.0;
                        this.cba12be90625ab675d5d106a3fad8e441 = 1.0;
                        this.c212fb0c987b10b58bd5ad28e5c083848 = 1f;
                        return;
                    }
                    break;
                }
            }
        Label_00E2:
            switch (1)
            {
                case 0:
                    goto Label_00E2;

                default:
                    this.cc5dde2ecb98aba24816981c499c8a9bf = this.ca2c8e8ca465a003d3ba5e1a59b9a0cae;
                    this.cba12be90625ab675d5d106a3fad8e441 = this.c1b3a2cfa804b6c224c7d96add98d5924;
                    this.c212fb0c987b10b58bd5ad28e5c083848 = this.ce57a1f6c17313c6239d748e38dc22262;
                    return;
            }
        }

        internal void c355922c79b2c589e21c73eb08c3b14eb(object c32c3d50ef5725e6c8f1a2ea14bb42003, EventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            int num;
            int num2;
            int num3;
            int num4;
            if (!(this.cbed110561744aa3644e690d049e61bf6 is Form))
            {
                return;
            }
        Label_0010:
            switch (5)
            {
                case 0:
                    goto Label_0010;

                default:
                    if (1 == 0)
                    {
                    }
                    num = -2147483648;
                    num2 = -2147483648;
                    num3 = -2147483648;
                    num4 = -2147483648;
                    if (!c0409ed75b1030f8f574ff78ed515d2fc(this.c67f362df8362cc0d636d3a3a82e270b8))
                    {
                        goto Label_00A5;
                    }
                    break;
            }
        Label_004A:
            switch (3)
            {
                case 0:
                    goto Label_004A;

                default:
                {
                    string text2 = this.cbf5c067705820c7821975fb1fbfae837();
                    string[] strArray = text2.Split(new char[] { ',' });
                    num = int.Parse(strArray[0]);
                    num2 = int.Parse(strArray[1]);
                    num3 = int.Parse(strArray[2]);
                    num4 = int.Parse(strArray[3]);
                    break;
                }
            }
        Label_00A5:
            if (num != -2147483648)
            {
                goto Label_00C5;
            }
        Label_00AD:
            switch (1)
            {
                case 0:
                    goto Label_00AD;

                default:
                    num = this.cbed110561744aa3644e690d049e61bf6.Left;
                    break;
            }
        Label_00C5:
            if (num2 != -2147483648)
            {
                goto Label_00E5;
            }
        Label_00CD:
            switch (5)
            {
                case 0:
                    goto Label_00CD;

                default:
                    num2 = this.cbed110561744aa3644e690d049e61bf6.Top;
                    break;
            }
        Label_00E5:
            if (num3 != -2147483648)
            {
                goto Label_0105;
            }
        Label_00ED:
            switch (2)
            {
                case 0:
                    goto Label_00ED;

                default:
                    num3 = this.cbed110561744aa3644e690d049e61bf6.Width;
                    break;
            }
        Label_0105:
            if (num4 != -2147483648)
            {
                goto Label_0125;
            }
        Label_010D:
            switch (6)
            {
                case 0:
                    goto Label_010D;

                default:
                    num4 = this.cbed110561744aa3644e690d049e61bf6.Height;
                    break;
            }
        Label_0125:
            if (c14bc6b043cbb2a4aed03031d246a2bbd(this.c67f362df8362cc0d636d3a3a82e270b8))
            {
                this.cbed110561744aa3644e690d049e61bf6.Left = num;
                this.cbed110561744aa3644e690d049e61bf6.Top = num2;
            }
            if (c3d0fa4e1320bff44c04a60916b331392(this.c67f362df8362cc0d636d3a3a82e270b8))
            {
                Screen primaryScreen = Screen.PrimaryScreen;
                Rectangle rectangle = primaryScreen.Bounds;
                Size size = rectangle.Size;
                int num23 = size.Width;
                int num24 = this.c54ef7d55fa032392c212a7072aafad25.Width;
                float num5 = ((float) num23) / ((float) num24);
                int num25 = size.Height;
                int num26 = this.c54ef7d55fa032392c212a7072aafad25.Height;
                float num6 = ((float) num25) / ((float) num26);
                if (!c9a8efef3c9948062a0d5b521b7b50a2d(this.c67f362df8362cc0d636d3a3a82e270b8))
                {
                    int num27 = this.c461ffd83a9e24e2033e0134079451fc6.Height;
                    num4 = (int) (num27 * num6);
                    num3 = (int) (this.c461ffd83a9e24e2033e0134079451fc6.Width * num5);
                }
            }
            if (c3d0fa4e1320bff44c04a60916b331392(this.c67f362df8362cc0d636d3a3a82e270b8))
            {
                goto Label_0212;
            }
        Label_01EF:
            switch (6)
            {
                case 0:
                    goto Label_01EF;

                default:
                    if (!c9a8efef3c9948062a0d5b521b7b50a2d(this.c67f362df8362cc0d636d3a3a82e270b8))
                    {
                        return;
                    }
                    break;
            }
        Label_0208:
            switch (4)
            {
                case 0:
                    goto Label_0208;
            }
        Label_0212:
            this.cbed110561744aa3644e690d049e61bf6.ClientSize = new Size(num3, num4);
        }

        internal static bool c3d0fa4e1320bff44c04a60916b331392(FormSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & FormSettings.ResizeOnResolutionChange) != FormSettings.None);
        }

        private void c8900435c31ed1665377f4e2dfb3c30aa(object c32c3d50ef5725e6c8f1a2ea14bb42003, CancelEventArgs c2bba0636d27ec9b98b39d7d3d3d4f2c9)
        {
            string str = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            System.Type type = c32c3d50ef5725e6c8f1a2ea14bb42003.GetType();
            string path = Path.Combine(str, type.FullName + c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x12b));
            StreamWriter writer = File.CreateText(path);
            string str2 = this.caf116bdb2ac6a23480144beefd37fd16();
            writer.Write(str2);
            writer.Close();
        }

        internal static bool c9a8efef3c9948062a0d5b521b7b50a2d(FormSettings c26cecf4775971b3dcd61f354863296df)
        {
            return ((c26cecf4775971b3dcd61f354863296df & FormSettings.SaveSize) != FormSettings.None);
        }

        internal ResizerSettings ca6570eafeb380d3779146bd278737e72(Control c92ec88d675c52bc1fd9422d4e4032352)
        {
            ResizerSettings settings = null;
            object obj2 = this.ca94f633701e3d87b874b2ac1b07619aa[c92ec88d675c52bc1fd9422d4e4032352];
            settings = obj2 as ResizerSettings;
            if (settings != null)
            {
                return settings;
            }
        Label_0019:
            switch (2)
            {
                case 0:
                    goto Label_0019;
            }
            if (1 == 0)
            {
            }
            settings = new ResizerSettings(this, c92ec88d675c52bc1fd9422d4e4032352);
            this.ca94f633701e3d87b874b2ac1b07619aa[c92ec88d675c52bc1fd9422d4e4032352] = settings;
            return settings;
        }

        internal string caf116bdb2ac6a23480144beefd37fd16()
        {
            StringBuilder builder = new StringBuilder(100);
            int left = this.cbed110561744aa3644e690d049e61bf6.Left;
            builder.Append(left);
            StringBuilder builder1 = builder.Append(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x14e));
            int top = this.cbed110561744aa3644e690d049e61bf6.Top;
            builder.Append(top);
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x14e);
            builder.Append(text1);
            Size size = this.cbed110561744aa3644e690d049e61bf6.ClientSize;
            int width = size.Width;
            StringBuilder builder2 = builder.Append(width);
            StringBuilder builder3 = builder.Append(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x14e));
            Size size2 = this.cbed110561744aa3644e690d049e61bf6.ClientSize;
            int height = size2.Height;
            StringBuilder builder4 = builder.Append(height);
            return builder.ToString();
        }

        public bool CanExtend(object extendee)
        {
            if (!(extendee is Control))
            {
                return false;
            }
        Label_0008:
            switch (6)
            {
                case 0:
                    goto Label_0008;
            }
            if (1 == 0)
            {
            }
            return !(extendee is Form);
        }

        internal void cb877c343a04f6cbb1998a5d0e8d44c4a(Control c92ec88d675c52bc1fd9422d4e4032352)
        {
            IEnumerator enumerator = c92ec88d675c52bc1fd9422d4e4032352.Controls.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    object current = enumerator.Current;
                    Control control = (Control) current;
                    this.cd0f0c0712a4c6094ae7df37295756330 = true;
                    if (control is MdiClient)
                    {
                        continue;
                    }
                Label_002F:
                    switch (1)
                    {
                        case 0:
                            goto Label_002F;
                    }
                    if (1 == 0)
                    {
                    }
                    ResizerSettings settings = this.ca6570eafeb380d3779146bd278737e72(control);
                    settings.c30291f00ac534ce920cf0179a9b57aa8();
                    settings.ccef4e49327327d2fb4ba685c83816060();
                    settings.c1b9178604090d5221df9c979f066d0a1();
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable == null)
                {
                    goto Label_0084;
                }
            Label_0074:
                switch (7)
                {
                    case 0:
                        goto Label_0074;

                    default:
                        disposable.Dispose();
                        break;
                }
            Label_0084:;
            }
        }

        internal string cbf5c067705820c7821975fb1fbfae837()
        {
            string str = null;
            try
            {
                System.Type type = this.cbed110561744aa3644e690d049e61bf6.GetType();
                string text9 = type.FullName + c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x12b);
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), text9);
                if (!File.Exists(path))
                {
                    goto Label_0070;
                }
            Label_0040:
                switch (3)
                {
                    case 0:
                        goto Label_0040;
                }
                if (1 == 0)
                {
                }
                StreamReader reader = File.OpenText(path);
                str = reader.ReadLine();
                reader.Close();
            }
            catch
            {
            }
        Label_0070:
            if (str != null)
            {
                return str;
            }
        Label_0076:
            switch (4)
            {
                case 0:
                    goto Label_0076;
            }
            string[] strArray = new string[7];
            string text12 = -2147483648.ToString();
            strArray[0] = text12;
            string text13 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x14e);
            strArray[1] = text13;
            string text14 = -2147483648.ToString();
            strArray[2] = text14;
            string text15 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x14e);
            strArray[3] = text15;
            string text16 = -2147483648.ToString();
            strArray[4] = text16;
            strArray[5] = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x14e);
            strArray[6] = -2147483648.ToString();
            return string.Concat(strArray);
        }

        protected override void Dispose(bool disposing)
        {
            if (this.c2c8c1d405b90c481b6f4d60ea9de18fd == null)
            {
                goto Label_002D;
            }
        Label_0008:
            switch (1)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c2c8c1d405b90c481b6f4d60ea9de18fd.Dispose();
                    this.c2c8c1d405b90c481b6f4d60ea9de18fd = null;
                    break;
            }
        Label_002D:
            base.Dispose(disposing);
        }

        public ResizerSettings GetResizerSettings(Control control)
        {
            return this.ca6570eafeb380d3779146bd278737e72(control);
        }

        protected internal virtual void OnControlResize(ControlResizeEventArgs e)
        {
            if (this.c42434208166e256d5456d96bd591765b == null)
            {
                return;
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
                    this.c42434208166e256d5456d96bd591765b(this, e);
                    break;
            }
        }

        protected internal virtual void OnResizeComplete(EventArgs e)
        {
            if (this.cd7d42f151a83f3f036fa570079acffb7 == null)
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
                    this.cd7d42f151a83f3f036fa570079acffb7(this, e);
                    break;
            }
        }

        public void ResetResizerSettings(Control control)
        {
            this.ca6570eafeb380d3779146bd278737e72(control).cdea8e251fb8b9e76f808d81e27175ebb();
        }

        public void SetResizerSettings(Control control, ResizerSettings resizerSettings)
        {
            resizerSettings.c92ec88d675c52bc1fd9422d4e4032352 = control;
            resizerSettings.c6e1168351c09e3079747e64fef1d930c = this;
            this.ca94f633701e3d87b874b2ac1b07619aa[control] = resizerSettings;
        }

        public bool ShouldSerializeResizerSettings(Control control)
        {
            return this.ca6570eafeb380d3779146bd278737e72(control).c53e5e0832fb83636ff0dda6ff8211b95();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public float CurrentFontScale
        {
            get
            {
                return this.ce57a1f6c17313c6239d748e38dc22262;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double CurrentXScale
        {
            get
            {
                return this.c1b3a2cfa804b6c224c7d96add98d5924;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double CurrentYScale
        {
            get
            {
                return this.ca2c8e8ca465a003d3ba5e1a59b9a0cae;
            }
        }

        [Browsable(false)]
        public Size DesignTimeResolution
        {
            get
            {
                Rectangle rectangle = Screen.PrimaryScreen.Bounds;
                return rectangle.Size;
            }
            set
            {
                this.c54ef7d55fa032392c212a7072aafad25 = value;
            }
        }

        [DefaultValue(true)]
        public bool Enabled
        {
            get
            {
                return this.c26b2716da80af4d17377df9e739a6cb8;
            }
            set
            {
                if (base.DesignMode)
                {
                    goto Label_0088;
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
                        if (!value)
                        {
                            this.cc5dde2ecb98aba24816981c499c8a9bf = 1.0;
                            this.cba12be90625ab675d5d106a3fad8e441 = 1.0;
                            this.c212fb0c987b10b58bd5ad28e5c083848 = 1f;
                            this.ca94f633701e3d87b874b2ac1b07619aa.Clear();
                            goto Label_0088;
                        }
                        break;
                }
            Label_0023:
                switch (5)
                {
                    case 0:
                        goto Label_0023;

                    default:
                        if (this.cbed110561744aa3644e690d049e61bf6 == null)
                        {
                            goto Label_0088;
                        }
                        break;
                }
            Label_0035:
                switch (7)
                {
                    case 0:
                        goto Label_0035;

                    default:
                    {
                        Size clientSize = this.cbed110561744aa3644e690d049e61bf6.ClientSize;
                        this.c461ffd83a9e24e2033e0134079451fc6 = clientSize;
                        break;
                    }
                }
            Label_0088:
                this.c26b2716da80af4d17377df9e739a6cb8 = value;
            }
        }

        [Browsable(false)]
        public Control HostControl
        {
            get
            {
                if (!base.DesignMode)
                {
                    goto Label_0029;
                }
            Label_000A:
                switch (6)
                {
                    case 0:
                        goto Label_000A;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.cbed110561744aa3644e690d049e61bf6 = this.c0c96e9d6e8b2ab90c7957835bd19428f();
                        break;
                }
            Label_0029:
                return this.cbed110561744aa3644e690d049e61bf6;
            }
            set
            {
                Form form;
                if (this.cbed110561744aa3644e690d049e61bf6 != null)
                {
                    return;
                }
            Label_000B:
                switch (1)
                {
                    case 0:
                        goto Label_000B;

                    default:
                        if (1 == 0)
                        {
                        }
                        this.cbed110561744aa3644e690d049e61bf6 = value;
                        this.cbed110561744aa3644e690d049e61bf6.Resize += new EventHandler(this.c1cf26777e05549d47c739e9f92096493);
                        if (!(this.cbed110561744aa3644e690d049e61bf6 is Form))
                        {
                            return;
                        }
                        ((Form) this.cbed110561744aa3644e690d049e61bf6).Load += new EventHandler(this.c355922c79b2c589e21c73eb08c3b14eb);
                        form = this.cbed110561744aa3644e690d049e61bf6 as Form;
                        if (form == null)
                        {
                            return;
                        }
                        break;
                }
            Label_0074:
                switch (2)
                {
                    case 0:
                        goto Label_0074;

                    default:
                        form.Closing += new CancelEventHandler(this.c8900435c31ed1665377f4e2dfb3c30aa);
                        break;
                }
            }
        }

        [Browsable(false)]
        public Size HostControlStartSize
        {
            get
            {
                Control control = this.c0c96e9d6e8b2ab90c7957835bd19428f();
                if (control == null)
                {
                    goto Label_002D;
                }
            Label_000C:
                switch (7)
                {
                    case 0:
                        goto Label_000C;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        Size clientSize = control.ClientSize;
                        this.c461ffd83a9e24e2033e0134079451fc6 = clientSize;
                        break;
                    }
                }
            Label_002D:
                return this.c461ffd83a9e24e2033e0134079451fc6;
            }
            set
            {
                if (this.c461ffd83a9e24e2033e0134079451fc6.IsEmpty)
                {
                    this.c461ffd83a9e24e2033e0134079451fc6 = value;
                }
            }
        }

        [DefaultValue(typeof(FormSettings), "None")]
        public FormSettings HostFormSettings
        {
            get
            {
                return this.c67f362df8362cc0d636d3a3a82e270b8;
            }
            set
            {
                this.c67f362df8362cc0d636d3a3a82e270b8 = value;
            }
        }
    }
}

