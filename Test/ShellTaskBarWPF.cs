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

    [Description("Organize, re-order, delete or add tabs in the Windows TaskBar."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class ShellTaskBarWPF : FrameworkElement
    {
        private c58243ec031cdd8a07efc29f4eecc791c cc5915d4f046fff113021da39fa7bea13 = new c58243ec031cdd8a07efc29f4eecc791c();

        public ShellTaskBarWPF()
        {
            Type type = typeof(ShellTaskBarWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public void ActivateTab(ShellTaskBarTab tab)
        {
            this.cc5915d4f046fff113021da39fa7bea13.cc27baf1d3ae7033c4fcc2c44775e21da(tab);
        }

        public void ActivateTab(IntPtr hwnd)
        {
            this.cc5915d4f046fff113021da39fa7bea13.cc27baf1d3ae7033c4fcc2c44775e21da(hwnd);
        }

        public void AddTab(IntPtr hwnd)
        {
            this.cc5915d4f046fff113021da39fa7bea13.ca4d21568a23ac3b5e795e5fef0cb72c5(hwnd);
        }

        public void AddTabs(ShellTaskBarTab[] tabs)
        {
            this.cc5915d4f046fff113021da39fa7bea13.c4219c855a782ded2627a2d25e6cdf02b(tabs);
        }

        public void AddTabs(IntPtr[] hwnds)
        {
            this.cc5915d4f046fff113021da39fa7bea13.c4219c855a782ded2627a2d25e6cdf02b(hwnds);
        }

        public void DeleteAllTabs()
        {
            this.cc5915d4f046fff113021da39fa7bea13.c2629c6a31c971449fb180943f7a917a6();
        }

        public void DeleteTab(ShellTaskBarTab tab)
        {
            this.cc5915d4f046fff113021da39fa7bea13.c01692aea308aacc29933a366c6456f33(tab);
        }

        public void DeleteTab(IntPtr hwnd)
        {
            this.cc5915d4f046fff113021da39fa7bea13.c01692aea308aacc29933a366c6456f33(hwnd);
        }

        public ShellTaskBarTab GetActiveTab()
        {
            return this.cc5915d4f046fff113021da39fa7bea13.c9b6d765767e761c06c887aa6b5a3ffe0();
        }

        public ShellTaskBarTab[] GetTabs()
        {
            return this.cc5915d4f046fff113021da39fa7bea13.c7d74ff660fe1faf0cf965ff8a100fb09();
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x85));
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }
    }
}

