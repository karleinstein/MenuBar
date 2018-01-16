namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Forms;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Add animated system tray icons with XP balloon styles."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class ShellNotifyIconWPF : FrameworkElement
    {
        private Window c177d222de4b5fba13162f367d8e89920;
        private c9feff348729e8410c02baff0b324ecd0 cf9d173e30a8408a1186a10095afcf215 = new c9feff348729e8410c02baff0b324ecd0();

        public event EventHandler BalloonHide
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c35935545be7dd1def08bae3757b987f9 += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c35935545be7dd1def08bae3757b987f9 -= value;
            }
        }

        public event EventHandler BalloonHideTimeout
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c5ca77a0c804b2f15a111f1bb7f300e71 += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c5ca77a0c804b2f15a111f1bb7f300e71 -= value;
            }
        }

        public event EventHandler BalloonShow
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c8500e0abc96198df2f0d2cf90916c1ca += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c8500e0abc96198df2f0d2cf90916c1ca -= value;
            }
        }

        public event EventHandler BalloonUserClick
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.cea24fdc7e8be7da3a8e05137c22d8e5a += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.cea24fdc7e8be7da3a8e05137c22d8e5a -= value;
            }
        }

        public event EventHandler Click
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c79d189bbe0bc76a92bac46efff0cd2f7 += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c79d189bbe0bc76a92bac46efff0cd2f7 -= value;
            }
        }

        public event ContextMenuItemEventHandler ContextMenuItemSelect
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c7e81ee978c75e5ea366a521aa3772c23 += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c7e81ee978c75e5ea366a521aa3772c23 -= value;
            }
        }

        public event ContextMenuEventHandler ContextMenuPopup
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c169886752dfeac9efc4e8fef9209ac6e += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c169886752dfeac9efc4e8fef9209ac6e -= value;
            }
        }

        public event EventHandler DoubleClick
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c088ab32943d233ee9f203b56b218acbb += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c088ab32943d233ee9f203b56b218acbb -= value;
            }
        }

        public event MouseEventHandler MouseDown
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c3e9fce08aea72fc8f20909a9b5740d65 += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c3e9fce08aea72fc8f20909a9b5740d65 -= value;
            }
        }

        public event MouseEventHandler MouseMove
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.c5372488ecc0ee5982ccdd2ad0fc2e55b += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.c5372488ecc0ee5982ccdd2ad0fc2e55b -= value;
            }
        }

        public event MouseEventHandler MouseUp
        {
            add
            {
                this.cf9d173e30a8408a1186a10095afcf215.ca2fc7dd3008742530fda8571b04a827c += value;
            }
            remove
            {
                this.cf9d173e30a8408a1186a10095afcf215.ca2fc7dd3008742530fda8571b04a827c -= value;
            }
        }

        [Description("Add animated system tray icons with XP balloon styles.")]
        public ShellNotifyIconWPF()
        {
            System.Type type = typeof(ShellNotifyIconWPF);
            LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void BeginInit()
        {
            this.cf9d173e30a8408a1186a10095afcf215.BeginInit();
        }

        private void c5be2e2fd531b845456bce64adf4fbcdb()
        {
            if (this.c177d222de4b5fba13162f367d8e89920 == null)
            {
                return;
            }
        Label_0008:
            switch (2)
            {
                case 0:
                    goto Label_0008;

                default:
                    if (1 == 0)
                    {
                    }
                    this.c177d222de4b5fba13162f367d8e89920.Closed -= new EventHandler(this.hostWindow_Closed);
                    this.cf9d173e30a8408a1186a10095afcf215.cbd845fffa99d4a187760c331bee94c5f();
                    break;
            }
        }

        private void c7d0cbbd420ad5b513b7242bda34d0efe()
        {
            if (this.cf9d173e30a8408a1186a10095afcf215.c5e2047baaec066c01e59b42f7dc3642a)
            {
                this.cf9d173e30a8408a1186a10095afcf215.cca5c5131ff5751053c5c296e97a1967f();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void EndInit()
        {
            this.cf9d173e30a8408a1186a10095afcf215.EndInit();
        }

        private void hostWindow_Closed(object sender, EventArgs e)
        {
            if (this.c177d222de4b5fba13162f367d8e89920 != null)
            {
                this.cf9d173e30a8408a1186a10095afcf215.cbd845fffa99d4a187760c331bee94c5f();
                return;
            }
        Label_0008:
            switch (2)
            {
                case 0:
                    goto Label_0008;
            }
            if (1 == 0)
            {
            }
        }

        private void hostWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.c7d0cbbd420ad5b513b7242bda34d0efe();
        }

        public void InvokeContextMenu()
        {
            this.cf9d173e30a8408a1186a10095afcf215.cb8673703b3c86a9a49e2f0c8321385c9();
        }

        public void MaximizeFromTray(FormAnimStyles formAnimStyle)
        {
            if (this.c177d222de4b5fba13162f367d8e89920 != null)
            {
                this.MaximizeFromTray(this.c177d222de4b5fba13162f367d8e89920, formAnimStyle);
            }
        }

        public void MaximizeFromTray(Window window, FormAnimStyles formAnimStyle)
        {
            if (this.cf9d173e30a8408a1186a10095afcf215.c84fb2221a7dab5528de72f7aca224af9.Count != 0)
            {
                WindowInteropHelper helper = new WindowInteropHelper(window);
                IntPtr handle = helper.Handle;
                this.cf9d173e30a8408a1186a10095afcf215.cdc35d70e17751af2efa214cac1c0db12(handle, formAnimStyle);
                return;
            }
        Label_0014:
            switch (6)
            {
                case 0:
                    goto Label_0014;
            }
            if (1 == 0)
            {
            }
            string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x718);
            throw new InvalidOperationException(message);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        public void MinimizeToTray(FormAnimStyles formAnimStyle)
        {
            if (this.c177d222de4b5fba13162f367d8e89920 != null)
            {
                this.MinimizeToTray(this.c177d222de4b5fba13162f367d8e89920, formAnimStyle);
            }
        }

        public void MinimizeToTray(Window window, FormAnimStyles formAnimStyle)
        {
            if (this.cf9d173e30a8408a1186a10095afcf215.c84fb2221a7dab5528de72f7aca224af9.Count != 0)
            {
                WindowInteropHelper helper = new WindowInteropHelper(window);
                this.cf9d173e30a8408a1186a10095afcf215.c55c84ab54e4fab7257a8112d4cbf11ff(helper.Handle, formAnimStyle);
                return;
            }
        Label_0014:
            switch (1)
            {
                case 0:
                    goto Label_0014;
            }
            if (1 == 0)
            {
            }
            throw new InvalidOperationException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x718));
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xfb4);
            Stream stream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        [Description("Gets or sets whether animation is used for the tray icon."), DefaultValue(typeof(bool), "false"), Category("ShellNotifyIcon Properties")]
        public bool Animate
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.c29e27b28fb418db9719963b0aee2b4cd;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.c29e27b28fb418db9719963b0aee2b4cd = value;
            }
        }

        [Category("ShellNotifyIcon Properties"), Description("Gets or sets the time duration between successive icons when animation is turned on."), DefaultValue(50)]
        public int AnimDelay
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.c15b357ebe3f82b2a86df8566c87bf4eb;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.c15b357ebe3f82b2a86df8566c87bf4eb = value;
            }
        }

        [Description("Gets or sets the time duration between successive runs of animations of the tray icon."), Category("ShellNotifyIcon Properties"), DefaultValue(500)]
        public int AnimInterval
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.cb40edba696f474002b4a10139d584c61;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.cb40edba696f474002b4a10139d584c61 = value;
            }
        }

        [Category("ShellNotifyIcon Properties"), DefaultValue(3), Description("Gets or sets the number of times that the animation is repeated.")]
        public int AnimRepeatCount
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.cc1bbdc9725d51b690e151cbc85bd3438;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.cc1bbdc9725d51b690e151cbc85bd3438 = value;
            }
        }

        [Description("Gets or sets whether the tray icon is shown using the balloon style."), DefaultValue(typeof(bool), "false"), Category("ShellNotifyIcon Properties")]
        public bool BalloonStyle
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.ccd4df6002285bf862825d6fcb23ed02f;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.ccd4df6002285bf862825d6fcb23ed02f = value;
            }
        }

        [Description("Gets or sets the text shown in the balloon."), Category("ShellNotifyIcon Properties"), DefaultValue("Balloon Text")]
        public string BalloonText
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.cb0a23c35ebfa7d421f887c1e54b63774;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.cb0a23c35ebfa7d421f887c1e54b63774 = value;
            }
        }

        [Description("Gets or sets the time duration for which the balloon associated with the tray icon is displayed."), Category("ShellNotifyIcon Properties"), DefaultValue(0x7530)]
        public int BalloonTimeout
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.c477cbc5b9f74d576dff7850024c4447e;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.c477cbc5b9f74d576dff7850024c4447e = value;
            }
        }

        [Description("Gets or sets the title text of the balloon associated with the tray icon."), DefaultValue("Balloon Title"), Category("ShellNotifyIcon Properties")]
        public string BalloonTitle
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.cc20708a296c850b8a228ce28f0e17ed2;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.cc20708a296c850b8a228ce28f0e17ed2 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public Window HostWindow
        {
            get
            {
                return this.c177d222de4b5fba13162f367d8e89920;
            }
            set
            {
                if (this.c177d222de4b5fba13162f367d8e89920 == value)
                {
                    return;
                }
                this.c5be2e2fd531b845456bce64adf4fbcdb();
                this.c177d222de4b5fba13162f367d8e89920 = value;
                if (this.c177d222de4b5fba13162f367d8e89920 == null)
                {
                    return;
                }
            Label_001F:
                switch (6)
                {
                    case 0:
                        goto Label_001F;

                    default:
                        if (1 == 0)
                        {
                        }
                        if (this.c177d222de4b5fba13162f367d8e89920.IsLoaded)
                        {
                            this.c7d0cbbd420ad5b513b7242bda34d0efe();
                            goto Label_0068;
                        }
                        break;
                }
            Label_003F:
                switch (6)
                {
                    case 0:
                        goto Label_003F;

                    default:
                        this.c177d222de4b5fba13162f367d8e89920.Loaded += new RoutedEventHandler(this.hostWindow_Loaded);
                        break;
                }
            Label_0068:
                this.c177d222de4b5fba13162f367d8e89920.Closed += new EventHandler(this.hostWindow_Closed);
            }
        }

        [Description("Gets or sets the index of the icon which will showed in the system tray."), Category("ShellNotifyIcon Properties"), DefaultValue(0)]
        public int ImageIndex
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.c96843e9e70af009670f7f3eab265f3fc;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.c96843e9e70af009670f7f3eab265f3fc = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Gets the imagelist of icons associated with the tray icon."), Category("ShellNotifyIcon Properties")]
        public TrayImageList ImageList
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.cc242eea95e8bbf5509c12bc80cd092f7;
            }
        }

        [Description("Gets or sets the tool tip displayed for the system tray icon."), DefaultValue("Tooltip"), Category("ShellNotifyIcon Properties")]
        public string Tooltip
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.c51f6b29c4fb70410a7aeae814d025e3d;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.c51f6b29c4fb70410a7aeae814d025e3d = value;
            }
        }

        [DefaultValue(typeof(bool), "true"), Category("ShellNotifyIcon Properties"), Description("Gets or sets whether the icon is shown in the system tray.")]
        public bool Visible
        {
            get
            {
                return this.cf9d173e30a8408a1186a10095afcf215.c5e2047baaec066c01e59b42f7dc3642a;
            }
            set
            {
                this.cf9d173e30a8408a1186a10095afcf215.c5e2047baaec066c01e59b42f7dc3642a = value;
            }
        }
    }
}

