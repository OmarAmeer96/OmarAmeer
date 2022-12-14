// // public access specifier
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

//     class ExecuteRectanle
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

// -----------------------------------------------------

// private access specifier
using System;
namespace RectangleApplication
{
    class Rectangle
    {
        private double length;
        private double width;
        public void Acceptdetails()
        {
            Console.WriteLine("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GitArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + GitArea());
        }
    }
    class ExecuteRectanle
    {
        static void Main(String[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
        }
    }
}