using System;

namespace Assignment_03
{
    public class Engineer : Person
    {
        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        public override void Display()
        {
            Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}, Field = {Field}, Years Of Experience = {YearsOfExperience}");
        }
    }
}
