using System;

namespace Assignment_03
{
    public class Doctor : Person
    {
        public string Specialty { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am a Doctor.");
        }

        public override void Display()
        {
            Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}, Specialty = {Specialty}");
        }
    }
}
