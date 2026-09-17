using System;

namespace Assignment_03
{
    public class Ship : IMoveable
    {
        // explicit interface implementation (Q14):
        // this version can only be called through an IMoveable reference,
        // not directly on a Ship object
        void IMoveable.MoveForward()
        {
            Console.WriteLine("Ship moving forward on the sea.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Ship moving backward on the sea.");
        }
    }
}
