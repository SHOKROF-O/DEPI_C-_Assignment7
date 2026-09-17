using System;

namespace Assignment_03
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("I am a Person.");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}");
        }
    }
}
