using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Environment ev = new Environment();
            Grass grass = new Grass();
            while(ev.Days < 100)
            {
                ev.NextDay();
                grass.Age++;
                grass.Breed(ev);
                Console.WriteLine(ev.Weather);
            }
            ev.Ecosystem.ForEach(v => Console.WriteLine(v));
            Console.WriteLine(ev.Ecosystem.Count);
            Console.ReadLine();
        }
    }
}
