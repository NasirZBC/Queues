using System.Collections.Generic;

namespace Queues.Data
{
    public class data
    {
        public data()
        {
        }

        //queue of Person
        public Queue<Person> people = new Queue<Person>();

        public void PersonInitializer(Person p)
        {
            people.Enqueue(p);
        }
    }
}