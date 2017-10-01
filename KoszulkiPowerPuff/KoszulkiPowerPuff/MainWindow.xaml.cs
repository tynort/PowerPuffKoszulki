using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Powerpuff1
{
    public partial class MainWindow : Window
    {
        public static bool valueVisibleWindow;
        public MainWindow()
        {
            {
                this.Visibility = Visibility.Hidden;
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                string UserName1 = Environment.UserName;
                string path_directory = @"C:\temp";
                Watcher.MonitorDirectory(path_directory);

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(3);
            this.Visibility = Visibility.Hidden;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(5);
            this.Visibility = Visibility.Hidden;

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(7);
            this.Visibility = Visibility.Hidden;

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(9);
            this.Visibility = Visibility.Hidden;

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(12);
            this.Visibility = Visibility.Hidden;

        }
        public static void ShowWindow()
        {
            //this.Visibility = Visibility.Visible;
        }

        public static void HideWindow()
        {
            //this.Visibility = Visibility.Hidden;
        }

    }


}
