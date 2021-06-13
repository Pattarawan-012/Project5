using System;

namespace Final_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float MAX1 = 0;
            float MIN1 = 0;
            float MEAN = 0;
            float X = 0;
            string Number;
            string Find;

            Number = Console.ReadLine();
            if (Number != "End")
            {
                MAX1 = float.Parse(Number);
                MIN1 = float.Parse(Number);
                MEAN += float.Parse(Number);
            }
            while (Number != "End")
            {
                Number = Console.ReadLine();
                if (Number != "End")
                {
                    if (float.Parse(Number) > MAX1)
                    {
                        MAX1 = float.Parse(Number);
                    }
                    if (float.Parse(Number) < MIN1)
                    {
                        MIN1 = float.Parse(Number);
                    }
                    MEAN += float.Parse(Number);
                    X++;
                }
            }
            Find = Console.ReadLine();
            while (Find != "FindMax " || Find != " FindMin " || Find != "FindMean")
            {
                if (Find == "FindMax")
                {
                    Console.Write(MAX1);
                }
                else
                if (Find == "FindMin")
                {
                    Console.Write(MIN1);
                }
                else
                if (Find == "FindMean")
                {
                    Console.Write(MEAN / X);
                }
                else
                {
                    Console.Write("Invalid mode");
                }
            }
        }
    }
}
