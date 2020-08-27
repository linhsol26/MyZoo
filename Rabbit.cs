using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Rabbit : Animal, IHuntable
    {
        public Rabbit(int index)
        {
            Id = index.ToString();
            Name = "";
            Gender = GenderType.Female;
            Weight = 10.0;
            Length = 10.0;
            Health = 100.0;
            Age = 1;
            BreedingPeriod = 5;
        }
        public void Hunt(Environment ev)
        {
            List<Species> slt = ev.Select<Grass>();
            if (slt.Count != 0)
            {
                ev.Ecosystem.Remove(slt[0]);
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
                ev.Spawn<Rabbit>(1);
            }
        }
        public override void Die(Environment ev)
        {
            if (Health < 5)
            {
                ev.Die<Rabbit>(Id);
            }
        }
    }
}
