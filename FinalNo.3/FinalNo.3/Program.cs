using System;

namespace FinalNo._3
{
    class Program
    {
       


        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static int Combination(int n, int r)
        {
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }

        static float Max(float a, float b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static float Max3(float a, float b, float c)
        {
            return Max(Max(a, b), c);
        }
        static float Min(float a, float b)
        {
            if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static float Min3(float a, float b)
        {
            return (Min(a, b));
        }
        static void Main(string[] args)
        {
            int treeHeight = int.Parse(Console.ReadLine());
            float node1, node2;
            float RootNode = 0;

            for (int i = 0; i < treeHeight; i++)
            {
                node1 = float.Parse(Console.ReadLine());
                node2 = float.Parse(Console.ReadLine());
                
                if (i%2 == 0)
                {
                    RootNode = Min3(node1, node2);
                }
                else
                {
                    RootNode = Max3(node1, node2, RootNode);
                }
                Console.WriteLine(RootNode);
                Console.ReadLine();
            }
        }
    }
}