using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public interface IWeatherAffectable
    {
        void AffectTo(WeatherType weather);
    }
}
