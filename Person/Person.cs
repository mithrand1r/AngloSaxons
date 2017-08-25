using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }
        public override string ToString()
        {
            return String.Format("My name is {0} and I am {1} years", Name, Age);
        }

        public double height{
            get
            {
                return Race.Height(Age);
            }
        }
    }
}
