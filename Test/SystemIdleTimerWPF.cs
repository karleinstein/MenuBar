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

    [Description("Get notified when the system goes idle for a certain time and when it exits the idle state."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class SystemIdleTimerWPF : FrameworkElement
    {
        private cb1dc6ae7cd3094a5a24f10fca8e6edfd cd84a18bfaad4c1be695c4812e52bb79b = new cb1dc6ae7cd3094a5a24f10fca8e6edfd();

        public event EventHandler SystemIdle
        {
            add
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.cdc5918b69b386b32767a35563bb7923c += value;
            }
            remove
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.cdc5918b69b386b32767a35563bb7923c -= value;
            }
        }

        public event EventHandler SystemResume
        {
            add
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.c74c627339319d3aa4c6445d8be367892 += value;
            }
            remove
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.c74c627339319d3aa4c6445d8be367892 -= value;
            }
        }

        public event EventHandler Tick
        {
            add
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.c0bdcb29813fc588a282b51da5450a7e0 += value;
            }
            remove
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.c0bdcb29813fc588a282b51da5450a7e0 -= value;
            }
        }

        public SystemIdleTimerWPF()
        {
            LicenseManager.Validate(typeof(SystemIdleTimerWPF), this);
            base.Visibility = Visibility.Hidden;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x22da);
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        [Category("SystemIdleTimer Properties"), DefaultValue(true)]
        public bool Enabled
        {
            get
            {
                return this.cd84a18bfaad4c1be695c4812e52bb79b.cd27064617e7470579081876d8be7f52c;
            }
            set
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.cd27064617e7470579081876d8be7f52c = value;
            }
        }

        [DefaultValue(0x2710), Category("SystemIdleTimer Properties")]
        public int IdleTimeout
        {
            get
            {
                return this.cd84a18bfaad4c1be695c4812e52bb79b.c2cfedfefd4bb11711ec55928018a0d4e;
            }
            set
            {
                this.cd84a18bfaad4c1be695c4812e52bb79b.c2cfedfefd4bb11711ec55928018a0d4e = value;
            }
        }

        [Browsable(false)]
        public int SystemIdleTime
        {
            get
            {
                return this.cd84a18bfaad4c1be695c4812e52bb79b.ce2a1de26218af676b321aed7517c4865;
            }
        }
    }
}

