﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Jute : Race
    {
        public override String Name { get { return "Jute"; } }
        public override double Height(int Age)
        {
            return ((Age * 1.6)/2);
        }

    }

}
