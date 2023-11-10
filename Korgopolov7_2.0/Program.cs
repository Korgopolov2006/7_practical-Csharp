
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Korgopolov7_2._0
{
    internal class Program
    {

        public static void Main()
        {
			
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"{"Этот компьютер",60}");
                    Console.WriteLine("".PadRight(120, '-'));
                    
                    Console.SetCursorPosition(0, 2);

                    string[] array;
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine("  " + drive.TotalSize / 1073741824 + " Гб   Cвободно: " + drive.TotalFreeSpace / 1073741824 + " ГБ ");
                    }

                    int pos = Arrow.Arrows(2, drives.Length + 1);

                    Papku.Dirs(drives[pos - 2].Name);

                }
          

        }
    }
}