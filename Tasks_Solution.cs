// Tasks -- Omar Ameer Mohamed Ameen Mohamed -- Sec 6
using System;
namespace Tasks
{
    public class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Print() {
            Console.WriteLine($"My name is {Name}, my age is {Age}");
        }
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
        public Person[] People = new Person[50];
        public void AddStudent(Student student)
        {
            People[_currentIndex++] = student;
        }
        public void AddStaff(Staff staff)
        {
            People[_currentIndex++] = staff;
        }
        public void AddPerson(Person person)
        {
            People[_currentIndex++] = person;
        }

        public void PrintAll()
        {
            for (var i = 0; i < _currentIndex; i++)
            {
                People[i].Print();
            }
        }
    }

    public class Staff : Person
    {
        public double Salary;
        public int JoinYear;
        public Staff(string name, int age, double salary, int joinYear) : base(name, age)
        {
            Salary = salary;
            JoinYear = joinYear;
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

            while (true)
            {
                Console.WriteLine("1) Add Student - 2) Add Staff - 3) Print All");
                Console.Write("Your Option: ");

                var option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
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
                        break;

                    case 2:
                        Console.Write("Please, enter name: ");
                        var name2 = Console.ReadLine();
                        Console.Write("Please, enter age: ");
                        var age2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please, enter salary: ");
                        var salary = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please, enter join year: ");
                        var joinYear = Convert.ToInt32(Console.ReadLine());

                        var staff = new Staff(name2!, age2, salary, joinYear);

                        database.AddStaff(staff);
                        break;
                    case 3:
                        Console.Write("Please, enter person's name: ");
                        var name3 = Console.ReadLine();
                        Console.Write("Please, enter person's age: ");
                        var age3 = Convert.ToInt32(Console.ReadLine());

                        var person = new Person(name3!, age3);

                        database.AddPerson(person);
                        break;

                    case 4:
                        database.PrintAll();
                        break;

                    default:
                        Console.WriteLine("Please, Enter a correct option {1 - 2 - 3 - 4}");
                        break;
                }
            }
        }
    }
}