using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Render
    {
        public Render() { }
        public void addSpecies<T>(int quantity, Environment ev) where T : Species, new()
        {
            for (int i = 0; i < quantity; i++)
            {
                ev.Ecosystem.Add(new T());
            }
        }
    }
}
