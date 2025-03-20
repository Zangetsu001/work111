using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bus
    {
        string mark;
        double count;
        double tickets;
        public string Mark
        {
            get
            {
                return mark;
            }
            set 
            { 
                mark = value ?? throw new ArgumentException("Марка автобуса пустой не должна быть");
            }
        }
        public double Count
        {
            get 
            { 
                return count;
            }
            set 
            {
                count = value >= 1 ? value : throw new ArgumentException("Должно быть хоть 1 место");
            }
        }
        public double Tickets
        {
            get
            { 
                return tickets; 
            }
            set 
            {
                tickets = value >= 0 ? value : throw new ArgumentException("Нельзя брать в долг");
            }
        }
        public Bus() { }
        public Bus(string mark)
        {
            this.mark = mark;
        }
        public Bus(string mark, double count) : this(mark)
        {
            this.count = count;
        }
        public Bus(string mark, double count, double tickets) : this(mark, count)
        {
            this.tickets = tickets;
        }
        public void Output()
        {
            Console.WriteLine($"Марка автобуса: {Mark}\nКоличество мест: {Count}\nСтоимость билета: {Tickets}");
        }
        public double Summ()
        {
            return Count * Tickets;
        }
        
    }
}
