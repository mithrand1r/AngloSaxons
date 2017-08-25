using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public static class PeopleManipulation
    {
        public static List<Person> InitPeople()
        {
            List<Person> People = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                People.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99),
                    Race = RandomRace(i)
                });
            }
            return People;
        }

        private static Race RandomRace(int Seed)
        {
            Random rnd = new Random(Seed);
            int Race = rnd.Next(1, 5);
            switch (Race) {
                case 1:
                    return new Angle();
                case 2:
                    return new Saxon();
                case 3:
                    return new Jute();
                default:
                    return new Asian();
            }
        }
    }
      
}
