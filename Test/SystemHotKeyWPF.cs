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

    [Description("Define and listen to system wide hotkeys."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class SystemHotKeyWPF : FrameworkElement
    {
        private cfa5aa368e7262ba8e7c2f18478ea71e0 c6902301418a3edf088649b116e8e631d = new cfa5aa368e7262ba8e7c2f18478ea71e0();

        [Description("Occurs when the hot key is pressed")]
        public event EventHandler HotKeyPressed
        {
            add
            {
                this.c6902301418a3edf088649b116e8e631d.c968050d27caba2c0fe4bbdfe16c3b91b += value;
            }
            remove
            {
                this.c6902301418a3edf088649b116e8e631d.c968050d27caba2c0fe4bbdfe16c3b91b -= value;
            }
        }

        public SystemHotKeyWPF()
        {
            System.Type type = typeof(SystemHotKeyWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2552);
            Stream stream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        [Description("Sets the system-wide hot key")]
        public void SetHotKey(Keys key, KeyModifiers keyModifiers)
        {
            this.c6902301418a3edf088649b116e8e631d.cbb54993ced46008451a87fbe1842ccbd(key, keyModifiers);
        }

        public DialogResult ShowHotKeyEditorDialog()
        {
            return this.c6902301418a3edf088649b116e8e631d.cb9685c3de07ee9f01642f309aab7f2ca();
        }

        public override string ToString()
        {
            return this.c6902301418a3edf088649b116e8e631d.ToString();
        }

        [Description("Gets/Sets whether the component will enable the hot key and listen for it"), Category("SystemHotKey properties"), DefaultValue(typeof(bool), "true")]
        public bool Enabled
        {
            get
            {
                return this.c6902301418a3edf088649b116e8e631d.cd27064617e7470579081876d8be7f52c;
            }
            set
            {
                this.c6902301418a3edf088649b116e8e631d.cd27064617e7470579081876d8be7f52c = value;
            }
        }

        [Category("SystemHotKey properties"), Description("Gets the hot key")]
        public Keys HotKey
        {
            get
            {
                return this.c6902301418a3edf088649b116e8e631d.cb3f587592f2af103cdf6b8dddefa22c4;
            }
        }

        [Description("Gets the hot key modifiers (Control,Shift,Alt & Win)"), Category("SystemHotKey properties")]
        public KeyModifiers HotKeyModifiers
        {
            get
            {
                return this.c6902301418a3edf088649b116e8e631d.cdba9f0ba2c9c0c969eec017cb98cf475;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRegistered
        {
            get
            {
                return this.c6902301418a3edf088649b116e8e631d.c4f1c281dc06c3e8f34fb651119ed2ff7;
            }
        }
    }
}

