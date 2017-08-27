using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    static class HeightCalculation
    {
        public static double AngloSaxon(int age)
        {
            return 1.5 + (age * 0.45);
        }
        public static double Jute(int age)
        {
            return ((age * 1.6) / 2);
        }
        public static double Asian(int age)
        {
            return 1.7 + ((age + 2) * 0.23);
        }

        public static double Caucasian(int age)
        {
            return age * 0.1;
        }

    }
}
