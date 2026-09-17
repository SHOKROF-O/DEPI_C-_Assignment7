using System;

namespace Assignment_03
{
    internal class Program
    {
        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }

        static void Main(string[] args)
        {
            #region Part 1 - Static Binding (new)

            Shape shape = new Shape(2, 3);
            Console.WriteLine(shape.Area()); // 6

            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine(cube.Area()); // 24 (base Area * Depth)

            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine(shapeRef.Area());
            // this prints 6, not 24.
            // Area() is hidden with "new" not overridden, so the compiler
            // decides which version to call based on the declared type of
            // the reference (Shape), not the actual object type (Cube).
            // this is early/static binding, resolved at compile time.

            Console.WriteLine("----------------------------------");

            object obj = new Cube(1, 2, 3);
            Console.WriteLine(obj.ToString());
            // ToString() is virtual in System.Object, so it can be
            // overridden and is resolved at runtime based on the actual
            // object type. this is late/dynamic binding.
            // Area() behaved differently from ToString() because Area()
            // uses "new" (hides the base method) while ToString() uses
            // "override" (replaces the base method polymorphically).

            #endregion

            Console.WriteLine("----------------------------------");

            #region Part 2 - Dynamic Binding (virtual / override)

            Person doctorPerson = new Doctor { ID = 1, Name = "Ahmed", Age = 35, Specialty = "Cardiology" };
            ProcessPerson(doctorPerson);
            // Greet() prints "I am a Person." because Greet() is hidden
            // with "new", so it's resolved by the reference type (Person)
            // at compile time.
            // Display() prints the Doctor version because Display() is
            // virtual/override, so it's resolved by the actual object
            // type (Doctor) at runtime.

            Console.WriteLine("----------------------------------");

            Person engineerPerson = new Engineer { ID = 2, Name = "Mona", Age = 28, Field = "Software", YearsOfExperience = 5 };
            ProcessPerson(engineerPerson);

            // Q8: if virtual is removed from Display() in Person, the
            // "override" keyword in Doctor/Engineer would no longer be
            // valid and the compiler gives an error ("cannot override
            // inherited member because it is not marked virtual").
            // Display() would then need to use "new" instead, and it
            // would behave like Greet() (static binding).

            #endregion

            Console.WriteLine("----------------------------------");

            #region Part 3 - Interfaces

            // Q9: without interfaces, every vehicle class (Car, Ship,
            // Airplane) would be forced to implement MoveUp()/MoveDown()
            // even if it makes no sense for that vehicle (a car can't
            // fly). interfaces let each class implement only the
            // behavior that actually applies to it.

            Car car = new Car();
            car.MoveForward();
            car.MoveBackward();

            Console.WriteLine("----------------------------------");

            Ship ship = new Ship();
            // ship.MoveForward(); // this line does NOT compile,
            // because MoveForward() is implemented explicitly in Ship,
            // so it's only reachable through an IMoveable reference
            IMoveable shipRef = ship;
            shipRef.MoveForward();
            ship.MoveBackward();

            Console.WriteLine("----------------------------------");

            Airplane airplane = new Airplane();
            airplane.MoveForward();
            airplane.MoveBackward();
            airplane.MoveUp();
            airplane.MoveDown();

            Console.WriteLine("----------------------------------");

            IMoveable carRef = new Car();
            IMoveable planeRef = new Airplane();
            carRef.MoveForward();
            carRef.MoveBackward();
            planeRef.MoveForward();
            planeRef.MoveBackward();
            // planeRef.MoveUp(); // this line does NOT compile,
            // because planeRef is declared as IMoveable, which doesn't
            // have MoveUp(), even though the actual object is an
            // Airplane. to call MoveUp() we would need an IFlyable
            // reference instead.

            Console.WriteLine("----------------------------------");

            Vehicle vehicle = new Vehicle();
            vehicle.MoveForward();
            vehicle.MoveBackward();
            vehicle.MoveUp();
            vehicle.MoveDown();
            // Q13: IVehicle inheriting from both IMoveable and IFlyable
            // lets a class implement one interface (IVehicle) instead of
            // two separate ones, while still guaranteeing all four
            // methods exist.

            #endregion
        }
    }
}

// Q15:
// Feature                          | Static Binding (new) | Dynamic Binding (override)
// Keyword in base                  | none needed           | virtual
// Keyword in derived               | new                   | override
// Resolved at                      | compile time           | runtime
// Behavior via base reference      | runs base version      | runs derived version

// Q16:
// override needs virtual on the base method because C# has to know in
// advance that the method is meant to support polymorphism, so it can
// set up the dynamic dispatch mechanism (like a v-table entry) for it.
// "new" doesn't need that, because it doesn't replace the base method
// at all, it just declares a separate method with the same name that
// hides the base one when accessed through the derived type.
