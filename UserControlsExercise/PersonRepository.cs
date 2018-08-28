using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlsExercise
{
    public static class PersonRepository
    {
        static List<Person> people = new List<Person>();

        public static List<Person> GetAllPersons()
        {
            return people;
            ;
        }

        public static void SaveNew(Person p)
        {
            people.Add(p);
        }

    }
}
