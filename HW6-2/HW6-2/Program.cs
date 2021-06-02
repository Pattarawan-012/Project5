using System;

namespace HW6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Product1, Product2, Product3, Product4;
            double price1, price2, price3, price4;

            Console.Write("Input name of Product1 : ");
            Product1 = Console.ReadLine();
            Console.Write("Input price of Product1 : ");
            price1 = double.Parse(Console.ReadLine());

            Console.Write("Input name of Product2 : ");
            Product2 = Console.ReadLine();
            Console.Write("Input price of Product2 : ");
            price2 = double.Parse(Console.ReadLine());

            Console.Write("Input name of Product3 : ");
            Product3 = Console.ReadLine();
            Console.Write("Input price of Product3 : ");
            price3 = double.Parse(Console.ReadLine());

            Console.Write("Input name of Product4 : ");
            Product4 = Console.ReadLine();
            Console.Write("Input price of Product4 : ");
            price4 = double.Parse(Console.ReadLine());

            double Result, yourmoney;
            Result = price1 + price2 + price3 + price4;
            Console.WriteLine("Result = " + Result);

            Console.Write("Please input amount of money do you have : ");
            yourmoney = double.Parse(Console.ReadLine());
            yourmoney = yourmoney - Result;

            if (Result > yourmoney)
            {
                Console.WriteLine("You have enough money for pray.");
            }
            else
            {
                Console.WriteLine("You have not enough money for pray!!!");
            }
        }
    }
}

