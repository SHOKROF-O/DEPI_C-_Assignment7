using System;

namespace Assignment_03
{
    public class Car : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Car moving forward on the ground.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car moving backward on the ground.");
        }
    }
}
