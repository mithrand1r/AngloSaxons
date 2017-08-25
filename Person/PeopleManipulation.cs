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
            for (int i = 0; i < 1000; i++)
            {
                People.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99)
                });
            }
            return People;
        }
    }
      
}
