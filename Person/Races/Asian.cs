using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Asian : Race
    {
        public override String Name { get { return "Asian"; }}

        public override double Height(int Age)
        {
            return 1.7 + ((Age + 2)  * 0.23);
        }

    }

}
