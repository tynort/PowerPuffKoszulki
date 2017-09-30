using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace Powerpuff1
{
    class Watcher
    {
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void MonitorDirectory(string path)

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

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)

        {

            Console.WriteLine("File created: {0}", e.Name);

        }

        private static void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)

        {

            Console.WriteLine("File renamed: {0}", e.Name);
            Thread.Sleep(5000);
            Move.ChangeName();


        }

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)

        {

            Console.WriteLine("File deleted: {0}", e.Name);

        }

    }
}
