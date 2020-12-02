using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021220DobbelsteenMuntOefening.Models
{
    public abstract class RandomElement
    {
        private readonly Random generator;

        public RandomElement()
        {
            generator = new Random();
        }

        public Random GetGenerator()
        {         
           return generator;
        }

        public abstract int Gooi();
        
    }
}
