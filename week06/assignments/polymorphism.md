# W06 Assignment: Polymorphism

Articulate the principle of polymorphism.

What is polymorphism and why is it important?
A: Polymorphism means many forms and is used in programming to define different outcomes/behavior of
the same feature or method that depends on the context it's applied to. This principal is used in
conjunction with objects and inheritance, when the child overrides the methods that were inherited
by it's parent class.

When working with complex abstractions this concept is powerful and handy because it allows to define
the behavior depending of the needs and context that it's been applied to. Like when you have a class
vehicle that is the base class (parent) and other derived classes (child) like car and airplane; these
classes have things in common and things that have different behaviors. In this example we have vehicles
that can fill the tank with different fuel types that are allowed for the kind of vehicle you're working
with.

```csharp
abstract class Vehicle
{
    private string _fuel;

    public string GetFuel() => _fuel;

    public abstract void FuelTank();
}

class Car : Vehicle
{
    public override void FuelTank()
    {
        Console.WriteLine($"A car fuels {GetFuel()} on the gas station.");
    }
}

class Airplane : Vehicle
{
    public override void FuelTank()
    {
        Console.WriteLine($"An airplane fuels {GetFuel()} on the airport.");
    }
}
```
