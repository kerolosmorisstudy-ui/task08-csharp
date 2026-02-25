//Create Shape Series
//=============================
////Step 1: Define IShapeSeries
//public interface IShapeSeries
//{
//    int CurrentShapeArea { get; set; }
//    void GetNextArea();
//    void ResetSeries();
//}
////Step 2: SquareSeries
//public class SquareSeries : IShapeSeries
//{
//    private int side = 0;
//    public int CurrentShapeArea { get; set; }

//    public void GetNextArea()
//    {
//        side++;
//        CurrentShapeArea = side * side;
//    }

//    public void ResetSeries()
//    {
//        side = 0;
//        CurrentShapeArea = 0;
//    }
//}
////Step 3: CircleSeries
//public class CircleSeries : IShapeSeries
//{
//    private int radius = 0;
//    public int CurrentShapeArea { get; set; }

//    public void GetNextArea()
//    {
//        radius++;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }

//    public void ResetSeries()
//    {
//        radius = 0;
//        CurrentShapeArea = 0;
//    }
//}
// //Step 4: PrintTenShapes Method
//public static void PrintTenShapes(IShapeSeries series)
//{
//    series.ResetSeries();

//    for (int i = 0; i < 10; i++)
//    {
//        series.GetNextArea();
//        Console.WriteLine(series.CurrentShapeArea);
//    }
//}



////Implement Sorting for Shapes
//=============================
////Step 1: Shape Class
//public class Shape : IComparable<Shape>
//{
//    public string Name { get; set; }
//    public double Area { get; set; }

//    public int CompareTo(Shape other)
//    {
//        return Area.CompareTo(other.Area);
//    }
//}
////Step 2: Create & Sort
//Shape[] shapes =
//{
//    new Shape { Name = "Square", Area = 25 },
//    new Shape { Name = "Circle", Area = 12.5 },
//    new Shape { Name = "Rectangle", Area = 40 }
//};

//Array.Sort(shapes);

//foreach (var shape in shapes)
//{
//    Console.WriteLine($"{shape.Name} - {shape.Area}");
//}



////Extend Shape Hierarchy
//=============================
////Step 1: Abstract Class
//public abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    public abstract double CalculateArea();
//    public abstract double Perimeter { get; }
//}
////Step 2: Triangle
//public class Triangle : GeometricShape
//{
//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); }
//    }
//}
////Step 3: Rectangle
//public class RectangleShape : GeometricShape
//{
//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return 2 * (Dimension1 + Dimension2); }
//    }
//}
////Demo
//GeometricShape rect = new RectangleShape { Dimension1 = 5, Dimension2 = 4 };
//GeometricShape tri = new Triangle { Dimension1 = 3, Dimension2 = 6 };

//Console.WriteLine(rect.CalculateArea());
//Console.WriteLine(tri.CalculateArea());



////Implement Your Own SelectionSort
//=============================
//public static void SelectionSort(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length - 1; i++)
//    {
//        int minIndex = i;

//        for (int j = i + 1; j < numbers.Length; j++)
//        {
//            if (numbers[j] < numbers[minIndex])
//                minIndex = j;
//        }

//        int temp = numbers[i];
//        numbers[i] = numbers[minIndex];
//        numbers[minIndex] = temp;
//    }
//}


//int[] areas = { 25, 12, 40, 9, 30 };
//SelectionSort(areas);

//foreach (var area in areas)
//    Console.WriteLine(area);

////Factory Pattern
//=============================
////ShapeFactory
//public static class ShapeFactory
//{
//    public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
//    {
//        switch (shapeType.ToLower())
//        {
//            case "rectangle":
//                return new RectangleShape { Dimension1 = dim1, Dimension2 = dim2 };

//            case "triangle":
//                return new Triangle { Dimension1 = dim1, Dimension2 = dim2 };

//            default:
//                throw new ArgumentException("Invalid shape type");
//        }
//    }
//}


//GeometricShape shape1 = ShapeFactory.CreateShape("rectangle", 5, 4);
//GeometricShape shape2 = ShapeFactory.CreateShape("triangle", 3, 6);

//Console.WriteLine(shape1.CalculateArea());
//Console.WriteLine(shape2.CalculateArea());
