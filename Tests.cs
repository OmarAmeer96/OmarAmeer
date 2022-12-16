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

// using System;
// class NumberManipulator
// {
//     int result;  //*
//     public int FindMax(int num1, int num2)
//     {
//         if (num1 > num2)
//             result = num1;
//         else
//             result = num2;
//         return result;
//     }
//     public void Display()
//     {
//         Console.WriteLine("Max is: " + result);
//     }
//     static void Main(String[] args)
//     {
//         NumberManipulator r = new NumberManipulator();
//         r.FindMax(5, 4);
//         r.Display();
//     }
// }

// ----------------------------------------------------------------------------------------

// using System;
// namespace CalculatorApplication{
//     class NumberManipulator{
//         int max;
//         public int FindMax(int num1, int num2){
//             if(num1 > num2){
//                 max = num1;
//             }
//             else{
//                 max = num2;
//             }
//             return max;
//         }

//         static void Main(String[] args){
//             NumberManipulator obj = new NumberManipulator();
//             int a = 100;
//             int b = 200;
//             int res = obj.FindMax(a, b);
//             Console.WriteLine("Max is: " + res);
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// using System;
// namespace CalculatorApplication{
//     class Factorial{
//         public int Fact(int num){
//             int result;
//             if(num == 1){
//                 return 1;
//             }else{
//                 result = Fact(num - 1) * num;
//                 return result;
//             }
//         }
//     }
//     class Test{
//         static void Main(String[] args){
//             Factorial obj = new Factorial();
//             Console.Write("Please, Enter a number: ");
//             int input = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Factorial of " + input + " = " + obj.Fact(input));
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// Arrays
// using System;
// int[] arr1 = new int[10];
// or
// int[] arr2 = {5, 6, 7};
// or
// int[] arr3 = new int[3] {1, 2, 3};
// or
// int[] arr4 = new int[] {1, 2, 3};

// using System;
// namespace ArrayApplication{
//     class MyArray{
//         static void Main(String[] args){
//             int[] arr = new int[10];
//             for(int i = 0; i < 10; i++){
//                 arr[i] = i + 100;
//             }
//             for(int j = 0; j < 10; j++){
//                 Console.WriteLine("Element[{0}] = {1}", j, arr[j]);
//             }
//             Console.WriteLine("---------------");
//             int[] arr2 = new int[10];
//             for(int a = 0; a < 10; a++){
//                 arr2[a] = a + 100;
//             }
//             foreach(int b in arr2){
//                 int a = b - 100;
//                 Console.WriteLine("Element[{0}] = {1}", a, b);
//             }
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // Sec 2 OOP, Test 1
// using System;
// namespace ObjectOriented
// {
//     public class Car
//     {
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public void print()
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//     }
//     public class Program
//     {
//         private static void Main(string[] args)
//         {
//             Console.Write("Name: ");
//             var name = Console.ReadLine();
//             Console.Write("Color: ");
//             var color = Console.ReadLine();

//             var obj = new Car(name, color);
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

using System;
// Inheritance ==> allow's the sub class to inherite from the base class ({is a} relationship)-(Contains everything of the base class except {Constructors} and anything {private})

// // Sec 2 OOP, Test 1
using System;
namespace ObjectOriented
{
    public class Car
    {
        public string? Name;
        public string? Color;

        public Car() { }
        public Car(string? name, string? color)
        {
            Name = name;
            Color = color;
        }
        public void print()
        {
            Console.WriteLine($"Car: {Name}, Color: {Color}");
        }
    }

    public class ElectricCar : Car // class ElectricCar (Inherits) class Car.
    {
        public ElectricCar(string? name, string? color)
        {
            Name = name;
            Color = color;
        }
        public void A()
        {
            print(); // i can use it
        }
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Color: ");
            var color = Console.ReadLine();

            var obj = new ElectricCar(name, color);
            obj.print();
        }
    }
}

// ----------------------------------------------------------------------------------------