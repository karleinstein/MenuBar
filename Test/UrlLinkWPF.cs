namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Create and manipulate internet shortcut (*.url) files."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class UrlLinkWPF : FrameworkElement
    {
        private cdacbee594c5de4b83734b3f315e4d66e cde7bc4a47ca41c4e3de710ba93c0f69d = new cdacbee594c5de4b83734b3f315e4d66e();

        public UrlLinkWPF()
        {
            Type type = typeof(UrlLinkWPF);
            LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public void Clear()
        {
            this.cde7bc4a47ca41c4e3de710ba93c0f69d.c2b5010745e20f36cc83bab01241c842e();
        }

        public bool LoadFromFile(string lnkPath)
        {
            return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c4f310d2ebe6f2d9ba5952ce4cd597ae3(lnkPath);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x27a2);
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public bool SaveToFile(string lnkPath)
        {
            return this.cde7bc4a47ca41c4e3de710ba93c0f69d.ce451e9020d3f27d45d85ebd55259f555(lnkPath);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets the author of the url link."), Browsable(false)]
        public string Author
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.cbba612a79f210f289e8a9b9fcabb6b3d;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets comments associated with the url link."), Browsable(false)]
        public string Comments
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c155fd4b6e9cbdc3ffa9529889eec7f39;
            }
        }

        [Description("Gets or sets the description for the url link."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public string Description
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c051eea98d495e45f9558f4c6e21d28df;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.c051eea98d495e45f9558f4c6e21d28df = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets or sets the hot key for the url link.")]
        public LogicNP.ShellObjects.Hotkey Hotkey
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c4ff1fae4b1e0c0148dff756a3cb2af19;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.c4ff1fae4b1e0c0148dff756a3cb2af19 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets the path of the icon for the url link."), Browsable(false)]
        public string IconFile
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c62b38bbdd6b5d02926704d6e5ac95eab;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.c62b38bbdd6b5d02926704d6e5ac95eab = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets or sets the index of the icon in the icon file for the url link.")]
        public int IconIndex
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.ca5e13dc6235d88b6dd976840500825e2;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.ca5e13dc6235d88b6dd976840500825e2 = value;
            }
        }

        [Description("Gets or sets the show command for the url link."), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LogicNP.ShellObjects.ShowCommand ShowCommand
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c83943cd643eab2c9e02a6ad7615e93e5;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.c83943cd643eab2c9e02a6ad7615e93e5 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets the url that the url link points to."), Browsable(false)]
        public string Url
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.cc6c1c3c108acd87ad0ea8d648947b300;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.cc6c1c3c108acd87ad0ea8d648947b300 = value;
            }
        }

        [Description("Gets or sets the WhatsNew text for the url link."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public string WhatsNew
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c21ec8bc0581947ef5816bb852431cc7f;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), Description("Gets or sets the working directory for the url link.")]
        public string WorkingDirectory
        {
            get
            {
                return this.cde7bc4a47ca41c4e3de710ba93c0f69d.c42f26ee485f7ae7ef65ef16eee748816;
            }
            set
            {
                this.cde7bc4a47ca41c4e3de710ba93c0f69d.c42f26ee485f7ae7ef65ef16eee748816 = value;
            }
        }
    }
}

