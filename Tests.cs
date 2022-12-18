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

// using System;
// Inheritance ==> allow's the sub class to inherite from the base class ({is a} relationship)-(Contains everything of the base class except {Constructors} and anything {private})
// inheritance is a Class Property

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

//     public class ElectricCar : Car // class ElectricCar (Inherits) class Car.
//     {
//         public ElectricCar(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public void A()
//         {
//             print(); // i can use it
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

//             var obj = new ElectricCar(name, color);
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// using System;
// namespace ObjectOriented
// {
//     public class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//     }

//     public class ElectricCar : Car // class ElectricCar (Inherits) class Car.
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public override void print() // derived class can not override any method from the base class without virrtual in the base class
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}, Battery: {Battery}");
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
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             var obj = new ElectricCar(name, color, battery);
//             obj.print(); // using the (Print) method in the ElectricCar class not in the Car class
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // Without abstract
// using System;
// namespace ObjectOriented
// {
//     public class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//         public virtual void start(){ } // because each type of cars starts with different ways so i will override this method in all of these ways
//     }

//     public class ElectricCar : Car // class ElectricCar (Inherits) class Car.
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public override void print()
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}, Battery: {Battery}");
//         }
//         public override void start()
//         {
//             Console.WriteLine("Starting...");
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
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             var obj = new ElectricCar(name, color, battery);
//             obj.print(); // using the (Print) method in the ElectricCar class not in the Car class
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // same as last one but With abstract
// // Abstract ==> something does not have a full imlementaion
// using System;
// namespace ObjectOriented
// {
//     public abstract class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//         public abstract void start(); // Abstract because this method does not have implementation, and the class contains it shoud be abstract too
//     }

//     public abstract class ElectricCar : Car
//     // class ElectricCar (Inherits) class Car.
//     // if in this class i do not wnt to implement the start method too so i should make this class abstract too
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public sealed override void print() // sealed method is the same as sealed class but sealed method is a method that i can not override it with a different implementation
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}, Battery: {Battery}");
//         }
//     }

//     public sealed class Tesla : ElectricCar
//     // Sealed Class ==> is the last class of the chain of classes ==> is a class that no one can inherit it
//     {
//         public Tesla(string? color, int battery) : base("Tesla", color, battery) // override for constructors
//         {
//             Color = color;
//             Battery = battery;
//         }
//         public override void start()
//         {
//             Console.WriteLine("Starting...");
//         }
//     }
//     public class Program
//     {
//         private static void Main(string[] args)
//         {
//             Console.Write("Color: ");
//             var color = Console.ReadLine();
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             var obj = new Tesla(color, battery);
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // Abstract ==> part 2
// using System;
// namespace ObjectOriented
// {
//     public abstract class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//         public abstract void start(); // Abstract because this method does not have implementation, and the class contains it shoud be abstract too

//         public void stop(){}
//     }

//     public abstract class ElectricCar : Car
//     // class ElectricCar (Inherits) class Car.
//     // if in this class i do not wnt to implement the start method too so i should make this class abstract too
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public sealed override void print()
//         {
//             base.print(); // to use the print method in Car class and only extend it here (add what i want in it not write all of it again)
//             stop(); // do not need to Base.stop because ide will undestand that i want stop in the Car class because no any stop method else is exist
//             Console.WriteLine($"Battery: {Battery}");
//         }
//     }

//     public sealed class Tesla : ElectricCar
//     {
//         public Tesla(string? color, int battery) : base("Tesla", color, battery) // override for constructors
//         {
//             Color = color;
//             Battery = battery;
//         }
//         public override void start()
//         {
//             Console.WriteLine("Starting...");
//         }
//     }
//     public class Program
//     {
//         private static void Main(string[] args)
//         {
//             Console.Write("Color: ");
//             var color = Console.ReadLine();
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             var obj = new Tesla(color, battery);
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // Polymorphism ==> is the ability of the object to take more than one shape
// // polymorphism is an objeect property
// using System;
// namespace ObjectOriented
// {
//     public abstract class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//         public void stop() { }
//     }

//     public abstract class ElectricCar : Car
//     // class ElectricCar (Inherits) class Car.
//     // if in this class i do not wnt to implement the start method too so i should make this class abstract too
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public sealed override void print()
//         {
//             base.print(); // to use the print method in Car class and only extend it here (add what i want in it not write all of it again)
//             stop(); // do not need to Base.stop because ide will undestand that i want stop in the Car class because no any stop method else is exist
//             Console.WriteLine($"Battery: {Battery}");
//         }
//     }

//     public sealed class Tesla : ElectricCar
//     {
//         public Tesla(string? color, int battery) : base("Tesla", color, battery) // override for constructors
//         {
//             Color = color;
//             Battery = battery;
//         }
//         public void start()
//         {
//             Console.WriteLine("Starting...");
//         }
//     }

//     public class Nissan : Car
//     {
//         public Nissan(string? color) : base("Nissan", color)
//         {
//             Color = color;
//         }
//     }
//     public class Program
//     {
//         private static void Main(string[] args)
//         {
//             Console.Write("Color: ");
//             var color = Console.ReadLine();
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             Tesla obj = new Tesla(color, battery);
//             PrintCar(obj);
//         }
//         private static void PrintCar(Tesla obj)
//         {
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // The IDEA OF POLYMORPHISM ==> is that the object can have different types ==> Car, ElectricCAr, Tesla, Nissan....
// using System;
// namespace ObjectOriented
// {
//     public abstract class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//         public void stop() { }
//     }

//     public abstract class ElectricCar : Car
//     // class ElectricCar (Inherits) class Car.
//     // if in this class i do not wnt to implement the start method too so i should make this class abstract too
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public sealed override void print()
//         {
//             base.print(); // to use the print method in Car class and only extend it here (add what i want in it not write all of it again)
//             stop(); // do not need to Base.stop because ide will undestand that i want stop in the Car class because no any stop method else is exist
//             Console.WriteLine($"Battery: {Battery}");
//         }
//     }

//     public sealed class Tesla : ElectricCar
//     {
//         public Tesla(string? color, int battery) : base("Tesla", color, battery) // override for constructors
//         {
//             Color = color;
//             Battery = battery;
//         }
//         public void start()
//         {
//             Console.WriteLine("Starting...");
//         }
//     }

//     public class Nissan : Car
//     {
//         public Nissan(string? color) : base("Nissan", color)
//         {
//             Color = color;
//         }
//     }
//     public class Program
//     {
//         private static void Main(string[] args)
//         {
//             Console.Write("Color: ");
//             var color = Console.ReadLine();
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             Nissan obj = new Nissan(color);
//             PrintCar(obj);
//         }
//         private static void PrintCar(Nissan obj)
//         {
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // Definition & Implementation
// // Ex ==> Car Obj = new Tesla(color, battery);
// // Definition Type ==> Car obj ==> I'am Using things Defined in this type/class
// // Implementation Type ==> new Tesla ==> I'am Using things Implemented in this type/class
// // Ex of difference between defintion and implementation:
// // ==> private static Hello() {Console.WriteLine("Helllllo");}
// //                    -----    ------------------------------
// //                  Definition         Implementation 
// //                of this method       of this method
// using System;
// namespace ObjectOriented
// {
//     public abstract class Car
//     {
//         public int Battery;
//         public string? Name;
//         public string? Color;

//         public Car() { }
//         public Car(string? name, string? color)
//         {
//             Name = name;
//             Color = color;
//         }
//         public virtual void print() // Virtual ==> I can not (override) this method without (virtual)
//         {
//             Console.WriteLine($"Car: {Name}, Color: {Color}");
//         }
//         public void stop() { }
//     }

//     public abstract class ElectricCar : Car
//     // class ElectricCar (Inherits) class Car.
//     // if in this class i do not wnt to implement the start method too so i should make this class abstract too
//     {
//         public ElectricCar(string? name, string? color, int battery)
//         {

//             Name = name;
//             Color = color;
//             Battery = battery;
//         }

//         public sealed override void print()
//         {
//             base.print(); // to use the print method in Car class and only extend it here (add what i want in it not write all of it again)
//             stop(); // do not need to Base.stop because ide will undestand that i want stop in the Car class because no any stop method else is exist
//             Console.WriteLine($"Battery: {Battery}");
//         }
//     }

//     public sealed class Tesla : ElectricCar
//     {
//         public Tesla(string? color, int battery) : base("Tesla", color, battery) // override for constructors
//         {
//             Color = color;
//             Battery = battery;
//         }
//         public void start()
//         {
//             Console.WriteLine("Starting...");
//         }
//     }

//     public class Nissan : Car
//     {
//         public Nissan(string? color) : base("Nissan", color)
//         {
//             Color = color;
//         }
//     }
//     public class Program
//     {
//         private static void Main(string[] args)
//         {
//             Console.Write("Color: ");
//             var color = Console.ReadLine();
//             Console.Write("Battery: ");
//             var battery = Convert.ToInt32(Console.ReadLine());
//             Nissan obj = new Nissan(color);
//             PrintCar(obj);
//         }
//         private static void PrintCar(Nissan obj)
//         {
//             obj.print();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// // Task 1:
// // Tasks -- Omar Ameer Mohamed Ameen Mohamed -- Sec 6
// using System;
// namespace Tasks
// {
//     public abstract class Person
//     {
//         string Name;
//         int Age;
//         public Person(string name, int age)
//         {
//             Name = name;
//             Age = age;
//         }
//         public abstract void Print();
//     }
// }

// ----------------------------------------------------------------------------------------

// Task 2:


// ----------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------
