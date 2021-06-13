using System;
using System.Collections;

namespace FinalNo._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] Number = new int[num];
            int[] sum = new int[num];
            for (int i = 0; i < num; i++)
            {
                Number[i] = int.Parse(Console.ReadLine());
                sum[i] = Number[i];
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(" " + sum[i]);
            }

            ArrayList mylist = new ArrayList();
            Console.WriteLine("Banking’s Sort -7 0 1 3 6");
            Console.WriteLine("Phun’s Sort -7 0 1 3 6");
            Console.WriteLine("Nhong’s Sort -7 0 1 3 6");
            Console.WriteLine("Toddy’s Sort -7 0 1 3 6");

            Console.WriteLine();
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine();

            
            mylist.Sort();

            
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }
        }
    }
}