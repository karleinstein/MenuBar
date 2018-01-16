namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Forms;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    [Description("Miscellaneous shell-related utility methods."), LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33))]
    public class ShellUtilsWPF : FrameworkElement
    {
        private c7589af0a5cd7e5254f8316dcbab8f825 c1f4882016ec99b476d4f5df5e8d31ce3 = new c7589af0a5cd7e5254f8316dcbab8f825();

        public ShellUtilsWPF()
        {
            System.Type type = typeof(ShellUtilsWPF);
            License license1 = LicenseManager.Validate(type, this);
            base.Visibility = Visibility.Hidden;
        }

        public void AddToRecentList(string path)
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.cfa200edd7c173bb8b223175b3d07bba5(path);
        }

        public void AddToStartupRunList(StartupType type, string path)
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.ce26b09daf3badac9d1f1ad762ccaf40f(type, path);
        }

        public Bitmap Capture(Process process)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(process);
        }

        public Bitmap Capture(Rectangle rc)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(rc);
        }

        public Bitmap Capture(IntPtr handle)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(handle);
        }

        public Bitmap Capture(Screen screen)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(screen);
        }

        public Bitmap Capture(Window window)
        {
            WindowInteropHelper helper = new WindowInteropHelper(window);
            IntPtr handle = helper.Handle;
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(handle);
        }

        public Bitmap Capture(IntPtr handle, bool clientOnly)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(handle, clientOnly);
        }

        public Bitmap Capture(Screen screen, bool workingAreaOnly)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(screen, workingAreaOnly);
        }

        public Bitmap Capture(Window window, bool clientOnly)
        {
            WindowInteropHelper helper = new WindowInteropHelper(window);
            IntPtr handle = helper.Handle;
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c237c0215cf0e503eddba219e00d83b14(handle, clientOnly);
        }

        public Bitmap[] CaptureAllScreens()
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.cf0f72ce5a39896a8e43361aa4b35a3d9();
        }

        public Bitmap CaptureEntireScreen()
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c44e6c78f30ebbba33f4d12513072066b();
        }

        public void CascadeWindows()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c017bbae935049828986faaf0a4ae9eaa();
        }

        public void EmptyRecentList()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.ca22fa290c19cd82a6088aa07e2949b44();
        }

        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize)
        {
            return new System.Windows.Size(16.0, 16.0);
        }

        public void MinimizeAll()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c50c95866982c3120604ba74fe39bf844();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string name = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x233b);
            Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = manifestResourceStream;
            imageSource.EndInit();
            Rect rectangle = new Rect(0.0, 0.0, 16.0, 16.0);
            drawingContext.DrawImage(imageSource, rectangle);
            base.OnRender(drawingContext);
        }

        public void RemoveFromStartupRunList(StartupType type, string path)
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.ce864686d896a8b30d5356b6542450e80(type, path);
        }

        public void RunControlPanelItem(string itemName)
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.cf8592e4c15b8745fb30921a4f4af8218(itemName);
        }

        public bool SetWallpaper(Bitmap bmp, WallpaperStyle style)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c98e0829a6f6b872035e12b27ba176ca3(bmp, style);
        }

        public bool SetWallpaper(string fileName, WallpaperStyle style)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c98e0829a6f6b872035e12b27ba176ca3(fileName, style);
        }

        public void ShowDateTimePropertiesDialog()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c9def6226a197736a1b0fa2d17146f10b();
        }

        public void ShowFileRunDialog()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.caa8f07290ad84177b5ee3e6ec2eb9f4a();
        }

        public void ShowFindComputerDialog()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c302d2d149e915c19516f8aa4d8d6b4aa();
        }

        public void ShowOpenWithDialog(string path)
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c0c436dc72c44741f862a73954b3522b3(path);
        }

        public Icon ShowPickIconDialog(string path)
        {
            return this.c1f4882016ec99b476d4f5df5e8d31ce3.c50b5169898744cb62668ef0bc49a4053(path);
        }

        public void ShowSearchFilesDialog()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.cdb376596c993779607193e9b80fbf956();
        }

        public void ShowShutdownWindowsDialog()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c58a76f78c52b2e750f5a54c9df2fc084();
        }

        public void ShowTaskBarPropertiesDialog()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c37b7762e58dd2f56a3aa578c8cf91231();
        }

        public void ShowWindowsHelp()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.cf73c87f1dcbc5b465681239a1eb04021();
        }

        public void StartScreenSaver()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c0e6ac395e9aa49595440c6ff086e2689();
        }

        public void TerminateScreenSaver()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c33d2bddf01de3d34e1eef5987a7c66fd();
        }

        public void TileWindowsHorizontally()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.cb35bc27708dff29deaa0b51142be960e();
        }

        public void TileWindowsVertically()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c136ff38628734d6a9bc7326ea9dab9c0();
        }

        public void ToggleDesktop()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.c74f4e7286fa848154de2697db46b0e27();
        }

        public void UndoMinimizeAll()
        {
            this.c1f4882016ec99b476d4f5df5e8d31ce3.cb4b2c767a7b95e5da99c95119c856417();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public bool IsScreenSaverRunning
        {
            get
            {
                return this.c1f4882016ec99b476d4f5df5e8d31ce3.c315590a8a05ce2a54684d72b10938f32;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ScreenSaver
        {
            get
            {
                return this.c1f4882016ec99b476d4f5df5e8d31ce3.c228b7d1088c547d9a386a0ea9cff7c02;
            }
            set
            {
                this.c1f4882016ec99b476d4f5df5e8d31ce3.c228b7d1088c547d9a386a0ea9cff7c02 = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ScreenSaverActive
        {
            get
            {
                return this.c1f4882016ec99b476d4f5df5e8d31ce3.c35345bd5dd48904316b7ff44a9c8867c;
            }
            set
            {
                this.c1f4882016ec99b476d4f5df5e8d31ce3.c35345bd5dd48904316b7ff44a9c8867c = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ScreenSaverIsSecure
        {
            get
            {
                return this.c1f4882016ec99b476d4f5df5e8d31ce3.cf0714b0aff0dd4a070d37b2b5e160d4b;
            }
            set
            {
                this.c1f4882016ec99b476d4f5df5e8d31ce3.cf0714b0aff0dd4a070d37b2b5e160d4b = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ScreenSaverTimeout
        {
            get
            {
                return this.c1f4882016ec99b476d4f5df5e8d31ce3.cf1023d9fff40d5ee84303aba696ccd60;
            }
            set
            {
                this.c1f4882016ec99b476d4f5df5e8d31ce3.cf1023d9fff40d5ee84303aba696ccd60 = value;
            }
        }
    }
}

