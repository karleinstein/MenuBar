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

    [LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33)), Description("Control the Windows Task Scheduler service and create, delete and modify tasks.")]
    public class TaskSchedulerWPF : FrameworkElement
    {
        private c61a84218c2179861e704b4b2a41ed55d c83670ab0e6eaff1dfffe94207e2621c8 = new c61a84218c2179861e704b4b2a41ed55d();

        public TaskSchedulerWPF()
        {
            Type type = typeof(TaskSchedulerWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public Task CreateTask(string name)
        {
            return this.c83670ab0e6eaff1dfffe94207e2621c8.c073060495a6746796f9efb7a6c21d845(name);
        }

        public bool DeleteTask(string name)
        {
            return this.c83670ab0e6eaff1dfffe94207e2621c8.c83f2ac69e3bc740263c966213e74f467(name);
        }

        public string[] GetTaskNames()
        {
            return this.c83670ab0e6eaff1dfffe94207e2621c8.c21e14f0b036155718c57c94e436b1831();
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0xa31);
            Stream stream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public Task OpenTask(string name)
        {
            return this.OpenTask(name);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public string TargetComputer
        {
            get
            {
                return this.c83670ab0e6eaff1dfffe94207e2621c8.cc0ed91f8ad342545073fba89722c96b4;
            }
            set
            {
                this.c83670ab0e6eaff1dfffe94207e2621c8.cc0ed91f8ad342545073fba89722c96b4 = value;
            }
        }
    }
}

