using System;

namespace Assignment_03
{
    public class Vehicle : IVehicle
    {
        public virtual void MoveForward()
        {
            Console.WriteLine("Vehicle moving forward.");
        }

        public virtual void MoveBackward()
        {
            Console.WriteLine("Vehicle moving backward.");
        }

        public virtual void MoveUp()
        {
            Console.WriteLine("Vehicle moving up.");
        }

        public virtual void MoveDown()
        {
            Console.WriteLine("Vehicle moving down.");
        }
    }
}
