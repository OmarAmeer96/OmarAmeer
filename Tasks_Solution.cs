// Tasks -- Omar Ameer Mohamed Ameen Mohamed -- Sec 6
using System;
namespace Tasks
{
    public class Person
    {
        private string? _Name;
        private int _Age;
        public Person(string name, int age)
        {
            if (name == null || name == "" || name.Length >= 32)
            {
                throw new Exception("Invalid Name!");
            }
            if (age <= 0 || age > 128)
            {
                throw new Exception("Invalid Age!");
            }
            _Name = name!;
            _Age = age;
        }

        public string GetName() => _Name!;

        public int GetAge() => _Age;

        public void SetName(string name)
        {
            _Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine($"My name is {_Name}, my age is {_Age}");
        }
    }

    public class Student : Person
    {

        public int Year;
        public float Gpa;
        public Student(string name, int age, int year, float gpa) : base(name, age)
        {
            if (year < 1 || year > 5)
            {
                throw new Exception("Invalid Year!");
            }

            if (gpa < 0 || gpa > 4)
            {
                throw new Exception("Invalid Gpa!");
            }

            Year = year;
            Gpa = gpa;
        }
        public override void Print()
        {
            Console.WriteLine($"My name is {GetName()}, my age is {GetAge()}, my gpa is {Gpa}");
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
            if (salary < 0 || salary > 120000)
            {
                throw new Exception("Invalid Salary!");
            }

            if(joinYear - age <= 21){
                throw new Exception("Invalid Join Year!");
            }

            Salary = salary;
            JoinYear = joinYear;
        }
        public override void Print()
        {
            Console.WriteLine($"My name is {GetName()}, my age is {GetAge()}, my salary is {Salary}");
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            var database = new Database();

            while (true)
            {
                Console.WriteLine("1)Add Student - 2)Add Staff - 3)Add Person - 4)Print All");
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

                        try
                        {
                            var student = new Student(name!, age, year, gpa);

                            database.AddStudent(student);
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                        }
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

                        try
                        {
                            var staff = new Staff(name2!, age2, salary, joinYear);

                            database.AddStaff(staff);
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                        }
                        break;

                    case 3:
                        Console.Write("Please, enter person's name: ");
                        var name3 = Console.ReadLine();
                        Console.Write("Please, enter person's age: ");
                        var age3 = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            var person = new Person(name3!, age3);

                            database.AddPerson(person);
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                        }

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