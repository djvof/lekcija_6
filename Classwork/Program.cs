using System;
using System.Collections.Generic;


namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();


            nums.Add(15);
            nums.Add(9);
            foreach (var num in nums)
            {
                Console.WriteLine($"My num is: {num}");
            }

            var persons = new List<Person>();

            Person artisPerson = new Person
            {
                Name = "Artis",
                Age = 48

            };
            persons.Add(artisPerson);
            persons.Add(artisPerson);
            persons.Add(artisPerson);


            persons.Remove(artisPerson);
            persons.RemoveAt(1);

            foreach (var person  in persons)
            {
                Console.WriteLine($"Name : {person.Name} , Age: {person.Age}");
            }



            //========== Vardnicas

            var personsByName = new Dictionary<string, List<Person>>();

            personsByName.Add("list1", new List<Person>());

            List<Person> artisPersons = personsByName["list 1"];
            artisPersons.Add(artisPerson);
            artisPersons.Add(artisPerson);

            Person emilsPerson = new Person
            {
                Name = "Emils",
                Age = 47
            };

            personsByName.Add("list 2", new List<Person>());
            List<Person> emilsPersons = personsByName["list 2"];
            emilsPersons.Add(emilsPerson);

            foreach (KeyValuePair<string, List<Person>> item in personsByName)
            {
                Console.WriteLine($"        Now printing {item.Key} list");

                foreach (var person in item.Value)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }








            Console.ReadLine();
        }
    }
}
