namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Forms;
    using System.Windows.Input;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33)), Description("Convert your forms into Quick Launch-like appbars, with autohide, drag-docking and multi-monitor support.")]
    public class ShellAppBarWPF : FrameworkElement
    {
        private Window c177d222de4b5fba13162f367d8e89920;
        private c700686ae494d6e4aaca7ea3d75043121 c603b465a098194f78c6169b5cd744070 = new c700686ae494d6e4aaca7ea3d75043121();

        public event EventHandler AutoHideAppBarStateChanged
        {
            add
            {
                this.c603b465a098194f78c6169b5cd744070.ce36cbca74356975fd5fa9c1ac80c67dd += value;
            }
            remove
            {
                this.c603b465a098194f78c6169b5cd744070.ce36cbca74356975fd5fa9c1ac80c67dd -= value;
            }
        }

        public event EventHandler DockingEdgeChanged
        {
            add
            {
                this.c603b465a098194f78c6169b5cd744070.ca0af10c6a786fed590856df6903059d5 += value;
            }
            remove
            {
                this.c603b465a098194f78c6169b5cd744070.ca0af10c6a786fed590856df6903059d5 -= value;
            }
        }

        [Description("Convert your forms into Quick Launch-like appbars, with autohide, drag-docking and multi-monitor support.")]
        public ShellAppBarWPF()
        {
            System.Type type = typeof(ShellAppBarWPF);
            License license1 = LicenseManager.Validate(type, this);
            this.c603b465a098194f78c6169b5cd744070.cd62b893c99a3023307efab683c86a21b = false;
            base.Visibility = Visibility.Hidden;
        }

        private void c5be2e2fd531b845456bce64adf4fbcdb()
        {
            if (this.c177d222de4b5fba13162f367d8e89920 == null)
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
                    this.c603b465a098194f78c6169b5cd744070.c66f83f0a895513cebc3fe127524808af(IntPtr.Zero);
                    this.c177d222de4b5fba13162f367d8e89920.MouseDown -= new MouseButtonEventHandler(this.hostWindow_MouseDown);
                    break;
            }
        }

        private void c7d0cbbd420ad5b513b7242bda34d0efe()
        {
            WindowInteropHelper helper = new WindowInteropHelper(this.c177d222de4b5fba13162f367d8e89920);
            this.c603b465a098194f78c6169b5cd744070.c66f83f0a895513cebc3fe127524808af(helper.Handle);
            this.c177d222de4b5fba13162f367d8e89920.MouseDown += new MouseButtonEventHandler(this.hostWindow_MouseDown);
        }

        private void hostWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.c7d0cbbd420ad5b513b7242bda34d0efe();
        }

        private void hostWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.c603b465a098194f78c6169b5cd744070.ca7d6383dda8fe791ec80ed7c4df6b749();
        }

        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize)
        {
            return new System.Windows.Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x7a4);
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public void SetDockingEdgeAndScreen(DockingEdges edge, Screen screen)
        {
            this.c603b465a098194f78c6169b5cd744070.cc322a60a2ce74c637d5cb374e1ef8ade(edge, screen);
        }

        public void SetHostForm(IntPtr nNewValue)
        {
            this.c603b465a098194f78c6169b5cd744070.c66f83f0a895513cebc3fe127524808af(nNewValue);
        }

        public void StartDragDock()
        {
            this.c603b465a098194f78c6169b5cd744070.ca7d6383dda8fe791ec80ed7c4df6b749();
        }

        [DefaultValue(typeof(DragDockingEdges), "None"), Category("ShellAppBar Properties"), Description("Gets/Sets the allowed edges for drag-docking the application desktop toolbar")]
        public DragDockingEdges AllowedDragDockingEdges
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c93271ee0f29b830fb5757bd8cb76b5be;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c93271ee0f29b830fb5757bd8cb76b5be = value;
            }
        }

        [DefaultValue(typeof(bool), "false"), Description("Gets/Sets whether the application desktop toolbar can be resized by the user"), Category("ShellAppBar Properties")]
        public bool AllowResize
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c55ad45090aef60f1e5621845279c417e;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c55ad45090aef60f1e5621845279c417e = value;
            }
        }

        [Category("ShellAppBar Properties"), DefaultValue(typeof(bool), "true"), Description("Gets/Sets whether the application desktop toolbar will always remain on top of all other windows")]
        public bool AlwaysOnTop
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c1af76d5d2571b2647aa324ad85c90090;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c1af76d5d2571b2647aa324ad85c90090 = value;
            }
        }

        [DefaultValue(typeof(System.Drawing.Size), "2,2"), Category("ShellAppBar Properties"), Description("Gets/Sets how size of an appbar when it is auto-hidden")]
        public System.Drawing.Size AutoHiddenAppBarSize
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.cd1a134b7802961f334d18e5298701dfb;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.cd1a134b7802961f334d18e5298701dfb = value;
            }
        }

        [Description("Gets/Sets whether the application desktop toolbar is auto-hidden"), DefaultValue(typeof(bool), "false"), Category("ShellAppBar Properties")]
        public bool AutoHide
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c7ead3fccd698ebed3043080961bfe5d2;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c7ead3fccd698ebed3043080961bfe5d2 = value;
            }
        }

        [DefaultValue(typeof(AutoHideAppBarStates), "Visible"), Browsable(false), Description("Gets/Sets whether the application desktop toolbar is hidden or visible in AutoHide mode")]
        public AutoHideAppBarStates AutoHideAppBarState
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c3c3aa6012f4e07309409081f4b4699d3;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c3c3aa6012f4e07309409081f4b4699d3 = value;
            }
        }

        [DefaultValue(500), Category("ShellAppBar Properties")]
        public int AutoHideHideDelay
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c40cfac205d40180ed5281748b038af04;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c40cfac205d40180ed5281748b038af04 = value;
            }
        }

        [Category("ShellAppBar Properties"), Description("Gets/Sets whether the application desktop toolbar is pinned(always visible) when auto-hidden"), DefaultValue(typeof(bool), "false")]
        public bool AutoHidePinned
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.cadcc383101b7f45aa20016c3f7763cbe;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.cadcc383101b7f45aa20016c3f7763cbe = value;
            }
        }

        [Description("Gets/Sets the delay in milliseconds after which an auto-hidden appbar is brought into view"), DefaultValue(50), Category("ShellAppBar Properties")]
        public int AutoHideShowDelay
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c019e12fb39a5dcb5575db59695045e7d;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c019e12fb39a5dcb5575db59695045e7d = value;
            }
        }

        [Description("Gets/Sets the screen edge to which the application desktop toolbar will be docked"), DefaultValue(typeof(DockingEdges), "Left"), Category("ShellAppBar Properties")]
        public DockingEdges DockingEdge
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c3b684b20ac895b30556a9470dc149bb3;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c3b684b20ac895b30556a9470dc149bb3 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Category("ShellAppBar Properties"), Browsable(false), Description("Gets/Sets the screen to whose edges the application desktop toolbar will dock")]
        public Screen DockingScreen
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.cc37e6dc5a5acc50cf7d7cdc6a1f47407;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.cc37e6dc5a5acc50cf7d7cdc6a1f47407 = value;
            }
        }

        [DefaultValue(typeof(LogicNP.ShellObjects.HAnchor), "HAnchorStretch"), Description("Gets/Sets how the alignment of the appbar when docked to the top or bottom edges"), Category("ShellAppBar Properties")]
        public LogicNP.ShellObjects.HAnchor HAnchor
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c2af05ecd482a702ca54a688c2002fb97;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c2af05ecd482a702ca54a688c2002fb97 = value;
            }
        }

        [DefaultValue(400), Category("ShellAppBar Properties"), Description("Gets/Sets the animation time in milliseconds for a visible appbar to autohide (0 to disable animation)")]
        public int HideAnimTime
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.cf881b86119f367dbcc100692f46a0d0e;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.cf881b86119f367dbcc100692f46a0d0e = value;
            }
        }

        public Window HostWindow
        {
            get
            {
                return this.c177d222de4b5fba13162f367d8e89920;
            }
            set
            {
                if (this.c177d222de4b5fba13162f367d8e89920 != value)
                {
                    this.c5be2e2fd531b845456bce64adf4fbcdb();
                    this.c177d222de4b5fba13162f367d8e89920 = value;
                    if (this.c177d222de4b5fba13162f367d8e89920 == null)
                    {
                        return;
                    }
                Label_0032:
                    switch (5)
                    {
                        case 0:
                            goto Label_0032;

                        default:
                            if (this.c177d222de4b5fba13162f367d8e89920.IsLoaded)
                            {
                                this.c7d0cbbd420ad5b513b7242bda34d0efe();
                                return;
                            }
                            break;
                    }
                Label_004B:
                    switch (1)
                    {
                        case 0:
                            goto Label_004B;
                    }
                    this.c177d222de4b5fba13162f367d8e89920.Loaded += new RoutedEventHandler(this.hostWindow_Loaded);
                    return;
                }
            Label_0009:
                switch (4)
                {
                    case 0:
                        goto Label_0009;

                    default:
                        if (1 == 0)
                        {
                        }
                        return;
                }
            }
        }

        [Browsable(false), Description("Gets whether the application desktop toolbar is operating in AutoHide mode")]
        public bool IsAutoHidden
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c0c14276952fb2b14bd4c622912b04e1d;
            }
        }

        [Description("Gets/Sets the animation time in milliseconds for a autohidden appbar to show (0 to disable animation)"), DefaultValue(200), Category("ShellAppBar Properties")]
        public int ShowAnimTime
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c140ecffa75b95e45b529324f6973d522;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c140ecffa75b95e45b529324f6973d522 = value;
            }
        }

        [Category("ShellAppBar Properties"), Description("Gets/Sets how the alignment of the appbar when docked to the top or bottom edges"), DefaultValue(typeof(LogicNP.ShellObjects.VAnchor), "VAnchorStretch")]
        public LogicNP.ShellObjects.VAnchor VAnchor
        {
            get
            {
                return this.c603b465a098194f78c6169b5cd744070.c634b6e4e0cc0f8bd2d2fa3895269b078;
            }
            set
            {
                this.c603b465a098194f78c6169b5cd744070.c634b6e4e0cc0f8bd2d2fa3895269b078 = value;
            }
        }
    }
}

