using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double HeightCalculation(int Age);

namespace People
{
    public abstract class Race
    {
        public abstract string Name { get;}
        public abstract double Height(int Age);
    }
}
