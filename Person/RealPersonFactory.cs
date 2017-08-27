using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class RealPersonFactory:PersonFactory
    {
        public override Person GetPerson(string name, int age, string race) {
            return new RealPerson(name, age, race);
        }
    }
}
