using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Environment
    {
        protected WeatherType weather;
        protected int days;
        protected List<Species> ecosystem;

        public WeatherType Weather { get; set; }
        public int Days { get; set; }
        public List<Species> Ecosystem { get; set; }

        public void NextDay() { }
        public List<Species> Select<T>() where T: Species // generic
        {
            return null;
        }
        public void Eliminate(double threshold) { }
        public void ChangeWeather() { }
        public void Hunt() { }
        public void Feed() { }
        public void Spawn<T>(int quantity) where T: Species { }
    }
}
