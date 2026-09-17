using System;

namespace Assignment_03
{
    public class Airplane : IMoveable, IFlyable
    {
        public void MoveForward()
        {
            Console.WriteLine("Airplane moving forward in the air.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Airplane moving backward in the air.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplane moving up.");
        }

        public void MoveDown()
        {
            Console.WriteLine("Airplane moving down.");
        }
    }
}
