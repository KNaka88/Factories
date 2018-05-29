using System;

namespace Exercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}";
        }
    }

    public class PersonFactory
    {
        private int idCounter = 0;

        public PersonFactory(){}

        public Person CreatePerson(string name)
        {
            var personToReturn = new Person(){ Id = idCounter, Name = name };
            idCounter++;
            return personToReturn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personFactory = new PersonFactory();

            var person1 = personFactory.CreatePerson("John");
            var person2 = personFactory.CreatePerson("Erica");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
