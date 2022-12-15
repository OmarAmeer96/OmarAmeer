// // public access specifier ==> (visible in anywhere else)
// using System;
// namespace RectangleApplication
// {
//     class Rectangle
//     {
//         public double length;
//         public double width;
//         public double GitArea()
//         {
//             return length * width;
//         }
//         public void Display()
//         {
//             Console.WriteLine("Length: " + length);
//             Console.WriteLine("Width: " + width);
//             Console.WriteLine("Area: " + GitArea());
//         }
//     }

//     class ExecuteRectangle
//     {
//         static void Main(String[] args)
//         {
//             Rectangle r = new Rectangle();

//             r.length = 4.5;
//             r.width = 3.5;

//             r.Display();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // private access specifier ==> (visible in the same class only)
// using System;
// namespace RectangleApplication
// {
//     class Rectangle
//     {
//         private double length;
//         private double width;
//         public void Acceptdetails()
//         {
//             Console.WriteLine("Enter length: ");
//             length = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("Enter width: ");
//             width = Convert.ToDouble(Console.ReadLine());
//         }
//         public double GitArea()
//         {
//             return length * width;
//         }
//         public void Display()
//         {
//             Console.WriteLine("Length: " + length);
//             Console.WriteLine("Width: " + width);
//             Console.WriteLine("Area: " + GitArea());
//         }
//     }
//     class ExecuteRectangle
//     {
//         static void Main(String[] args)
//         {
//             Rectangle r = new Rectangle();
//             r.Acceptdetails();
//             r.Display();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // internal access specifier ==> (visible in the same application only)
// using System;
// namespace RectangleApplication
// {
//     class Rectangle
//     {
//         internal double length;
//         internal double width;

//         double GitArea()
//         {
//             return length * width;
//         }
//         public void display()
//         {
//             Console.WriteLine("Length: " + length);
//             Console.WriteLine("Width: " + width);
//             Console.WriteLine("Area: " + GitArea());
//         }
//     }

//     class ExecuteRectangle
//     {
//         static void Main(String[] args)
//         {
//             Rectangle r = new Rectangle();
//             r.length = 4.5;
//             r.width = 3.5;
//             r.display();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

using System;
class NumberManipulator
{
    int result;  //*
    public int FindMax(int num1, int num2)
    {
        if (num1 > num2)
            result = num1;
        else
            result = num2;
        return result;
    }
    public void Display()
    {
        Console.WriteLine("Max is: " + result);
    }
    static void Main(String[] args)
    {
        NumberManipulator r = new NumberManipulator();
        r.FindMax(5, 4);
        r.Display();
    }
}
