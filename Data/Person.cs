using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Data
{
    public class Person
    {
        private string name;
        private int age;


        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }      
    }
}
