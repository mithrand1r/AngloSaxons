using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public abstract class Race
    {
        string Name;
        public abstract double Height(int Age);
    }
}
