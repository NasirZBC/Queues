using System.Collections.Generic;

namespace Queues.Data
{
    internal class dataManager
    {
        //queue of Person
        public Queue<Person> People = new Queue<Person>();

        private dataManager()
        {
            //add to list People
            People.Enqueue(this.first);
            People.Enqueue(this.second);
            People.Enqueue(this.third);
            People.Enqueue(this.fourth);
            People.Enqueue(this.fifth);
            People.Enqueue(this.sixth);

            People.Dequeue();
        }

        //instances of Person
        private Person first = new Person("Joe", 25);
        private Person second = new Person("Jake", 21);
        private Person third = new Person("Jones", 23);
        private Person fourth = new Person("Jenny", 26);
        private Person fifth = new Person("James", 25);
        private Person sixth = new Person("Jamie", 24);
    }
}