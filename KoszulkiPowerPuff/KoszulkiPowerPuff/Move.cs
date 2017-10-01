using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Powerpuff1
{
    public class Move : MainWindow
    {
        public static string rozmiar = "";

        public static void ChangeName()
        {

            string UserName1 = Environment.UserName;
            //FileInfo fInfo = new FileInfo(@"C:\Users\" + UserName1 + @"\Downloads\static.png");
            FileInfo fInfo = new FileInfo(@"C:\temp\static.png");
            string data_pliku = fInfo.CreationTimeUtc.ToString("HH_mm_ss");
            string czas_zapisu = fInfo.LastWriteTimeUtc.ToString("HH_mm_ss");
            //string path = "C:\\Users\\" + UserName1 + @"\Downloads\static.png";
            string path = @"C:\temp\static.png";
            string path2 = @"C:\temp2\koszulka_" + rozmiar + "_" + data_pliku + "_" + czas_zapisu + "_" + UserName1 + ".png";

            try
            {
                // This statement ensures that the file is created,
                // but the handle is not kept.
                if (File.Exists(path2))
                    File.Delete(path2);


                File.Move(path, path2);
                Console.WriteLine("{0} was moved to {1}.", path, path2);

                // See if the original exists now.
                if (File.Exists(path))
                {
                    Console.WriteLine("The original file still exists, which is unexpected.");
                }
                else
                {
                    Console.WriteLine("The original file no longer exists, which is expected.");
                }
            }
            catch (Exception e)
            {

            }
        }
        public static void GetSize(int v)
        {
            rozmiar = v.ToString();
        }
    }
}