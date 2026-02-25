1 LinkedIn Article – Abstract Class
Understanding Abstract Classes in C#

In object-oriented programming, abstraction is a core principle.
An abstract class in C# is a class that cannot be instantiated directly. It serves as a base class for other classes.

It can contain:

Abstract methods (must be overridden)

Normal implemented methods

Fields and constructors

Example:
//abstract class GeometricShape
//{
//    public abstract double CalculateArea();
//}

Derived classes like Triangle and Rectangle must implement CalculateArea().

Why Use Abstract Class?

Share common code

Enforce structure

Promote code reuse





2️ What Does Coding Against Interface Rather Than Class Mean?

Instead of writing:

// Car car = new Car();

We write:

// IVehicle vehicle = new Car();
 Why?

Because now:

We depend on the contract (IVehicle)

Not on the implementation (Car)

We can replace Car with Bike without changing logic




 What Does “Code Against Abstraction, Not Concreteness” Mean?

It means:

Depend on interfaces or abstract classes, not concrete classes.

Bad:

EmailService service = new EmailService();

Good:

INotificationService service = new EmailService();

Reduces tight coupling
Improves flexibility
Follows Dependency Inversion Principle



3️ What Is Abstraction as a Guideline?

Abstraction means:

Focus on WHAT an object does, not HOW it does it.

 How We Applied It:

Using Interfaces (IShapeSeries)

Using Abstract Class (GeometricShape)

Using Factory Pattern

Using Polymorphism
Support polymor

