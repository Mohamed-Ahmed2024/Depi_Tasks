
namespace System;


class Program {
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    public static void Main(string[] args) {
        #region Part01
        #region Problem1
        // three different Ways to intilaize the Array 
        // the first Way CLR defines the array in this way
        //int[] N = new int[3];
        //N[0] = 1;
        //N[1] = 2;
        //N[2] = 3;
        ////// Print the First Array Elements
        //foreach (int i in N) {
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("**********************************");
        ////// second way
        //int[] arr = new int[] { 55, 66, 77 };
        //foreach(int i  in arr) { 

        //Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("**********************************");
        /////third way 

        //int[] arr1 = { 5, 6, 7, 8 }; // syntax sugar 
        //foreach (int i in arr1)
        //{

        //    Console.Write(i + " ");
        //}


        //Console.WriteLine();
        //Console.WriteLine("**********************************");


        /*
         Question 
         Question: What is the default value assigned to array elements in C#? 
         the ClR assign default values for Object when created in Heap
          if it a value type will be zero or flase regard to boolean values

         */




        #endregion


        #region Problem2
        //int[] arr1 = { 1, 2, 3 };
        //int[] arr2 = { 5, 6, 7 };

        //// shallow copy 
        // refrence copy
        //Console.WriteLine("***********Shallow Copy Example**********************");
        //Console.WriteLine(arr1.GetHashCode()); //54267293
        //Console.WriteLine(arr2.GetHashCode()); //18643596
        //Console.WriteLine("******************************************");
        //arr2 = arr1;
        //Console.WriteLine(arr1.GetHashCode()); //54267293
        //Console.WriteLine(arr2.GetHashCode()); //54267293
        //Console.WriteLine("*****************************************");
        //// arr2 will refer to object arr1 and arr2 will be unreachable Object 
        //arr2[1] = 100;
        //arr2[2] = 88;
        //foreach (int i in arr1) {
        //    Console.WriteLine(i); //  1 , 100 , 88 
        //}
        //Console.WriteLine("Deep Copy");
        //arr2 = (int[]) arr1.Clone();
        //foreach (int i in arr2) {
        //    Console.WriteLine(i); //  1 , 2  , 3 
        //}
        // Different HashCode the Two Arrays Has same data 
        //Console.WriteLine(arr1.GetHashCode()); //54267293
        //Console.WriteLine(arr2.GetHashCode()); //18643596

        #endregion


        #region Problem3
        //int[,] StudentGrades = new int[3, 3];

        //for (int row = 0; row < StudentGrades.GetLength(0); row++) {
        //    Console.WriteLine("*********************");
        //    Console.WriteLine($"Student Number{row + 1 }");
        //    for (int col = 0; col < StudentGrades.GetLength(1); ) {
        //        Console.WriteLine($"Enter Grade of Subject No { col + 1 }");
        //        bool flag = int.TryParse(Console.ReadLine(), out StudentGrades[row, col]);
        //        if (flag && StudentGrades[row, col] > 0) {
        //            col++;
        //        }
        //            }

        //    }

        /*
         Question: What is the difference between GetLength() and Length for multi
            dimensional arrays?
        sol : 
        GetLength is ClassMember Function used with MulitDimensonal Array 
        GetLength Takes a Number to return Number of Rows and Columns
        Length Returns Number of elements in Array and 

         */

        #endregion


        #region Problem4

        //int[] arr = { 100, 50, 70 }; // syntax sugar
        //foreach (int i in arr) {
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("******************************************************************");
        // Array Sort => Sorts  The Array in Acsencding Order
        //Array.Sort(arr); // 50 , 70 , 100
        //Console.Write("Sorted Array  ");
        //foreach (int i in arr)
        //{   
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("******************************************************************");
        // Reverse : Reverse Ordring of elements in Array
        //Array.Reverse(arr);
        //Console.WriteLine();
        //Console.WriteLine("******************************************************************");
        //Console.Write("Reversed Array  ");
        //foreach (int i in arr)
        //{
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("******************************************************************");


        //IndexOf() => Return the Index of a Specified Element in the Array Returns the index

        //Console.WriteLine(Array.IndexOf(arr, 70)); // 2

        // Clear :Remove the  Elemnts form Array 
        //Console.WriteLine("**********************");
        //Array.Clear(arr);
        //foreach (int i in arr)
        //{
        //    Console.Write(i + " ");
        //}

        //int[] arr2 = { 0, 0, 0 };
        //Array.Copy(arr, arr2, 3);
        //foreach (int i in arr2)
        //{
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine(arr.GetHashCode());
        //Console.WriteLine(arr2.GetHashCode());

        #endregion


        #region Problem5
        //int[] arr = { 100, 50, 70, 80 };
        //Console.WriteLine("Using For ");
        //for (int i = 0; i < arr.Length; i++) {
        //    Console.WriteLine(arr[i]);
        //}
        //Console.WriteLine("***************** Using ForEach");

        //foreach (int i in arr) {
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Using While");

        //int j = arr.Length -1 ;

        //while (j >=  0 ) {
        //    Console.WriteLine(arr[j]);
        //    j--;
        //}
        //Console.WriteLine("**************************");
        // Question: Why is foreach preferred for read-only operations on arrays ? 
        // Ans :  It avoids modifying the array's structure  minimizing unintended side effects. and to enhance readability



        #endregion


        #region problem6

        //int num;
        //bool flag;

        //do
        //{
        //Console.WriteLine("Enter a Positive and Odd Number : ");
        //    flag = int.TryParse(Console.ReadLine(), out num);
        //}
        //while (num % 2 == 0 ||  !flag  || num < 0 );

        /*
         Question: Why is input validation important when working with user inputs? 
         to protect the code to deal with different conditions
         also to handle all scenarios   
        */

        #endregion


        #region Problem7
        //int[,] grades = new int[2, 2] { { 7 , 8  }, { 9 , 10  } };

        //for (int row = 0; row < grades.GetLength(0); row++) {
        //    Console.WriteLine($"ROW {row + 1 }");
        //    for (int col = 0; col < grades.GetLength(1); col++)
        //    {
        //        Console.WriteLine(grades[row,col]);
        //    }
        //        }

        //Question: How can you format the output of a 2D array for better readability? 
        // By Using Nested Loop to Print the Values of array
        #endregion

        #region Problem8
        //int month;

        //bool flag;
        //do { 
        //Console.WriteLine("Enter Month Number  : ");

        // flag = int.TryParse(Console.ReadLine(), out month);

        //}
        //while (!flag || month < 0 );

        //if (month == 1)
        //    Console.WriteLine("Jan");
        //else if (month == 2)
        //    Console.WriteLine("Feb");
        //else if (month == 3)
        //    Console.WriteLine("Mars");
        //else
        //    Console.WriteLine("Not In Q01");


        // using switch

        //switch (month)
        //{

        //    case 1:
        //        Console.WriteLine("Jan");
        //        break;
        //    case 2:
        //        Console.WriteLine("Feb");
        //        break;
        //    case 3:
        //        Console.WriteLine("Mars");
        //        break;
        //    default:
        //        Console.WriteLine("Not Q01");
        //        break;
        //}
        //Question: When should you prefer a switch statement over if-else?
        // because in if else the condition checks for all condition until it matches 
        // in switch case it do it in one step jumpes to matched value 
        // so the TimeMangemnt of switch is better than if else



        #endregion

        #region Problem9
        //int[] arr = { 10 , 1 , 7 ,  1 };
        //Array.Sort(arr);  //  1 , 1  , 7 , 10 
        //foreach (int i in arr) {
        //    Console.WriteLine(i);
        //}

        //Console.WriteLine("****************");
        //Console.WriteLine(Array.IndexOf(arr, 1)); // 0
        //Console.WriteLine(Array.LastIndexOf(arr, 1)); // 1
        //// Question: What is the time complexity of Array.Sort()? 
        ////  the average and worst-case time complexity is O(n log n).
        #endregion


        #region Problem10
        //int[] arr = { 1, 2, 3, 4, 5 }; // 15 
        //int sum = 0 ;
        ////using of Sum
        //for (int i = 0; i < arr.Length; i++) { 
        //    sum += arr[i];
        //}
        //Console.WriteLine($"Sum of Array {sum}");
        //// Sum Using Foreach 
        //int SumForeach = 0;
        //foreach (int i in arr) { 
        //SumForeach += i;
        //}
        //Console.WriteLine($"Sum of Array {SumForeach}");

        /*
         *Question: Which loop (for or foreach) is more efficient for calculating the sum of an 
           array, and why?
        They are Same in this Example for Readability the Sum but in performance for is better
        */

        #endregion
        #endregion

        #region Part02
        //Console.Write("Enter a number (1-7): ");

        //try
        //{
        //    if (int.TryParse(Console.ReadLine(), out int input))
        //    {
        //        if (input >= 1 && input <= 7)
        //        {
        //            DayOfWeek day = (DayOfWeek)input;
        //            Console.WriteLine($"The day is: {day}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //    }
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("An error occurred. Please try again.");
        //}


        // 3- What happens if the user enters a value outside the range of 1 to 7? 
        //The Program Executes Invalid Input
        #endregion


    }

}