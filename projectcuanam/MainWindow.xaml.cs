using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows.Threading;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using LogicNP.ShellObjects;
using System.Reflection;

namespace projectcuanam
{



    public partial class MainWindow 
    {
        
        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr
        phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name,
        ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        private void DoExitWin(int flg)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(flg, 0);
        }

        
        public MainWindow()
        {
            InitializeComponent();
            RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rkApp.SetValue("Trash Menu", "C:\\Users\\karl\\Desktop\\project1\\project\\projectcuanam\\projectcuanam\\bin\\Debug\\projectcuanam.exe");
            shlAppBar.DockingEdge = DockingEdges.Top;
            left win1 = new left();
            win1.Show();
            starclock();
            
        }

        private void starclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString(@"hh\:mm");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            shlAppBar.HostWindow = this;
        }


        private void CommonHandler(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.MenuItem karl = e.Source as System.Windows.Controls.MenuItem;
            switch (karl.Name)
            {
                case "Browser":
                    {
                        Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
                        break;
                    }
                case "Regedit":
                    {
                        Process.Start("C:\\Windows\\regedit.exe");
                        break;
                    }
                case "taskmanager":
                    {
                        Process.Start("C:\\Windows\\System32\\Taskmgr.exe");
                        break;
                    }
                case "services":
                    {
                        Process.Start("C:\\Windows\\System32\\services.msc");
                        break;
                    }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            /*ProcessStartInfo proc = new ProcessStartInfo();
             proc.WindowStyle = ProcessWindowStyle.Hidden;
             proc.FileName = "cmd";
             proc.Arguments = "/C shutdown -s -t 0";
             Process.Start(proc);*/
            DoExitWin(EWX_SHUTDOWN);
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            // When window got focused
            Topmost = true;
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            // When window lost focus
            Topmost = false;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            /*ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.FileName = "cmd";
            proc.Arguments = "/C shutdown -f -r -t 0";
            Process.Start(proc);*/
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void ButtonOkClicked(object sender, RoutedEventArgs e)

        {



        }

        private void Menu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
                AboutMe win = new AboutMe();
                win.Show();
                
                    
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            DoExitWin(EWX_REBOOT);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void as_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo info
            = new ProcessStartInfo(@"E:\Apps\bin\studio64.exe");
            Process.Start(info);
        }

        private void vs_Click(object sender, RoutedEventArgs e)
        {
           // ProcessStartInfo info
            //= new ProcessStartInfo("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\Common7\\IDE\\devenv.exe");
            Process.Start(@"E:\Appsz\vs 17\Common7\IDE\devenv.exe");
        }

        private void cad17_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo info
            = new ProcessStartInfo(@"E:\Appsz\AUTOCAD 17\Autodesk\AutoCAD 2017\acad.exe");
            Process.Start(info);
        }

        private void msi_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\MSI Afterburner\MSIAfterburner.exe");
        }

        private void virtualbox_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"E:\Appsz\virtual box\VirtualBox.exe");
        }

        private void genymotion_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"E:\Appsz\Genymotion\genymotion.exe");
        }

        private void genymotionshell_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"E:\Appsz\Genymotion\genyshell.exe");
        }

        private void discord_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Users\karl\AppData\Local\Discord\app-0.0.299\Discord.exe");
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft VS Code\Code.exe");
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Keil\UV4\Uv4.exe");
        }

        private void intelij_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\JetBrains\IntelliJ IDEA Community Edition 2017.3.1\bin\idea64.exe");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
        }

        private void photoshop_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Adobe\Adobe Photoshop CC 2018\Photoshop.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

    }
}
