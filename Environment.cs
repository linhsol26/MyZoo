using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (Days % 10 == 0)
            {
                ChangeWeather();
            }
            Ecosystem.ForEach(v => v.Age++);
        }
        public List<Species> Select<T>() where T: Species // generic
        {
            return Ecosystem.FindAll(v => v is T);
        }
        public void Eliminate(double threshold) { }
        public void ChangeWeather() 
        {
            Random random = new Random();
            Weather = (WeatherType) Enum.GetValues(typeof(WeatherType)).GetValue(random.Next(0, 3)); // dont know if it works.
        }

        public void Spawn<T>(int quantity) where T : Species
        {
            int numOfSpeciesInEcosystem = Select<T>().Count;

            for (int j = 0; j < quantity; j++)
            {
                if (typeof(T) == typeof(Grass))
                {
                    Ecosystem.Add(new Grass(numOfSpeciesInEcosystem));
                }
                else if (typeof(T) == typeof(Rabbit))
                {
                    Ecosystem.Add(new Rabbit(numOfSpeciesInEcosystem));
                }
                else if (typeof(T) == typeof(Wolf))
                {
                    Ecosystem.Add(new Wolf(numOfSpeciesInEcosystem));
                }
                else
                {
                    Ecosystem.Add(new Eagle(numOfSpeciesInEcosystem));
                }
            }
 
        }
        public void Die<T>(string id) where T: Species
        {
            List<Species> slt = Select<T>();
            // slt.ForEach(v => v.Id == id ? Ecosystem.Remove(v) : null);
            for (int i = 0; i < slt.Count; i++)
            {
                if (slt[i].Id == id)
                {
                    Ecosystem.Remove(slt[i]);
                }
            }
        }

        public bool isExtinction()
        {
            return Ecosystem.Count == 0 ? true : false;
        }
    }
}
