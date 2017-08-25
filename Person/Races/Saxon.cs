using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Saxon : Race
    {
        public override String Name { get { return "Saxon"; } }
        public override double Height(int Age)
        {
            return 1.5 + (Age * 0.45);
        }

    }

}
