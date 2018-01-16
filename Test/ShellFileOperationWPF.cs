namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Perform copy, move, delete and rename operations on multiple files/folders with progress dialog and sub-folder support."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class ShellFileOperationWPF : FrameworkElement
    {
        private cbfdcb6ac9f04777e1bd204d939be2794 c0b6e5a5de74d7d670c1cbbce07e8457d = new cbfdcb6ac9f04777e1bd204d939be2794();

        public ShellFileOperationWPF()
        {
            Type type = typeof(ShellFileOperationWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public bool Copy()
        {
            return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c62998d7a3fa290edc02a5ebdcf410c96();
        }

        public bool Delete()
        {
            return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c9e7efffb51cc0c944ea970ded8951bb3();
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(16.0, 16.0);
        }

        public bool Move()
        {
            return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c5827f5a6083311c45520b26e140744e6();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1e43);
            Stream stream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = stream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public bool Rename()
        {
            return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c37ff7705ae614907cc2cd8f48f270ca5();
        }

        [Category("ShellFileOperation Properties"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public bool AreAnyOperationsAborted
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.cbcaa8bae586863e66d9b13335bb5ab9f;
            }
        }

        [Category("ShellFileOperation Properties"), DefaultValue(true), Description("Gets/Sets whether SourceFiles and DestinationFiles are automatically cleared after each operation")]
        public bool AutoClearFilesAfterOperation
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c6f415639170795e44583e946fd220632;
            }
            set
            {
                this.c0b6e5a5de74d7d670c1cbbce07e8457d.c6f415639170795e44583e946fd220632 = value;
            }
        }

        [Category("ShellFileOperation Properties"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public StringCollection DestinationFiles
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.ce7cc3a3209ba6550019a05c91616e918;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public int ErrorCode
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.cb65db64f6062f56b869eb60db0aa3a34;
            }
        }

        [Category("ShellFileOperation Properties"), Description("Gets/Sets various settings for the operation"), DefaultValue(typeof(ShellFileOperationFlags), "None")]
        public ShellFileOperationFlags Flags
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c35d2c68395a8575aab425760b38325e7;
            }
            set
            {
                this.c0b6e5a5de74d7d670c1cbbce07e8457d.c35d2c68395a8575aab425760b38325e7 = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Category("ShellFileOperation Properties"), Browsable(false)]
        public IntPtr HwndUIParent
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.cdb8a95d9fc122c1f0dc59efae12e808b;
            }
            set
            {
                this.c0b6e5a5de74d7d670c1cbbce07e8457d.cdb8a95d9fc122c1f0dc59efae12e808b = value;
            }
        }

        [Description("Gets/Sets the text displayed in the progress dialog when SimpleProgressDialog is specified"), DefaultValue(""), Category("ShellFileOperation Properties")]
        public string ProgressDialogText
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c11450dfdcc27e949b0aff3f906a3b039;
            }
            set
            {
                this.c0b6e5a5de74d7d670c1cbbce07e8457d.c11450dfdcc27e949b0aff3f906a3b039 = value;
            }
        }

        [Category("ShellFileOperation Properties"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StringCollection SourceFiles
        {
            get
            {
                return this.c0b6e5a5de74d7d670c1cbbce07e8457d.c15ea0688aa70bab70c0bad44edfe3455;
            }
        }
    }
}

