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
        public MainWindow()
        {
            {
                this.Visibility = Visibility.Hidden;
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                string UserName1 = Environment.UserName;
                string path_directory = @"C:\temp";
                MonitorDirectory(path_directory);

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(3);
            this.Visibility = Visibility.Hidden;
            Move.ChangeName();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(5);
            this.Visibility = Visibility.Hidden;
            Move.ChangeName();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(7);
            this.Visibility = Visibility.Hidden;
            Move.ChangeName();
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(9);
            this.Visibility = Visibility.Hidden;
            Move.ChangeName();

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Move.GetSize(12);
            this.Visibility = Visibility.Hidden;
            Move.ChangeName();
        }
        private void ShowWindow()
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                this.Visibility = Visibility.Visible;
            }));
        }

            public void HideWindow()
        {
            this.Visibility = Visibility.Hidden;
        }


        public void MonitorDirectory(string path)

        {

            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.Path = path;

            fileSystemWatcher.Created += FileSystemWatcher_Created;

            fileSystemWatcher.Renamed += FileSystemWatcher_Renamed;

            fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;

            fileSystemWatcher.EnableRaisingEvents = true;

            fileSystemWatcher.Filter = "*.png";

            Console.WriteLine(path + @"\static.png");

            if (File.Exists(path + @"\static.png"))
            {
                Move.ChangeName();
            }

        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)

        {
            Console.WriteLine("Nowy plik: {0}", e.Name);
            Thread.Sleep(5000);
        }

        private void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)

        {
            Console.WriteLine("Nowy plik - zmieniona nazwa: {0}", e.Name);
            ShowWindow();
            Thread.Sleep(5000);
        }

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)

        {
            Console.WriteLine("Plik skasowany: {0}", e.Name);
        }
    }


}
