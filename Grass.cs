using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Grass : Plant, IWeatherAffectable
    {
        public void AffectTo(WeatherType weather)
        {
            switch(weather)
            {
                case WeatherType.Rain:
                    weight *= 1.05;
                    break;
                case WeatherType.Hot:
                    health *= 0.8;
                    break;
                case WeatherType.Cold:
                    health *= 0.9;
                    break;
            }
        }

        public override void Breed(Environment ev)
        {
            if (Age > 1 && (ev.Weather == WeatherType.Rain))
            {
                ev.Spawn<Grass>(1);
            }
        }
    }
}
