using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public static class PeopleManipulation
    {
        public static List<Person> InitPeople(PersonFactory factory)
        {
            var people = new List<Person>();

            var rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                people.Add(factory.GetPerson(
                    name: "Person #" + i.ToString(),
                    age: rnd.Next(1, 99),
                    race: RandomRace(i)
                ));
            }

            return people;
        }

        private static string RandomRace(int Seed)
        {
            var raceNames = new List<string>() { "Angle", "Saxon", "Jute", "Asian" };

            var rnd = new Random(Seed);

            int id = rnd.Next(0, 4);

            return raceNames[id];
        }
    }
      
}
