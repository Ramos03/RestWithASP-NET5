using RestWithASPNET.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long ID)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }
        public Person FindByID(long ID)
        {
            return new Person
            { 
                Id = IncrementAndGet(),
                FirstName = "Vinicius",
                LastName = "Ramos",
                Address = "Indaiatuba São Paulo - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Last Name" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
