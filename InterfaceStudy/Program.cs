using InterfaceStudy;


// Note: this project won't compile.


// Ref: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces



var myInterface = new IMyInterface(); // This is not allowed.

// A class can implement multiple interfaces.
class MyClass : IMyInterface, IMyInterface2 // <- Implementing IMyInterface. Error caused by missing implementation of the Sleep() method.
{
    public string Name { get; set; }

    public int GetValue()
    {
        return 1;
    }
}


class MyClass2 : IMyInterface, IMyInterface2 // <- Implementing IMyInterface. 
{
    public string Name { get; set; }

    public int GetValue()
    {
        var value = GetValue(); // Calling method from the interface.
        return value;
    }

    public async Task Sleep() // Implemented method declared in the interface.
    {
        await Task.Delay(1000);
    }
}


/* Abstract Classes vs Interfaces
 
Key Differences Between Abstract Classes and Interfaces in C#
    Abstract classes can contain implemented methods, while interfaces only contain method signatures* (* - see c# 8 version for changes).
    Classes can implement multiple interfaces, but they can inherit from only one abstract class.
    Abstract classes can have constructors, while interfaces cannot.
    Abstract classes can have fields and properties, while interfaces can only have properties.
    Abstract classes are typically used for creating a base class for other classes to inherit from, 
    while interfaces are used for defining a contract that classes must implement.
 
 
 
 
When to Use an Abstract Class vs When to Use an Interface in C#
    As a general rule, you should use an abstract class when creating a base class that needs to be inherited 
    by other classes in a class hierarchy. If you need to define a behavior that can be implemented by multiple 
    unrelated classes, you should use an interface.
    If you need to add new members or behavior to a base class, you can add them to an abstract class. 
    However, if you need to add behavior to an existing class that cannot inherit from a new base class, 
    you can use an interface.
    Another important consideration when deciding between an abstract class and an interface is the level 
    of abstraction needed. Abstract classes can provide a higher level of abstraction than interfaces, 
    as they can include both abstract and non-abstract members. Interfaces, on the other hand, 
    only include abstract members.
    It’s also worth noting that while a class can inherit from multiple interfaces, 
    it can only inherit from one abstract class. This means that if you need to provide multiple behaviors 
    to a class, using interfaces may be a better option. 
 
 */