using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public abstract class Species
    {
        protected string id;
        protected string name;
        protected GenderType gender;
        protected double weight;
        protected double length;
        protected double health;
        protected int age;
        protected int breedingPeriod;

        public string Id { get; set; }
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Health { get; set; }
        public double Age { get; set; }
        public int BreedingPeriod { get; set; }

        public abstract void Breed(Environment ev);

    }
}
