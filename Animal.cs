using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public abstract class Animal : Species
    {
        public override void Breed(Environment ev)
        {
            throw new NotImplementedException();
        }
    }
}
