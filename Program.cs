using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus("Мерседес", 20, 3);
            bus1.Summ();
            Console.WriteLine();

            TouristBus touristBus = new TouristBus("Мерседес", 35, 4, 30);
            touristBus.Summ();
            Console.WriteLine();

            int N = 5;
            TouristBus[] touristBus1 = new TouristBus[N];
            touristBus1[0] = new TouristBus("Мерседес", 43, 4, 23);
            touristBus1[1] = new TouristBus("Мерседес", 43, 4, 23);
            touristBus1[2] = new TouristBus("Мерседес", 43, 4, 23);
            touristBus1[3] = new TouristBus("Мерседес", 43, 4, 23);
            touristBus1[4] = new TouristBus("Мерседес", 43, 4, 23);
            touristBus1[5] = new TouristBus("Мерседес", 43, 4, 23);
            Console.Read();


        }
    }
}
