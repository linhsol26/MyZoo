using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Grass : Plant, IWeatherAffectable
    {
        public Grass(int index)
        {
            Id = index.ToString();
            Name = "";
            Gender = GenderType.Female;
            Weight = 10.0;
            Length = 10.0;
            Health = 100.0;
            Age = 1;
        }
        public void AffectTo(WeatherType weather)
        {
            switch(weather)
            {
                case WeatherType.Rain:
                    Weight *= 1.05;
                    break;
                case WeatherType.Hot:
                    Health *= 0.8;
                    break;
                case WeatherType.Cold:
                    Health *= 0.9;
                    break;
            }
        }

        public override void Breed(Environment ev)
        {
            if (Age > 1 && ev.Weather == WeatherType.Rain)
            {
                ev.Spawn<Grass>(2);
            }
        }
        public override void Die(Environment ev)
        {
            if (Health < 5)
            {
                ev.Die<Grass>(Id);
            }
        }
    }
}
