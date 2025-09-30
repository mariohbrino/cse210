# W05 Assignment: Explain Inheritance

Articulate the principle of inheritance.

- What is inheritance and why is it important?
A: Inheritance is a mechanism for code reusability, allowing a new class to inherit properties and methods from another class.
This grants code reusability, reduces redundancy, code maintainability, and creates hierachical relationship where specific
classes gain behaviors from general classes.

The key benefits of inheritance are the reusability and reduction of redundancy making it simple to add new features and properties
that will be shared among child classes. This turns the project more reliable and simple to maintain, along with the option to add
more specific classes as the complexity of the application requires.

When working with complex abstractions the inheritance mechanism helps to define common interfaces that can be extend to more specific
behavior or characteristics that an object requires to provide the necessary functionality. An example of this is an Vehicle that has
some generic attributes like color and speed that can describe some general characteristics of the vehicle, however there are more
specific vehicles like cars, airplanes, boats, and more that has specifics like can fly or can float. In the previous example its clear
that some vehicles have differenct characteristics that set them apart of each category that are not necessary for each type of vehicle.

class Vehicle
{
    private string _color;
    private double _speed;
    private double _weight;
    private double _payload_capacity;
    private Dimensions _dimensions;

    public void Moving()
    {
        Console.WriteLine("The vehicle is moving");
    }
}

class Airplane : Vehicle
{
    private double _max_altitude;

    public void Flying()
    {
        base.Moving();
        Console.WriteLine("The airplane is flying");
    }
}
