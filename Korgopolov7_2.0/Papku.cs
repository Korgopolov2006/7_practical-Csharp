using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korgopolov7_2._0
{
    internal class Papku
    {
        public static void Dirs(string s)
        {
            //try {  

                if (Directory.Exists(s))
                {
                    
                    while (true)
                    {

                        Console.Clear();
                        Console.SetCursorPosition(0, 3);
                        Console.WriteLine($"{"F1 - Добавление файла",120}");
                        Console.SetCursorPosition(0, 4);
                        Console.WriteLine($"{"F2 - Добавление директории",120}");
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine($"{"F3 - Удаление файла",120}");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine($"{"F4 - Удаление директории",120}");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine($"{"Название",15} {"Дата создания",38} ");//{"Тип",39}//");

                        string[] Directories = Directory.GetDirectories(s);
                        for (int i1 = 0; i1 < Directories.Length; i1++)
                        {
                            string Direct = Directories[i1];
                            Console.Write("  " + Direct);


                            Console.SetCursorPosition(30, i1 + 3);
                            Console.WriteLine("\t\t" + Directory.GetCreationTime(Direct));
                        }

                        string[] files = Directory.GetFiles(s);
                        for (int i2 = 0; i2 < files.Length; i2++)
                        {
                            string file = files[i2];
                            Console.Write("  " + file);


                            Console.SetCursorPosition(30, i2 + 3 + Directories.Length);
                            Console.WriteLine("\t\t" + Directory.GetCreationTime(file));

                        }


                        int position = Arrow.Arrows(3, Directories.Length + files.Length + 2);

                        if (position == -99)
                            return;

                        else if (position == -111)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название файла ,который хотите создать");
                            DP.DP1(s);
                        }

                        else if (position == -222)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название папки, которую хотите создать");
                            DP.DP2(s);
                        }

                        else if (position == -333)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название файла , которую хотите удалить");
                            DP.DP3(s);
                        }
                        else if (position == -444)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название папки , которую хотите удалить");
                            DP.DP3(s);
                        }

                        else if (position < Directories.Length)
                            Dirs(Directories[position + 3]);
                        else
                            Dirs(files[position - Directories.Length + 3]);


                        //Dirs(Directories[position - 3]);
                        //Dirs(files[position - Directories.Length - 3]);


                    }
                }
                else
                {

                    Process.Start(new ProcessStartInfo { FileName = s, UseShellExecute = true });
                }
            //}
            //catch (System.Exception e)
            //{
                  //Console.Clear() ;
               //Console.WriteLine($"Error: {e.Message}");

            //}
        }
    }
}
 
