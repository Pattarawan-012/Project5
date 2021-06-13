using System;
using System.Collections;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input size  : ");
            int row = int.Parse(Console.ReadLine());
            int[] ar1 = new int[row];
            Console.WriteLine("This  size{0}", row);
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Equal - {0} ", i);
                ar1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < row; j++)
                {
                    if (ar1[j] < ar1[i])
                    {
                        int tem = ar1[i];
                        ar1[i] = ar1[j];
                        ar1[j] = tem;

                    }
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(ar1[i]);
                Console.Write("");
            }
            Console.WriteLine("\n\n");
           

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
