
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace day10_G01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ LINQ Assignment Solutions ================\n");

            #region Restriction (Where)
            var outOfStock = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);
            Console.WriteLine("Out of stock products:");
            foreach (var p in outOfStock) Console.WriteLine(p);

            var inStockExpensive = ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            Console.WriteLine("\nIn-stock and expensive products:");
            foreach (var p in inStockExpensive) Console.WriteLine(p);

            string[] digits = { "zero","one","two","three","four","five","six","seven","eight","nine" };
            var shortNamed = digits.Where((d, i) => d.Length < i);
            Console.WriteLine("\nDigits with name shorter than value:");
            foreach (var d in shortNamed) Console.WriteLine(d);
            #endregion

            #region Element Operators
            var firstOutOfStock = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine($"\nFirst out of stock product: {firstOutOfStock}");

            var overThousand = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine($"First product over 1000 or null: {overThousand}");

            int[] nums = {1,2,3,4,5,6,7,8,9};
            var secondOverFive = nums.Where(n => n > 5).Skip(1).FirstOrDefault();
            Console.WriteLine($"Second number > 5: {secondOverFive}");
            #endregion

            #region Projection
            var namesOnly = ListGenerators.ProductList.Select(p => p.ProductName);
            Console.WriteLine("\nProduct Names:"); foreach (var n in namesOnly) Console.WriteLine(n);

            var upper = digits.Select(d => d.ToUpper());
            Console.WriteLine("\nDigits UpperCase:"); foreach (var d in upper) Console.WriteLine(d);

            var squares = Enumerable.Range(1,10).Select(x => x*x);
            Console.WriteLine("\nSquares:"); foreach (var s in squares) Console.WriteLine(s);

            var orderTotals = ListGenerators.CustomerList.SelectMany(c => c.Orders).Select(o => o.Total);
            Console.WriteLine("\nAll order totals:"); foreach (var t in orderTotals) Console.WriteLine(t);
            #endregion

            #region Partitioning
            var firstThree = ListGenerators.ProductList.Take(3);
            Console.WriteLine("\nFirst 3 products:"); foreach (var p in firstThree) Console.WriteLine(p);

            var skipTwo = ListGenerators.ProductList.Skip(2);
            Console.WriteLine("\nSkip 2 products:"); foreach (var p in skipTwo) Console.WriteLine(p);
            #endregion

            #region Ordering
            var priceAsc = ListGenerators.ProductList.OrderBy(p => p.UnitPrice);
            Console.WriteLine("\nProducts ordered by price:"); foreach (var p in priceAsc) Console.WriteLine(p);

            var stockDesc = ListGenerators.ProductList.OrderByDescending(p => p.UnitsInStock);
            Console.WriteLine("\nProducts ordered by stock desc:"); foreach (var p in stockDesc) Console.WriteLine(p);
            #endregion

            #region Set Operators
            var set1 = new int[]{1,2,3,4,5};
            var set2 = new int[]{4,5,6,7,8};
            Console.WriteLine("\nUnion: " + string.Join(",", set1.Union(set2)));
            Console.WriteLine("Intersect: " + string.Join(",", set1.Intersect(set2)));
            Console.WriteLine("Except: " + string.Join(",", set1.Except(set2)));
            #endregion

            #region Grouping
            var byCategory = ListGenerators.ProductList.GroupBy(p => p.Category);
            foreach (var grp in byCategory)
            {
                Console.WriteLine($"\nCategory: {grp.Key}");
                foreach (var p in grp) Console.WriteLine(p);
            }
            #endregion

            #region Join
            var customerOrders = ListGenerators.CustomerList.SelectMany(c => c.Orders,
                (c, o) => new {c.Name, o.Id, o.Total});
            Console.WriteLine("\nCustomer Orders:");
            foreach (var co in customerOrders) Console.WriteLine(co);
            #endregion

            #region Quantifiers
            bool anyExpensive = ListGenerators.ProductList.Any(p => p.UnitPrice > 1000);
            Console.WriteLine($"\nAny product > 1000? {anyExpensive}");
            bool allInStock = ListGenerators.ProductList.All(p => p.UnitsInStock > 0);
            Console.WriteLine($"All in stock? {allInStock}");
            #endregion

            #region Aggregate
            var oddCount = Enumerable.Range(1,100).Count(x => x % 2 == 1);
            Console.WriteLine($"\nOdd numbers count (1-100): {oddCount}");

            var custOrders = ListGenerators.CustomerList.Select(c => new {c.Name, Count = c.Orders.Count()});
            Console.WriteLine("\nCustomer order counts:"); foreach (var c in custOrders) Console.WriteLine(c);

            var catCounts = ListGenerators.ProductList.GroupBy(p => p.Category)
                .Select(g => new {Category=g.Key, Count=g.Count()});
            Console.WriteLine("\nCategory counts:"); foreach (var c in catCounts) Console.WriteLine(c);

            var sumNums = Enumerable.Range(1,10).Sum();
            Console.WriteLine($"\nSum 1-10: {sumNums}");

            string dictPath = "dictionary_english.txt";
            if (File.Exists(dictPath))
            {
                var lines = File.ReadAllLines(dictPath);
                var longWords = lines.Count(w => w.Length > 10);
                Console.WriteLine($"\nWords longer than 10 letters: {longWords}");
            }
            else Console.WriteLine("\nDictionary file not found.");
            #endregion
        }
    }
}
