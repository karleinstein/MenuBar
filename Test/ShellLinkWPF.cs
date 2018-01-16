namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Forms;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Create and manipulate shortcut (*.lnk) files."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class ShellLinkWPF : FrameworkElement
    {
        private c85504b07fb7e9d555bb5338f5354838c cb259ad8495469a216bcd069142388b35 = new c85504b07fb7e9d555bb5338f5354838c();

        [Description("Create and manipulate shortcut (*.lnk) files.")]
        public ShellLinkWPF()
        {
            System.Type type = typeof(ShellLinkWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public void Clear()
        {
            this.cb259ad8495469a216bcd069142388b35.c2b5010745e20f36cc83bab01241c842e();
        }

        public bool LoadFromFile(string lnkPath)
        {
            return this.cb259ad8495469a216bcd069142388b35.c4f310d2ebe6f2d9ba5952ce4cd597ae3(lnkPath);
        }

        public bool LoadFromFile(string lnkPath, ShellLinkLoadFlags loadFlags)
        {
            return this.cb259ad8495469a216bcd069142388b35.c4f310d2ebe6f2d9ba5952ce4cd597ae3(lnkPath, loadFlags);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void OnAbout(object sender, EventArgs e)
        {
            DialogResult result1 = new c2c6786a5ce1f088afd290d9bf5bef1c1(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1fa5)).ShowDialog();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void OnContact(object sender, EventArgs e)
        {
            string text1 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x321);
            cf6ad7aa942b6f1af1ed3ac2f2623b999.c41a7f4238062ba03e27ce6d348ce6706(text1);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void OnOpenHelp(object sender, EventArgs e)
        {
            string str = cf6ad7aa942b6f1af1ed3ac2f2623b999.c87417497760b5568002eb88bf0cd6004();
            if (str == null)
            {
                return;
            }
        Label_000B:
            switch (5)
            {
                case 0:
                    goto Label_000B;

                default:
                    if (1 == 0)
                    {
                    }
                    if (!(str == string.Empty))
                    {
                        string text5 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2696);
                        str = Path.Combine(str, text5);
                        cf6ad7aa942b6f1af1ed3ac2f2623b999.c381099134420fec4713ad8759f434cd0(str);
                        return;
                    }
                    break;
            }
        Label_002D:
            switch (6)
            {
                case 0:
                    goto Label_002D;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void OnOpenSamples(object sender, EventArgs e)
        {
            string str = cf6ad7aa942b6f1af1ed3ac2f2623b999.c87417497760b5568002eb88bf0cd6004();
            if (str == null)
            {
                return;
            }
        Label_000B:
            switch (5)
            {
                case 0:
                    goto Label_000B;

                default:
                    if (1 == 0)
                    {
                    }
                    if (!(str == string.Empty))
                    {
                        string text5 = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x214e);
                        str = Path.Combine(str, text5);
                        cf6ad7aa942b6f1af1ed3ac2f2623b999.c381099134420fec4713ad8759f434cd0(str);
                        return;
                    }
                    break;
            }
        Label_002D:
            switch (3)
            {
                case 0:
                    goto Label_002D;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void OnRegister(object sender, EventArgs e)
        {
            DialogResult result1 = new c5d3db49450d1fdf86202c4c6121dac8b().ShowDialog();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2641);
            Stream stream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void OnViewOrderInfo(object sender, EventArgs e)
        {
            cf6ad7aa942b6f1af1ed3ac2f2623b999.c41a7f4238062ba03e27ce6d348ce6706(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x4d6));
        }

        public bool SaveToFile(string lnkPath)
        {
            return this.cb259ad8495469a216bcd069142388b35.ce451e9020d3f27d45d85ebd55259f555(lnkPath);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets or sets the command-line arguments associated with the shell link.")]
        public string Arguments
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.cd3137588779a0a860c4aa34728c33d5d;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.cd3137588779a0a860c4aa34728c33d5d = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets the description for the shell link.")]
        public string Description
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c051eea98d495e45f9558f4c6e21d28df;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c051eea98d495e45f9558f4c6e21d28df = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets the hot key for the shell link.")]
        public LogicNP.ShellObjects.Hotkey Hotkey
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c4ff1fae4b1e0c0148dff756a3cb2af19;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c4ff1fae4b1e0c0148dff756a3cb2af19 = value;
            }
        }

        [Browsable(false), Description("Gets or sets the path of the icon for the shell link."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string IconFile
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c62b38bbdd6b5d02926704d6e5ac95eab;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c62b38bbdd6b5d02926704d6e5ac95eab = value;
            }
        }

        [Browsable(false), Description("Gets or sets the index of the icon in the icon file for the shell link."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IconIndex
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.ca5e13dc6235d88b6dd976840500825e2;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.ca5e13dc6235d88b6dd976840500825e2 = value;
            }
        }

        [Description("Gets or sets the fully qualified shell item identifier list for the target of the shell link."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IntPtr PIDL
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c3ff9d95138a7fb6fb80e7b1beb15c5d6;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c3ff9d95138a7fb6fb80e7b1beb15c5d6 = value;
            }
        }

        [Description("Gets or sets the show command for the shell link."), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LogicNP.ShellObjects.ShowCommand ShowCommand
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c83943cd643eab2c9e02a6ad7615e93e5;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c83943cd643eab2c9e02a6ad7615e93e5 = value;
            }
        }

        [Description("Gets or sets the full path of the target of the shell link."), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TargetPath
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c339a88dcf208691dfcbacbcfbf59ec49;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c339a88dcf208691dfcbacbcfbf59ec49 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets or sets the working directory for the shell link.")]
        public string WorkingDirectory
        {
            get
            {
                return this.cb259ad8495469a216bcd069142388b35.c42f26ee485f7ae7ef65ef16eee748816;
            }
            set
            {
                this.cb259ad8495469a216bcd069142388b35.c42f26ee485f7ae7ef65ef16eee748816 = value;
            }
        }
    }
}

