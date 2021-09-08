namespace Queues
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name_, int age_)
        {
            this.name = name_;
            this.age = age_;
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