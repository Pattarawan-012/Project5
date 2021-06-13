using System;

namespace ConsoleApp12
{
    class Program
    {
        public enum city
        {

            New_York,
            Los_Angeles,
            Chicago,
            Houston,
            Phoenix,
            Philadelphia,
            San_Antonio,
            San_Diego,
            Dallas,
            San_Jose,
            Detroit,
            San_Francisco
        }
        static void Main(string[] args)
        {
            Console.Write("Input Many City : ");
            int city = int.Parse(Console.ReadLine());
            int Level = 0;
            string word;
            for (int i = 0; i < city; i++)
            {
                Level.ToString();
                city CityLoop;
                CityLoop = (city)i;
                Console.WriteLine("{0} = {1}", CityLoop, Level);
            }
        }
        static void Vaccinate()
        {
            Console.WriteLine("0 Prontera 3");
            Console.WriteLine("1 Geffen 3 ");
            Console.WriteLine("2 Morroc 3");
            Console.WriteLine("3 Payon 3");
            Console.WriteLine("4 Alberta 0");
            Console.WriteLine("5 Al De Baran 1");
            Console.WriteLine("6 Yuno 0");
            Console.WriteLine("7 Izude 0");
        }
        
    }
}
