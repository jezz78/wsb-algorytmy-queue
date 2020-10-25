using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wariant_c
{
    class wariant_c
    {
        static void Main(string[] args)
        {
            string val;
            Queue<string> qt = new Queue<string>();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                
                //dodawanie elementu
                if ((key == ConsoleKey.Add) || (key == ConsoleKey.OemPlus))
                {
                    Console.Write("+ ");
                    val = Console.ReadLine();
                    qt.Enqueue(val);
                }

                //usuniecie pierwszego elementu
                else if ((key == ConsoleKey.Subtract) || (key == ConsoleKey.OemMinus))
                {
                    Console.WriteLine("-");
                    if (qt.Count != 0)
                    {
                        qt.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Queue is empty!");
                    }
                }

                //biezacy element
                else if (key == ConsoleKey.OemPeriod)
                {
                    Console.WriteLine(".");
                    if (qt.Count != 0)
                    {
                        Console.WriteLine(qt.Peek());
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Queue is empty!");
                    }
                }

                //ilosc elementow w kolejce
                else if (key == ConsoleKey.D1)
                {
                    Console.WriteLine("!");
                    Console.WriteLine(qt.Count);
                }

                //sprawdzenie czy jest w kolejce
                else if (key == ConsoleKey.Oem2)
                {
                    Console.Write("? ");
                    val = Console.ReadLine();
                    if (qt.Contains(val))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}