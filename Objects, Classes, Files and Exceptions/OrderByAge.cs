using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }

    class OrderByAge
    {
        static void Main()
        {
            var people = new List<Person>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var personTokens = input.Split(' ').ToArray();
                var name = personTokens[0];
                var id = personTokens[1];
                var age = int.Parse(personTokens[2]);

                Person person = new Person();
                person.Name = name;
                person.ID = id;
                person.Age = age;

                people.Add(person);

                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
