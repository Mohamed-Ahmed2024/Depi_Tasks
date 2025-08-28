using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Task10 Solutions ---");

            Problem1Demo.Execute();
            Problem2Demo.Execute();
            Problem3Demo.Execute();
            Problem4Demo.Execute();
            Problem5Demo.Execute();
            Problem6Demo.Execute();
            Problem7Demo.Execute();
            Problem8Demo.Execute();
            Problem9Demo.Execute();
            Problem10Demo.Execute();
            Problem11Demo.Execute();
            Problem12Demo.Execute();
            Problem13Demo.Execute();
            Problem14Demo.Execute();
            Problem15Demo.Execute();
            Problem16Demo.Execute();
            Problem17Demo.Execute();
            Problem18Demo.Execute();
            Problem19Demo.Execute();
            Problem20Demo.Execute();
        }
    }

    #region Problem 1: Sorting Employees by Salary
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public override string ToString() => $"Name: {Name}, Salary: {Salary}";
    }

    public class SortingAlgorithm<T>
    {
        public void Sort(T[] array, Comparison<T> comparison) => Array.Sort(array, comparison);
    }

    public static class Problem1Demo
    {
        public static void Execute()
        {
            var employees = new Employee[]
            {
                new Employee{Name="Alice", Salary=5000},
                new Employee{Name="Bob", Salary=3000},
                new Employee{Name="Charlie", Salary=4000}
            };

            var sorter = new SortingAlgorithm<Employee>();
            sorter.Sort(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));

            Console.WriteLine("Sorted Employees by Salary:");
            foreach (var emp in employees)
                Console.WriteLine(emp);
        }
    }
    #endregion

    #region Problem 2: Sort Integers Descending using Lambda
    public class SortingTwo<T>
    {
        public void Sort(T[] array, Comparison<T> comparison) => Array.Sort(array, comparison);
    }

    public static class Problem2Demo
    {
        public static void Execute()
        {
            int[] numbers = { 1, 4, 2, 9, 5 };
            var sorter = new SortingTwo<int>();
            sorter.Sort(numbers, (a, b) => b.CompareTo(a));

            Console.WriteLine("Integers sorted in descending order:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
    #endregion

    #region Problem 3: Sort Strings by Length
    public static class Problem3Demo
    {
        public static void Execute()
        {
            string[] words = { "apple", "cat", "banana", "dog" };
            var sorter = new SortingTwo<string>();
            sorter.Sort(words, (s1, s2) => s1.Length.CompareTo(s2.Length));

            Console.WriteLine("Strings sorted by length:");
            Console.WriteLine(string.Join(", ", words));
        }
    }
    #endregion

    #region Problem 4: Manager Class implementing IComparable
    public class Manager : Employee, IComparable<Manager>
    {
        public int CompareTo(Manager other) => this.Salary.CompareTo(other.Salary);
    }

    public static class Problem4Demo
    {
        public static void Execute()
        {
            var managers = new Manager[]
            {
                new Manager{Name="Mark", Salary=8000},
                new Manager{Name="Jane", Salary=6000},
                new Manager{Name="Tom", Salary=7000}
            };

            Array.Sort(managers);

            Console.WriteLine("Managers sorted by Salary:");
            foreach (var m in managers)
                Console.WriteLine(m);
        }
    }
    #endregion

    #region Problem 5: Delegate Func<T,T,bool> for Name Length
    public static class Problem5Demo
    {
        public static void Execute()
        {
            Employee[] employees =
            {
                new Employee{Name="Alice", Salary=5000},
                new Employee{Name="Bob", Salary=4000},
                new Employee{Name="Christina", Salary=4500}
            };

            Func<Employee, Employee, bool> compareByNameLength = (e1, e2) => e1.Name.Length < e2.Name.Length;
            Array.Sort(employees, (x, y) => compareByNameLength(x, y) ? -1 : 1);

            Console.WriteLine("Employees sorted by Name Length:");
            foreach (var emp in employees)
                Console.WriteLine(emp);
        }
    }
    #endregion

    #region Problem 6: Sort integers using anonymous function and lambda
    public static class Problem6Demo
    {
        public static void Execute()
        {
            int[] arr = { 5, 2, 8, 1 };

            Array.Sort(arr, delegate (int a, int b) { return a.CompareTo(b); });
            Console.WriteLine("Sorted with anonymous function: " + string.Join(", ", arr));

            Array.Sort(arr, (a, b) => a.CompareTo(b));
            Console.WriteLine("Sorted with lambda: " + string.Join(", ", arr));
        }
    }
    #endregion

    #region Problem 7: Generic Swap<T>
    public static class Problem7Demo
    {
        public static void Execute()
        {
            int a = 5, b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"Swapped: a={a}, b={b}");
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
    #endregion

    #region Problem 8: Multi-criteria Sorting (Salary then Name)
    public static class Problem8Demo
    {
        public static void Execute()
        {
            Employee[] employees =
            {
                new Employee{Name="Alice", Salary=5000},
                new Employee{Name="Bob", Salary=5000},
                new Employee{Name="Charlie", Salary=4000}
            };

            Array.Sort(employees, (e1, e2) =>
            {
                int result = e1.Salary.CompareTo(e2.Salary);
                return result == 0 ? e1.Name.CompareTo(e2.Name) : result;
            });

            Console.WriteLine("Employees sorted by Salary then Name:");
            foreach (var emp in employees)
                Console.WriteLine(emp);
        }
    }
    #endregion

    #region Problem 9: GetDefault<T>()
    public static class Problem9Demo
    {
        public static void Execute()
        {
            Console.WriteLine($"Default of int: {GetDefault<int>()}");
            Console.WriteLine($"Default of string: {GetDefault<string>() ?? "null"}");
        }

        public static T GetDefault<T>() => default(T);
    }
    #endregion

    #region Problem 10: Constraint ICloneable
    public class SortingAlgorithmWithConstraint<T> where T : ICloneable
    {
        public void Sort(T[] array, Comparison<T> comparison) => Array.Sort(array, comparison);
    }

    public static class Problem10Demo
    {
        public static void Execute()
        {
            Console.WriteLine("Constraint-based sorting demonstrated.");
        }
    }
    #endregion

    #region Problem 11: Delegate for string transformation
    public static class Problem11Demo
    {
        public delegate string StringTransformer(string input);

        public static List<string> TransformStrings(List<string> list, StringTransformer transformer)
        {
            List<string> result = new List<string>();
            foreach (var str in list)
                result.Add(transformer(str));
            return result;
        }

        public static void Execute()
        {
            var words = new List<string> { "hello", "world" };
            var upper = TransformStrings(words, s => s.ToUpper());
            var reversed = TransformStrings(words, s => new string(s.Reverse().ToArray()));

            Console.WriteLine("Uppercase: " + string.Join(", ", upper));
            Console.WriteLine("Reversed: " + string.Join(", ", reversed));
        }
    }
    #endregion

    #region Problem 12: Delegate for two integers
    public static class Problem12Demo
    {
        public delegate int IntOperation(int a, int b);

        public static int Compute(int x, int y, IntOperation op) => op(x, y);

        public static void Execute()
        {
            Console.WriteLine("Add: " + Compute(5, 3, (a, b) => a + b));
            Console.WriteLine("Subtract: " + Compute(5, 3, (a, b) => a - b));
            Console.WriteLine("Multiply: " + Compute(5, 3, (a, b) => a * b));
            Console.WriteLine("Divide: " + Compute(6, 3, (a, b) => a / b));
        }
    }
    #endregion

    #region Problem 13: Generic delegate for transformation
    public static class Problem13Demo
    {
        public delegate R Transformer<T, R>(T input);

        public static List<R> TransformList<T, R>(List<T> source, Transformer<T, R> transformer)
        {
            return source.Select(transformer.Invoke).ToList();
        }

        public static void Execute()
        {
            var numbers = new List<int> { 1, 2, 3 };
            var strings = TransformList(numbers, n => $"Number: {n}");
            Console.WriteLine(string.Join(" | ", strings));
        }
    }
    #endregion

    #region Problem 14: Func<T, TResult> for square
    public static class Problem14Demo
    {
        public static void Execute()
        {
            Func<int, int> square = x => x * x;
            var numbers = new List<int> { 1, 2, 3 };
            var squares = numbers.Select(square).ToList();
            Console.WriteLine("Squares: " + string.Join(", ", squares));
        }
    }
    #endregion

    #region Problem 15: Action<T>
    public static class Problem15Demo
    {
        public static void Execute()
        {
            Action<string> print = s => Console.WriteLine(s);
            var words = new List<string> { "Hello", "C#" };
            words.ForEach(print);
        }
    }
    #endregion

    #region Problem 16: Predicate<T>
    public static class Problem16Demo
    {
        public static void Execute()
        {
            Predicate<int> isEven = n => n % 2 == 0;
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evens = numbers.FindAll(isEven);
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
        }
    }
    #endregion

    #region Problem 17: Filter strings using anonymous function
    public static class Problem17Demo
    {
        public static void Execute()
        {
            var words = new List<string> { "apple", "banana", "cat" };
            var filtered = words.FindAll(delegate (string s) { return s.StartsWith("a"); });
            Console.WriteLine("Strings starting with 'a': " + string.Join(", ", filtered));
        }
    }
    #endregion

    #region Problem 18: Math operation using anonymous function
    public static class Problem18Demo
    {
        public static void Execute()
        {
            Func<int, int, int> add = delegate (int a, int b) { return a + b; };
            Console.WriteLine("Sum: " + add(4, 5));
        }
    }
    #endregion

    #region Problem 19: Filter strings using lambda
    public static class Problem19Demo
    {
        public static void Execute()
        {
            var words = new List<string> { "tree", "apple", "bee" };
            var filtered = words.Where(s => s.Length > 3).ToList();
            Console.WriteLine("Strings with length > 3: " + string.Join(", ", filtered));
        }
    }
    #endregion

    #region Problem 20: Math operation using lambda
    public static class Problem20Demo
    {
        public static void Execute()
        {
            Func<double, double, double> power = (a, b) => Math.Pow(a, b);
            Console.WriteLine("2^3 = " + power(2, 3));
        }
    }
    #endregion
}