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
using System.Windows.Shapes;
using System.Diagnostics;
using LogicNP.ShellObjects;

namespace projectcuanam
{
    /// <summary>
    /// Interaction logic for AboutMe.xaml
    /// </summary>
    public partial class AboutMe : Window
    {
        public AboutMe()
        {
            
            InitializeComponent();
            shlAppBar.DockingEdge = DockingEdges.Top;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Clickz(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.facebook.com/karleinsteinz");
        }

        private void yeah(object sender, RoutedEventArgs e)
        {
        }
    }
}
