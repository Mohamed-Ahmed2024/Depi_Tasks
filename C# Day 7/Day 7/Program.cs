
using System;
using System.Collections.Generic;

namespace Task6_Full
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1 - Struct Point with Constructors & ToString
            Point p1 = new Point();
            Point p2 = new Point(3, 4);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            // Question Answer:
            // A struct in C# cannot inherit from another struct or class because
            // it is a value type and is implicitly sealed.
            // Structs can only implement interfaces.
            #endregion

            #region Problem 2 - Class with Different Access Modifiers
            TypeA a = new TypeA();
            // a.F = 10; // Cannot access private member
            // a.G = 20; // Cannot access internal member from another assembly
            a.H = 30;   // Public member is accessible
            Console.WriteLine($"H: {a.H}");

            // Question Answer:
            // Access modifiers define where a member can be accessed from.
            // private → only inside the same class
            // internal → within the same assembly
            // public → accessible from anywhere
            #endregion

            #region Problem 3 - Employee Struct with Encapsulation
            Employee emp = new Employee(101, "Ali", 5000);
            Console.WriteLine($"Employee Name: {emp.GetName()}");
            emp.SetName("Omar");
            Console.WriteLine($"Updated Name: {emp.GetName()}");

            // Question Answer:
            // Encapsulation hides implementation details and only exposes
            // controlled access to data, improving security and flexibility.
            #endregion

            #region Problem 4 - Constructor Overloading in Struct
            Point2 p3 = new Point2(5);
            Point2 p4 = new Point2(2, 8);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            // Question Answer:
            // Constructors in structs initialize data members.
            // They run when a struct is created, setting default or given values.
            #endregion

            #region Problem 5 - Custom ToString Formatting
            Point3 p5 = new Point3(7, 9);
            Point3 p6 = new Point3(0, 0);
            Console.WriteLine(p5);
            Console.WriteLine(p6);

            // Question Answer:
            // Overriding ToString() provides a readable representation,
            // making debugging and logging easier.
            #endregion

            #region Problem 6 - Struct vs Class Behavior
            Point pStruct = new Point(1, 1);
            EmployeeClass eClass = new EmployeeClass("Ahmed");

            ChangeStruct(pStruct);
            ChangeClass(eClass);

            Console.WriteLine($"Struct after method: {pStruct}"); // unchanged
            Console.WriteLine($"Class after method: {eClass.Name}"); // changed

            // Question Answer:
            // Structs are stored in the stack and passed by value (copied).
            // Classes are stored in the heap and passed by reference.
            #endregion


            // ============================
            // Part 02
            // ============================
            #region Copy Constructor Example
            Person copyP1 = new Person("Ali", 25);
            Person copyP2 = new Person(copyP1); // Using copy constructor
            Console.WriteLine($"Original: {copyP1}");
            Console.WriteLine($"Copy: {copyP2}");

            // Answer: A copy constructor is a constructor that creates a new object
            // as a copy of an existing object. It is useful when you want a new
            // instance with the same values but not the same reference.
            #endregion

            #region Indexer Example
            BookCollection books = new BookCollection();
            books[0] = "C# Basics";
            books[1] = "OOP in Depth";
            books[2] = "Advanced C#";

            Console.WriteLine("Books in Collection:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Book {i + 1}: {books[i]}");
            }

            // Business Use Case Example:
            // - Indexers are great when your class represents a collection or list-like object.
            //   For example:
            //   - Managing items in a shopping cart
            //   - Accessing employee records by ID index
            //   - Retrieving product info from an inventory
            #endregion

            #region Summary of Keywords from Last Lecture
            /*
                1. struct - Value type, stored on the stack, cannot inherit from classes.
                2. class - Reference type, stored on the heap, supports inheritance.
                3. public - Accessible from anywhere.
                4. private - Accessible only within the same class.
                5. internal - Accessible only within the same assembly.
                6. override - Used to provide a new implementation of an inherited method.
                7. constructor - Special method used to initialize objects.
                8. this - Refers to the current instance of the class or struct.
                9. properties - Members that provide controlled access to fields.
                10. indexer - Allows objects to be indexed like arrays.
            */
            #endregion
        }

        static void ChangeStruct(Point pt)
        {
            pt.X = 99; // This change won't affect the original
        }

        static void ChangeClass(EmployeeClass emp)
        {
            emp.Name = "Changed"; // This will affect the original
        }
    }

    // ============================
    // Part 01 Structs & Classes
    // ============================
    #region Struct for Problem 1
    struct Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            X = x; Y = y;
        }
        public override string ToString() => $"({X}, {Y})";
    }
    #endregion

    #region Class for Problem 2
    class TypeA
    {
        private int F;
        internal int G;
        public int H;
    }
    #endregion

    #region Struct for Problem 3
    struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;

        public Employee(int id, string name, double salary)
        {
            EmpId = id; Name = name; Salary = salary;
        }

        public string GetName() => Name;
        public void SetName(string name) => Name = name;
    }
    #endregion

    #region Struct for Problem 4
    struct Point2
    {
        public int X, Y;
        public Point2(int x)
        {
            X = x; Y = 0;
        }
        public Point2(int x, int y)
        {
            X = x; Y = y;
        }
        public override string ToString() => $"({X}, {Y})";
    }
    #endregion

    #region Struct for Problem 5
    struct Point3
    {
        public int X, Y;
        public Point3(int x, int y)
        {
            X = x; Y = y;
        }
        public override string ToString() => $"Point Coordinates => X: {X}, Y: {Y}";
    }
    #endregion

    #region Struct vs Class Demo
    class EmployeeClass
    {
        public string Name;
        public EmployeeClass(string name) => Name = name;
    }
    #endregion

\
    #region Copy Constructor Class
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public override string ToString() => $"{Name}, {Age} years old";
    }
    #endregion

    #region Indexer Class
    class BookCollection
    {
        private List<string> books = new List<string>();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                    return books[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < books.Count)
                    books[index] = value;
                else if (index == books.Count)
                    books.Add(value);
            }
        }
    }
    #endregion
}
