using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Wolf : Animal, IHuntable, IWeatherAffectable
    {
        public Wolf(int index)
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
        public void AffectTo(WeatherType weather)
        {
            if (weather == WeatherType.Cold)
            {
                Health *= 0.98;
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
                ev.Spawn<Wolf>(2);
            }
        }

        public override void Die(Environment ev)
        {
            if (Health < 5)
            {
                ev.Die<Wolf>(Id);
            }
        }
    }
}
