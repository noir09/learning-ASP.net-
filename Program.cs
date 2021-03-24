using System;
using System.Collections.Generic;

namespace _5_kyu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Soldiers = new List<int>();
            List<int> IsDead = new List<int>();
            int kill=2;
            int save = 0;
            for (int i = 1; i <= 40; i++)
            {
                Soldiers.Add(i);
            }
            for (int i = 0; Soldiers.Count!>=0 ; i++)
            {
                Console.Write("[");
                for (int g = 0; g < Soldiers.Count; g++)
                {
                    if (g != 0) Console.Write(",");
                    Console.Write(Soldiers[g]);
                }
                Console.Write("]");

                if (Soldiers.Count == 40)
                {
                    Console.Write(" - initial sequence");
                }
                else
                {
                    Console.Write($"=> {save} is counted out and goes into the result [");
                    for (int g = 0; g < IsDead.Count; g++)
                    {
                        if (g != 0) Console.Write(",");
                        Console.Write(IsDead[g]);
                    }
                    Console.Write("]");
                    if (Soldiers.Count == 0)
                    {
                        Console.WriteLine();
                        Console.Write("josephus ([");

                        for (int g = 1; g <= 40; g++)
                        {
                            Soldiers.Add(g);
                            if (g != 1) Console.Write(",");
                            Console.Write(Soldiers[g-1]);
                        }
                        Console.Write("],3)==[");
                        for (int g = 1; g <= 40; g++)
                        {
                            if (g != 1) Console.Write(",");
                            Console.Write(IsDead[g - 1]);
                        }
                        Console.Write("]");
                        break;
                    }
                    kill = (kill + 2) % Soldiers.Count;
                }
                save = Soldiers[kill];
                IsDead.Add(Soldiers[kill]);
                Console.WriteLine();
                Soldiers.RemoveAt(kill);
            }
        }
    }
}
