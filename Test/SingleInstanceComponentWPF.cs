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

    [Description("Get notified when a second instance of your application is started and optionally prevent it from running."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class SingleInstanceComponentWPF : FrameworkElement
    {
        public static  event NewInstanceEventHandler NewInstance
        {
            add
            {
                cd68bbd9fc8deae561907fe5e9c7a165f.c97b40c8249b2b6e37c9ad9dbccbe1c3a += value;
            }
            remove
            {
                cd68bbd9fc8deae561907fe5e9c7a165f.c97b40c8249b2b6e37c9ad9dbccbe1c3a -= value;
            }
        }

        public SingleInstanceComponentWPF()
        {
            Type type = typeof(SingleInstanceComponentWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public static void InstanceExit()
        {
            cd68bbd9fc8deae561907fe5e9c7a165f.c6ff52859b89d4cc7e7b99063201f1e53();
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        public static bool NotifyExistingInstance(object data)
        {
            return cd68bbd9fc8deae561907fe5e9c7a165f.c41a98067728e9e503c905c9542b1a3dc(data);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1eaa));
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public static string ApplicationID
        {
            get
            {
                return cd68bbd9fc8deae561907fe5e9c7a165f.cd525667b0598c18d743ae8866fd56559;
            }
            set
            {
                cd68bbd9fc8deae561907fe5e9c7a165f.cd525667b0598c18d743ae8866fd56559 = value;
            }
        }
    }
}

