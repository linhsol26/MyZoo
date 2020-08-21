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

        public Eagle()
        {
            breedingPeriod = 10;
        }
        public void Fight(Environment ev)
        {
            List<Species> wolfs = ev.Select<Wolf>();
            Random random = new Random();
            Wolf selection = wolfs[random.Next(0, wolfs.Count)] as Wolf;
            selection.Health *= 0.8;
            health *= 0.95;
        }

        public void Fly()
        {
            flyed += 1;
            if (flyed % 5 == 0)
            {
                health *= 0.8;
            }
        }

        public void Hunt(Environment ev)
        {
            List<Species> food = ev.Select<Rabbit>();
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i].Health != 0)
                {
                    food[i].Health = 0;
                    length *= 1.02;
                    weight *= 1.02;
                    return;
                }
            }
            health *= 0.5;
        }

        public override void Breed(Environment ev)
        {
            if (age % breedingPeriod == 0)
            {
                ev.Spawn<Wolf>(2);
            }
        }

        public override void Die(Environment ev)
        {
            if (health < 5)
            {
                ev.Die<Eagle>(id);
            }
        }
    }
}
