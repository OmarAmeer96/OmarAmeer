// Tasks -- Omar Ameer Mohamed Ameen Mohamed -- Sec 6
using System;
namespace Tasks
{
    public abstract class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void Print();
    }

    public abstract class Student : Person
    {
        public int Year;
        public float Gpa;
        public Student(string name, int age, int year, float gpa) : base(name, age)
        {
            Year = year;
            Gpa = gpa;
        }
        public override void Print()
        {
        }
    }

    public sealed class P1 : Student
    {
        public P1(string name, int age, int year, float gpa) : base(name, age, year, gpa) { }
        public override void Print()
        {
            Console.WriteLine($"My name is {Name}, my age is {Age}, my gpa is {Gpa}");
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please, enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Please, enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter your year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter your gpa: ");
            var gpa = Convert.ToSingle(Console.ReadLine());

            P1 obj = new P1(name!, age, year, gpa);
            obj.Print();
        }
    }
}