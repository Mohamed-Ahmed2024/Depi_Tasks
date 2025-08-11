using System;

class Program
{
    static void Main()
    {
        #region Divide two integers with exception handling
        //try
        //{
        //    Console.Write("Enter first integer: ");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("Enter second integer: ");
        //    int b = int.Parse(Console.ReadLine());
        
        //    int result = a / b;
        //    Console.WriteLine($"Result: {result}");
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Error: Cannot divide by zero.");
        //}
        

        // The finally block ensures that a set of statements always executes after try/catch,
        // regardless of whether an exception is thrown or not.
        #endregion

        #region Modify TestDefensiveCode to accept only positive integers and Y > 1
        //int x, y;
        //do
        //{
        //    Console.Write("Enter a positive integer X: ");
        //} while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);
        
        //do
        //{
        //    Console.Write("Enter a positive integer Y (greater than 1): ");
        //} while (!int.TryParse(Console.ReadLine(), out y) || y <= 1);
        
        //Console.WriteLine($"X = {x}, Y = {y}");

        // int.TryParse() improves robustness because it returns a bool indicating success/failure
        // instead of throwing an exception, preventing the program from crashing when invalid input is entered.
        #endregion

        #region Nullable integer with null-coalescing operator
        //int? nullableInt = null;
        //int value = nullableInt ?? 10;
        //Console.WriteLine($"Value using ?? : {value}");
        
        //Console.WriteLine($"HasValue: {nullableInt.HasValue}");
        //if (nullableInt.HasValue)
        //    Console.WriteLine($"Value: {nullableInt.Value}");

        // Accessing Value on a null Nullable<T> throws an InvalidOperationException.
        #endregion

        #region 1D array out-of-bounds handling
        //int[] arr = new int[5] {1, 2, 3, 4, 5};
        //try
        //{
        //    Console.WriteLine(arr[10]);
        //}
        //catch (IndexOutOfRangeException)
        //{
        //    Console.WriteLine("Index out of range!");
        //}

        // It is necessary to check array bounds to avoid accessing memory outside the array,
        // which can cause exceptions or undefined behavior.
        #endregion

        #region 3x3 array sum of rows and columns
        //int[,] matrix = new int[3, 3];
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.Write($"Enter element [{i},{j}]: ");
        //        matrix[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}
        
        //for (int i = 0; i < 3; i++)
        //{
        //    int rowSum = 0;
        //    for (int j = 0; j < 3; j++)
        //        rowSum += matrix[i, j];
        //    Console.WriteLine($"Row {i} sum = {rowSum}");
        //}
        
        //for (int j = 0; j < 3; j++)
        //{
        //    int colSum = 0;
        //    for (int i = 0; i < 3; i++)
        //        colSum += matrix[i, j];
        //    Console.WriteLine($"Column {j} sum = {colSum}");
        }

        // GetLength(dimension) returns the number of elements along the specified dimension
        // (0 for rows, 1 for columns in a 2D array).
        #endregion

        #region Jagged array with varying sizes
        //int[][] jagged = new int[3][];
        //jagged[0] = new int[2];
        //jagged[1] = new int[3];
        //jagged[2] = new int[4];
        
        //for (int i = 0; i < jagged.Length; i++)
        //{
        //    for (int j = 0; j < jagged[i].Length; j++)
        //    {
        //        Console.Write($"Enter value for row {i}, col {j}: ");
        //        jagged[i][j] = int.Parse(Console.ReadLine());
        //    }
        //}
        
        //for (int i = 0; i < jagged.Length; i++)
        //{
        //    Console.WriteLine(string.Join(" ", jagged[i]));
        }

        // Jagged arrays store arrays of arrays, so each row can have different lengths and separate memory allocation,
        // while rectangular arrays store all elements in a single contiguous block.
        #endregion

        #region Nullable reference types
        //string? nullableStr = null;
        //Console.Write("Enter text (or leave empty): ");
        //string input = Console.ReadLine();
        //if (!string.IsNullOrEmpty(input))
        //    nullableStr = input;
        
        //Console.WriteLine(nullableStr!); // null-forgiveness operator

        // Nullable reference types help developers identify possible null values at compile time,
        // reducing the risk of NullReferenceException.
        #endregion

        #region Boxing and unboxing
        //int num = 42;        // value type
        //object obj = num;    // boxing
        //try
        //{
        //    int unboxed = (int)obj; // unboxing
        //    Console.WriteLine(unboxed);
        //}
        //catch (InvalidCastException)
        //{
        //    Console.WriteLine("Invalid cast during unboxing.");
        //}

        // Boxing/unboxing involves copying data between the stack and heap, which has a performance cost.
        // Frequent boxing/unboxing should be avoided.
        #endregion

        #region SumAndMultiply method with out parameters
        //void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //}
        
        //SumAndMultiply(3, 4, out int s, out int p);
        //Console.WriteLine($"Sum: {s}, Product: {p}");

        // Out parameters must be initialized inside the method before returning, because the caller expects them to have a value.
        #endregion

        #region Method with optional parameter and named parameters
        void PrintString(string text, int count = 5)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(text);
        }
        
        PrintString("Hello", count: 3);

        // Optional parameters must be at the end so that the compiler can match arguments to parameters correctly without ambiguity.
        #endregion

        #region Nullable integer array with null-propagation operator
        //int[]? arr2 = null;
        //Console.WriteLine(arr2?.Length);

        // The null-propagation operator (?.) returns null if the left-hand operand is null,
        // preventing NullReferenceException.
        #endregion

       

        // Switch expressions are preferred when mapping simple input to output values concisely and readably.
        #endregion

        #region SumArray with params keyword
        //int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var n in numbers)
        //    sum += n;
        //    return sum;
        //}
        
        //Console.WriteLine(SumArray(1, 2, 3));
        //Console.WriteLine(SumArray(new int[] { 4, 5, 6 }));

        // Params allows passing variable arguments without explicitly creating an array,
        // but only one params parameter is allowed and it must be the last parameter.
        #endregion

        #region Print numbers in a range
        //Console.Write("Enter a positive integer: ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //    Console.Write(i + (i < n ? ", " : ""));

        // Prints numbers from 1 to the given number.
        #endregion

        #region Multiplication table up to 12
        //Console.Write("Enter a number: ");
        //int m = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= 12; i++)
        //    Console.WriteLine($"{m} x {i} = {m * i}");

        // Displays multiplication table up to 12.
        #endregion

        #region List even numbers up to N
        //Console.Write("Enter a number: ");
        //int limit = int.Parse(Console.ReadLine());
        //for (int i = 2; i <= limit; i += 2)
        //    Console.Write(i + (i < limit ? ", " : ""));

        // Prints all even numbers between 1 and the given number.
        #endregion

        #region Exponentiation
        //Console.Write("Enter base: ");
        //int baseNum = int.Parse(Console.ReadLine());
        //Console.Write("Enter exponent: ");
        //int exp = int.Parse(Console.ReadLine());
        //int pow = 1;
        //for (int i = 0; i < exp; i++)
        //    pow *= baseNum;
        //Console.WriteLine($"Result: {pow}");

        // Calculates base raised to exponent.
        #endregion

        #region Reverse a text string
        //Console.Write("Enter a string: ");
        //string text = Console.ReadLine();
        //char[] arrChars = text.ToCharArray();
        //Array.Reverse(arrChars);
        //Console.WriteLine(new string(arrChars));

        // Reverses a given string.
        #endregion

        #region Reverse an integer value
        Console.Write("Enter an integer: ");
        string intStr = Console.ReadLine();
        char[] numChars = intStr.ToCharArray();
        Array.Reverse(numChars);
        Console.WriteLine(new string(numChars));

        // Reverses the digits of a given integer.
        #endregion

        #region Find longest distance between matching elements
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        int[] arrInput = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i}: ");
            arrInput[i] = int.Parse(Console.ReadLine());
        }
        int maxDist = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arrInput[i] == arrInput[j])
                    maxDist = Math.Max(maxDist, j - i - 1);
            }
        }
        Console.WriteLine($"Longest distance: {maxDist}");

        // Finds max number of cells between two identical elements.
        #endregion

        #region Reverse words in a sentence
        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();
        //string[] words = sentence.Split(' ');
        //Array.Reverse(words);
        //Console.WriteLine(string.Join(" ", words));

        // Reverses the order of words in a sentence.
        #endregion

    }
}