namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Display user-friendly system-standard progress dialogs while lengthy operations are performed."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class ShellProgressDialogWPF : FrameworkElement
    {
        private cc07dd26213547d2dace751947c4a0fc3 ce034d49d93c013f813da80f22acd7c54 = new cc07dd26213547d2dace751947c4a0fc3();

        public ShellProgressDialogWPF()
        {
            Type type = typeof(ShellProgressDialogWPF);
            LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public void Hide()
        {
            this.ce034d49d93c013f813da80f22acd7c54.cbd845fffa99d4a187760c331bee94c5f();
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1b79);
            Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = manifestResourceStream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public void ResetTimeRemainingEstimate()
        {
            this.ce034d49d93c013f813da80f22acd7c54.c314a3b948ce7ce362a29c3c3c0a58583();
        }

        public void SetAnimation(IntPtr hInstAnimation, int idAnimation)
        {
            this.ce034d49d93c013f813da80f22acd7c54.cd734be91e5c43ef73e2f0a4259311ff0(hInstAnimation, idAnimation);
        }

        public void SetProgress(int complete, int total)
        {
            this.ce034d49d93c013f813da80f22acd7c54.ce732deb4daf1b06f1f0b5a6baa1e41ec(complete, total);
        }

        public void SetProgress(long complete, long total)
        {
            this.ce034d49d93c013f813da80f22acd7c54.ce732deb4daf1b06f1f0b5a6baa1e41ec(complete, total);
        }

        public void Show()
        {
            this.ce034d49d93c013f813da80f22acd7c54.cca5c5131ff5751053c5c296e97a1967f();
        }

        public void Show(IntPtr hWndParent)
        {
            this.ce034d49d93c013f813da80f22acd7c54.cca5c5131ff5751053c5c296e97a1967f(hWndParent);
        }

        public void Show(Window window)
        {
            WindowInteropHelper helper = new WindowInteropHelper(window);
            this.Show(helper.Handle);
        }

        [Category("ShellProgressDialog Properties"), DefaultValue(typeof(ProgressDialogAnimation), "FileCopy"), Description("Gets or sets the animation to be displayed in the progress dialog")]
        public ProgressDialogAnimation Animation
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.cd21d1065e7f11ee4e21bf97706dd9138;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.cd21d1065e7f11ee4e21bf97706dd9138 = value;
            }
        }

        [DefaultValue(""), Category("ShellProgressDialog Properties"), Description("Gets or sets the cancel message which is displayed when the Cancel button is clicked")]
        public string CancelMessage
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c276214f7cf41f2d72f652b6171d72dcd;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c276214f7cf41f2d72f652b6171d72dcd = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("Gets or sets whether the user has pressed the cancel button"), Category("ShellProgressDialog Properties"), Browsable(false)]
        public bool HasUserCancelled
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.cee0b1dd69613535ea9e0dd345cfac412;
            }
        }

        [DefaultValue(""), Category("ShellProgressDialog Properties"), Description("Gets or sets the text displayed on the first line of the progress dialog")]
        public string Line1
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c62658c64f598503629217fe62467dd46;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c62658c64f598503629217fe62467dd46 = value;
            }
        }

        [Category("ShellProgressDialog Properties"), Description("Gets or sets the text displayed on the second line of the progress dialog"), DefaultValue("")]
        public string Line2
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c306e3f1318c0eb832aec0ac93eff5ebb;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c306e3f1318c0eb832aec0ac93eff5ebb = value;
            }
        }

        [DefaultValue(""), Category("ShellProgressDialog Properties"), Description("Gets or sets the text displayed on the third line of the progress dialog")]
        public string Line3
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.cc5f686ff93904c5802f9df7b6f0382af;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.cc5f686ff93904c5802f9df7b6f0382af = value;
            }
        }

        [Category("ShellProgressDialog Properties"), Description("Gets or sets whether the progress dialog is displayed in modal or modeless manner"), DefaultValue(false)]
        public bool Modal
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.ce082806b7ed573c9a23197ea334c010f;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.ce082806b7ed573c9a23197ea334c010f = value;
            }
        }

        [DefaultValue(0), Description("Gets or sets the percent of the operation completed"), Category("ShellProgressDialog Properties")]
        public float PercentComplete
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c696497e5d1ae5f0b0a463ca2b949c9c3;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c696497e5d1ae5f0b0a463ca2b949c9c3 = value;
            }
        }

        [Category("ShellProgressDialog Properties"), DefaultValue(typeof(LogicNP.ShellObjects.ProgressBarStyle), "Normal"), Description("Gets or sets the style of the progress bar shown in the progress dialog")]
        public LogicNP.ShellObjects.ProgressBarStyle ProgressBarStyle
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.cfd91f4bc4d39e8223d8e9cf292c9b31a;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.cfd91f4bc4d39e8223d8e9cf292c9b31a = value;
            }
        }

        [DefaultValue(true), Description("Gets or sets whether the cancel button is displayed"), Category("ShellProgressDialog Properties")]
        public bool ShowCancelButton
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c4e4fffe948c32317ddce3651145d52e2;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c4e4fffe948c32317ddce3651145d52e2 = value;
            }
        }

        [Description("Gets or sets whether the minimize button is displayed"), Category("ShellProgressDialog Properties"), DefaultValue(false)]
        public bool ShowMinimizeButton
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c006ece396f399214e48cfe3ed717797d;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c006ece396f399214e48cfe3ed717797d = value;
            }
        }

        [DefaultValue(true), Category("ShellProgressDialog Properties"), Description("Gets or sets whether time remaining is automatically displayed on the third line of the progress dialog")]
        public bool ShowTimeRemaining
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c5bb4aea4c7c05f13fb0e7c36affd87fc;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c5bb4aea4c7c05f13fb0e7c36affd87fc = value;
            }
        }

        [DefaultValue("Title"), Description("Gets or sets the title of the progress dialog"), Category("ShellProgressDialog Properties")]
        public string Title
        {
            get
            {
                return this.ce034d49d93c013f813da80f22acd7c54.c6078f89b6e45d8cea10e58c9405e155e;
            }
            set
            {
                this.ce034d49d93c013f813da80f22acd7c54.c6078f89b6e45d8cea10e58c9405e155e = value;
            }
        }
    }
}

