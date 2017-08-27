using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public abstract class Person
    {
        public abstract string Name { get;}
        public abstract int Age { get; }
        public abstract string Race { get; }
        public abstract override string ToString();
        public abstract double Height { get; }
        public abstract void AddYearsToAge(int years);
    }
}
