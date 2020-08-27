using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Eagle : Animal, IHuntable, IFly, IFight
    {
        private int flyed = 0;

        public Eagle(int index)
        {
            Id = index.ToString();
            Name = "";
            Gender = GenderType.Female;
            Weight = 10.0;
            Length = 10.0;
            Health = 100;
            Age = 1;
            BreedingPeriod = 10;
        }
        public void Fight(Environment ev)
        {
            List<Species> wolfs = ev.Select<Wolf>();
            Random random = new Random();
            Wolf selection = wolfs[random.Next(0, wolfs.Count)] as Wolf;
            selection.Health *= 0.8;
            Health *= 0.95;
        }

        public void Fly()
        {
            flyed += 1;
            if (flyed % 5 == 0)
            {
                Health *= 0.8;
            }
        }

        public void Hunt(Environment ev)
        {
            List<Species> food = ev.Select<Rabbit>();
            if (food.Count != 0)
            {
                ev.Ecosystem.Remove(food[0]);
            }
            else
            {
                Health *= 0.5;
            }
        }

        public override void Breed(Environment ev)
        {
            if (Age % BreedingPeriod == 0)
            {
                ev.Spawn<Eagle>(2);
            }
        }

        public override void Die(Environment ev)
        {
            if (Health < 5)
            {
                ev.Die<Eagle>(Id);
            }
        }
    }
}
