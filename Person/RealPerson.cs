using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class RealPerson:Person
    {

        string  _name;
        int     _age;
        Race    _race;

        public RealPerson(string name="JohnDoe", int age=30, string race="Caucasian")
        {
            _name = name;
            _age = age;
            _race = new Race(race);
        }

        public override string Name { get { return _name; } }
        public override int Age { get { return _age; } }
        public override string Race { get { return _race.Name; } }
        public override string ToString()
        {
            return String.Format("My name is {0} and I am {1} years", Name, Age);
        }
        public override double Height
        {
            get { return _race.Height(Age);}
        }
    }
}
