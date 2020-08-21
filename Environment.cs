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
        public List<Species> Ecosystem { get; set; } = new List<Species>();

        public void NextDay() 
        {
            Days++;
            ChangeWeather();
        }
        public List<Species> Select<T>() where T: Species // generic
        {
            return null;
        }
        public void Eliminate(double threshold) { }
        public void ChangeWeather() 
        {
            Random random = new Random();
            Weather = (WeatherType) Enum.GetValues(typeof(WeatherType)).GetValue(random.Next(0, 3)); // dont know if it works.
        }
        public void Hunt() { }
        public void Feed() { }
        public void Spawn<T>(int quantity) where T : Species, new()
        {
            IEnumerable<T> collection = Ecosystem.OfType<T>(); // doesnt work.
            Console.WriteLine(collection.Count());
            // get the length of the objects type T. (not solve)
            for (int i = 0; i < collection.Count(); i++)
            {
               for (int j = 0; j < quantity; j++)
               {
                    Ecosystem.Add(new T()); // dont know if it works.
               }
            }
 
        }
        public void Die<T>(string id) where T: Species
        {
            ecosystem.RemoveAt(ecosystem.FindIndex(x => x.Id == id));
        }

        public bool isExtinction()
        {
            return Ecosystem.Count == 0 ? true : false;
        }
    }
}
