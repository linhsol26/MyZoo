using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ecosystem trans to 2d array. (test this)
            Environment ev = new Environment();

            Console.Write("Enter number of Grass: ");
            int numOfGrass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of Rabbit: ");
            int numOfRabbit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of Wolf: ");
            int numOfWolf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of Eagle: ");
            int numOfEagle = Convert.ToInt32(Console.ReadLine());

            ev.Spawn<Grass>(numOfGrass);
            ev.Spawn<Rabbit>(numOfRabbit);
            ev.Spawn<Wolf>(numOfWolf);
            ev.Spawn<Eagle>(numOfEagle);

            while (!ev.isExtinction())
            {
                ev.NextDay();
                Console.WriteLine("Weather: " + ev.Weather + "\nTotal species: " + ev.Ecosystem.Count);

                dynamic sltGrass = ev.Select<Grass>();
                foreach (Grass grasses in sltGrass)
                {
                    grasses.Breed(ev);
                    grasses.AffectTo(ev.Weather);
                    grasses.Die(ev);
                }
                dynamic sltRabbit = ev.Select<Rabbit>();
                foreach (Rabbit rabbits in sltRabbit)
                {
                    rabbits.Breed(ev);
                    rabbits.Hunt(ev);
                    rabbits.Die(ev);
                }
                dynamic sltWolf = ev.Select<Wolf>();
                foreach (Wolf wolfs in sltWolf)
                {
                    wolfs.Breed(ev);
                    wolfs.Hunt(ev);
                    wolfs.AffectTo(ev.Weather);
                    wolfs.Die(ev);
                }
                dynamic sltEagle = ev.Select<Eagle>();
                foreach (Eagle eagles in sltEagle)
                {
                    eagles.Breed(ev);
                    eagles.Hunt(ev);
                    eagles.Fly();
                    eagles.Die(ev);
                }
                Console.WriteLine("Day: " + ev.Days);
                Console.WriteLine("Rabbit: " + (ev.Select<Rabbit>().Count));
                Console.WriteLine("Grass: " + (ev.Select<Grass>().Count));
                Console.WriteLine("Eagle: " + (ev.Select<Eagle>().Count));
                Console.WriteLine("Wolf: " + (ev.Select<Wolf>().Count) + "\n");
            }
            ev.Select<Wolf>().ForEach(v => Console.WriteLine(v.Age));
            Console.ReadLine();
        }
    }
}
