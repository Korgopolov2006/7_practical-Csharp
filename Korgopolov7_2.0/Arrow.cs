using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace Korgopolov7_2._0
{
    internal class Arrow
    {
        public static int Arrows(int min, int max)
        {
            int position = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine(">");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow && position != min)
                    position--;
                else if (key.Key == ConsoleKey.DownArrow && position != max)
                    position++;
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();    
                    return -99;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    return -111;
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    return -222;
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    return -333;
                }
                else if (key.Key == ConsoleKey.F4)
                {
                    return -444;
                }


            } while (key.Key != ConsoleKey.Enter);
            return position;
        }

    }
}


