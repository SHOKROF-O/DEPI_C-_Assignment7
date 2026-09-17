# Assignment 3 - OOP

C# - ASP.Net Course

Session 07: Binding, Polymorphism & Interfaces.

## Part 1 - Static Binding (new)

- **Shape.cs** - base class with Width, Height and Area().
- **Cube.cs** - inherits from Shape, adds Depth, hides Area() with `new` so it returns base.Area() * Depth.

Calling Area() through a `Shape` reference (even if the actual object is a `Cube`) always runs Shape's version, because `new` is resolved at compile time based on the reference type.

## Part 2 - Dynamic Binding (virtual / override)

- **Person.cs** - base class with Greet() (normal method) and Display() (virtual).
- **Doctor.cs**, **Engineer.cs** - both hide Greet() with `new` and override Display().

Calling Greet() through a `Person` reference always runs Person's version. Calling Display() through the same reference runs the actual derived class's version, because `override` is resolved at runtime based on the real object type.

## Part 3 - Interfaces

- **IMoveable.cs** - MoveForward(), MoveBackward().
- **IFlyable.cs** - MoveUp(), MoveDown().
- **IVehicle.cs** - inherits both IMoveable and IFlyable.
- **Car.cs** - implements IMoveable normally.
- **Ship.cs** - implements MoveForward() explicitly (can only be called through an IMoveable reference).
- **Airplane.cs** - implements both IMoveable and IFlyable.
- **Vehicle.cs** - implements IVehicle, all methods marked virtual.

## Program.cs

Runs all three parts one after another, with the theory questions (why each output happens, comparison table, etc.) answered as comments next to the relevant code.
