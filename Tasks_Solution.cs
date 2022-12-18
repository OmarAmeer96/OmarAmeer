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

    public class Student : Person
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
            Console.WriteLine($"My name is {Name}, my age is {Age}, my gpa is {Gpa}");
        }
    }
    public class Database
    {
        private int _currentIndex;
        public Person[] Peaple = new Person[50];
        public void AddStudent(Student student){
            Peaple[_currentIndex++] = student;
        }
        public void AddStaff(Staff staff){
            Peaple[_currentIndex++] = staff;
        }
    }

    public class Staff : Person
    {
        public double Salary;
        public int JoinYear;
        public Staff(string name, int age, double salary, int JoinYear) : base(name, age)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"My name is {Name}, my age is {Age}, my salary is {Salary}");
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            var database = new Database();

            Console.Write("Please, enter student's name: ");
            var name = Console.ReadLine();
            Console.Write("Please, enter student's age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter student's year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter student's gpa: ");
            var gpa = Convert.ToSingle(Console.ReadLine());

            var student = new Student(name!, age, year, gpa);

            database.AddStudent(student);
        }
    }
}