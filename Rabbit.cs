using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Rabbit : Animal, IHuntable
    {
        public Rabbit()
        {
            breedingPeriod = 5;
        }
        public void Hunt(Environment ev)
        {
            List<Species> food = ev.Select<Grass>();
            // Grass selection = food[random.Next(0, food.Count)] as Grass;
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i].Health != 0)
                {
                    food[i].Health = 0;
                    return;
                }
            }
            health *= 0.5;
        }

        public override void Breed(Environment ev)
        {
            if (age % breedingPeriod == 0)
            {
                ev.Spawn<Rabbit>(1);
            }
        }
    }
}
