using System;

namespace FinalNo._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int[,] Number = new int[3, 3];
            Number[0, 0] = int.Parse(Console.ReadLine());
            Number[0, 1] = int.Parse(Console.ReadLine());
            Number[0, 2] = int.Parse(Console.ReadLine());
            Number[1, 0] = int.Parse(Console.ReadLine());
            Number[1, 1] = int.Parse(Console.ReadLine());
            Number[1, 2] = int.Parse(Console.ReadLine());
            Number[2, 0] = int.Parse(Console.ReadLine());
            Number[2, 1] = int.Parse(Console.ReadLine());
            Number[2, 2] = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    Console.Write(Number[x, y]);
                    Console.Write("");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("The number is available");
            Console.ReadLine();
        }
    }
}
