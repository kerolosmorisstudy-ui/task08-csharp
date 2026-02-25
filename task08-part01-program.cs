

//// =======================
//// IVehicle - Car - Bike
//// =======================

//public interface IVehicle
//{
//    void StartEngine();
//    void StopEngine();
//}

//public class Car : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Car Engine Started");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Car Engine Stopped");
//    }
//}

//public class Bike : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Bike Engine Started");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Bike Engine Stopped");
//    }
//}

//// =======================
//// Abstract Shape
//// =======================

//public abstract class Shape
//{
//    public abstract double GetArea();

//    public void Display()
//    {
//        Console.WriteLine($"Area = {GetArea()}");
//    }
//}

//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}

//public class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//// =======================
//// Product - IComparable
//// =======================

//public class Product : IComparable<Product>
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Price { get; set; }

//    public int CompareTo(Product other)
//    {
//        return Price.CompareTo(other.Price);
//    }
//}

//// =======================
//// Student - Copy Constructor
//// =======================

//public class Student
//{
//    public int Id;
//    public string Name;
//    public double Grade;

//    public Student(int id, string name, double grade)
//    {
//        Id = id;
//        Name = name;
//        Grade = grade;
//    }

//    // Copy Constructor
//    public Student(Student other)
//    {
//        Id = other.Id;
//        Name = other.Name;
//        Grade = other.Grade;
//    }
//}



//// =======================
//// Explicit Interface
//// =======================

//public interface IWalkable
//{
//    void Walk();
//}

//public class Robot : IWalkable
//{
//    void IWalkable.Walk()
//    {
//        Console.WriteLine("Robot walking via interface");
//    }

//    public void Walk()
//    {
//        Console.WriteLine("Robot normal walk");
//    }
//}// =======================
//// Struct Account
//// =======================

//public struct Account
//{
//    private int accountId;
//    private string accountHolder;
//    private double balance;

//    public int AccountId
//    {
//        get { return accountId; }
//        set { accountId = value; }
//    }

//    public string AccountHolder
//    {
//        get { return accountHolder; }
//        set { accountHolder = value; }
//    }

//    public double Balance
//    {
//        get { return balance; }
//        set { balance = value; }
//    }
//}

//// =======================
//// ILogger - Default Implementation
//// =======================

//public interface ILogger
//{
//    void Log()
//    {
//        Console.WriteLine("Default Log Implementation");
//    }
//}

//public class ConsoleLogger : ILogger
//{
//    public void Log()
//    {
//        Console.WriteLine("Console Logger Log");
//    }
//}

//// =======================
//// Book - Constructor Overloading
//// =======================

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book()
//    {
//        Title = "Unknown";
//        Author = "Unknown";
//    }

//    public Book(string title)
//    {
//        Title = title;
//        Author = "Unknown";
//    }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }
//}
