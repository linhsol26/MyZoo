using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Wolf : Animal, IHuntable, IWeatherAffectable
    {
        public Wolf()
        {
            breedingPeriod = 10;
        }
        public void AffectTo(WeatherType weather)
        {
            if (weather == WeatherType.Cold)
            {
                health *= 0.98;
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
                    health += 5;
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
                ev.Die<Wolf>(id);
            }
        }
    }
}
