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

    [Description("Allows listening to system-wide mouse and keyboard events"), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class SystemHookWPF : FrameworkElement
    {
        private cf3c2f74b3b5e50c49a30aef62c94765e cada81997d104ca88744156a918619970 = new cf3c2f74b3b5e50c49a30aef62c94765e();

        public event KeyEventHandler KeyDown
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c32d72965e8153d8d2c15994eabf708dd += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c32d72965e8153d8d2c15994eabf708dd -= value;
            }
        }

        public event KeyPressEventHandler KeyPress
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c21c8699363c00a34d62aa68e0a722496 += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c21c8699363c00a34d62aa68e0a722496 -= value;
            }
        }

        public event KeyEventHandler KeyUp
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c5f0186b9f9f0bcf389d2f402fd8b83a2 += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c5f0186b9f9f0bcf389d2f402fd8b83a2 -= value;
            }
        }

        public event MouseHookEventHandler MouseClick
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c822defd35d8e8ca040b3ab68ad361661 += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c822defd35d8e8ca040b3ab68ad361661 -= value;
            }
        }

        public event MouseHookEventHandler MouseDoubleClick
        {
            add
            {
                this.cada81997d104ca88744156a918619970.ce49ec6160ebdaeee721da58e0f8e5eef += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.ce49ec6160ebdaeee721da58e0f8e5eef -= value;
            }
        }

        public event MouseHookEventHandler MouseDown
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c3e9fce08aea72fc8f20909a9b5740d65 += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c3e9fce08aea72fc8f20909a9b5740d65 -= value;
            }
        }

        public event MouseHookEventHandler MouseMove
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c5372488ecc0ee5982ccdd2ad0fc2e55b += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c5372488ecc0ee5982ccdd2ad0fc2e55b -= value;
            }
        }

        public event MouseHookEventHandler MouseUp
        {
            add
            {
                this.cada81997d104ca88744156a918619970.ca2fc7dd3008742530fda8571b04a827c += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.ca2fc7dd3008742530fda8571b04a827c -= value;
            }
        }

        public event MouseHookEventHandler MouseWheel
        {
            add
            {
                this.cada81997d104ca88744156a918619970.c57d60b9a148d65660d9cbd5fe9613660 += value;
            }
            remove
            {
                this.cada81997d104ca88744156a918619970.c57d60b9a148d65660d9cbd5fe9613660 -= value;
            }
        }

        public SystemHookWPF()
        {
            System.Type type = typeof(SystemHookWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x2c));
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = manifestResourceStream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        [Category("SystemHook Properties"), DefaultValue(true)]
        public bool Enabled
        {
            get
            {
                return this.cada81997d104ca88744156a918619970.cd27064617e7470579081876d8be7f52c;
            }
            set
            {
                this.cada81997d104ca88744156a918619970.cd27064617e7470579081876d8be7f52c = value;
            }
        }
    }
}

