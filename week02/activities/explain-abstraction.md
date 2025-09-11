# W02 Assignment: Explain Abstraction

## Overview

Abstraction is the concept of defining real world ideas into object classes with
properties and behavior that allows the application to mimic the complexity of
these ideas by encapsulate and expose only what is essential for the context it's
defined for. This concept allows to define the attributes and features with
visibility according with the requirements that will satisfy the expectations.
This also allows to manage the state of the application during the lifecycle were
it load and process data that is input or retrived from different sources.

The abstraction is beneficial because it allows to define more complex data structure
and how the application should behave depending of the context and goals defined by
the stakeholders and developers. It basically determines which objects are responsible
to certain aspects of the application like store data to a file, store data to database,
retrieve data from a file, retrieve data from database, send notification email, send
notification text message, and more.

An example of the abstraction can be observed with a vehicle that can define the
caracteristics of a vehicle like dimentions, weight, speed, acceleration, braking,
stability, payload capacity, tires, and more. Along with features that makes it useful
for certain purpose like airplanes, cars, trucks, boats, and more.

Like on the example above we have a class vehicle that can be a more generic definition
of a complex idea, however in some cases it's won't define all the characteristics of
other ideas. Like a car and a airplane have common and different features or behaviors
that a vehicle class cannot extend for all the variations it may have.

With abstractons we can address these concerns and concepts that can be complex for other
programming principals, along with tecniques that can also enhance the development and
project.

Code Example:
```csharp
class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _createdAt { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_createdAt} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public override string ToString()
    {
        return string.Join("|", _createdAt, _response, _prompt);
    }
}
```
