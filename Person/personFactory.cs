using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public abstract class PersonFactory
    {
        public abstract Person GetPerson(string name, int age, string race);
    }
}
