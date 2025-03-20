using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TouristBus : Bus
    {
        double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value >= 0 ? value : throw new ArgumentException("Стоимость не может уходить в минус");
            }
        }
        public TouristBus() { }
        public TouristBus(string mark, int count, double tickets, double price) : base(mark, count, tickets)
        {
            this.price = price;
        }
        public double Summ1()
        {
            return Count * Tickets * Price;
        }
        public void Output1()
        {
            Console.WriteLine($"Марка автобуса: {Mark}\nКоличество билетов: {Count}\n стоимость билета: {Tickets}\nСтоимость Экскурсии: {Price}");
        }
    }
}
