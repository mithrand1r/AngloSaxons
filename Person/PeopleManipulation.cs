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
            var people      = new List<Person>();
            var rnd         = new Random();
            int totalPeople = 10000;

            int degreeOfParallelism = Environment.ProcessorCount;
            int recordsPerThread = totalPeople / degreeOfParallelism;

            Parallel.For(0, degreeOfParallelism, workerId =>
            {
                int startPos        = workerId * recordsPerThread;
                var threadPeople    = new List<Person>();
                int endPos          = startPos + recordsPerThread;

                for (int i = startPos; i < endPos; i++)
                {
                    threadPeople.Add(factory.GetPerson(
                        name: "Person #" + i.ToString(),
                        age: rnd.Next(1, 99),
                        race: RandomRace(i)
                    ));
                }
                lock(people) { 
                    people.AddRange(threadPeople);
                }

            });
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
