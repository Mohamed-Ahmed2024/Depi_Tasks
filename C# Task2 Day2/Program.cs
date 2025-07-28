using System;

namespace C__Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            //int x = 10; // declare a variable of type int 
            //int y = 20; // declare a variable of type int
            //int sum = x + y; // summation for the two variables
            //Console.WriteLine(sum); /* Summamtion of the two variables*/
            #endregion
            #region Problem2
            //int y = 20;
            //// error in this code that assigned value of type string to a declared integer variable 
            //// we can remove double quotations to convert from string to integer

            //int x = 10;
            //Console.WriteLine(x+y);
            #endregion
            #region problem3
            //string StudentName = "Mohamed";
            //int StudentAge = 22;
            //float StudentSalary = 3500.500f;
            //bool IsSStudent = true;
            //#endregion
            //Console.WriteLine("Name " + StudentName);
            //Console.WriteLine("Age " + StudentAge);
            //Console.WriteLine("Salary " + StudentSalary);
            #endregion
            #region problem4
            //   Declared A variable of Ref Type
            //Employee e1;
            //e1 = new Employee();
            //e1.Name = "Mohamed";
            //e1.Id = 1;
            //Console.WriteLine("Employee Name    " + e1.Name);
            //Console.WriteLine("Employee ID " + e1.Id);
            //Console.WriteLine("**************************************************");
            //Employee e2 = new Employee();
            //// No Assigned Data To E2 Object 
            //Console.WriteLine("Employee Name   " + e2.Name);
            //Console.WriteLine("Employee ID " + e2.Id);
            //Console.WriteLine("**************************************************");

            //e2 = e1;
            //// make the pointer the refers to e2 refer to e1 
            //// if we print the data the e2 refer now will be assigned to e1 Data
            //Console.WriteLine("Employee Name    " + e2.Name);
            //Console.WriteLine("Employee ID " + e2.Id);
            //Console.WriteLine("**************************************************");
            #endregion
            #region problem5
            //int x = 15, y = 4;
            //int Sum = x + y;
            //int diff = x - y;
            //int mul = x * y;
            //float div = x / y; 
            //int remainder = x % y  ;

            //Console.WriteLine("Sum " + Sum);
            //Console.WriteLine("diiference " + diff);
            //Console.WriteLine("multiplacation  " +  mul);
            //Console.WriteLine("Divsion is " + div); 
            //Console.WriteLine("Remainder " + + remainder );

            #endregion
            #region problem6
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);
            //// the result will be 2 
            //int x = 8 , y = 7;
            //Console.WriteLine(x % y);
            //// the result will be 1

            #endregion
            #region problem7
            //Console.WriteLine("Enter A Number ");
            //int number = int.Parse(Console.ReadLine());

            //string result = (number > 10)  ? number %2 == 0 ? "Bigger Than 10 and even": "Bigger than 10 and not even" : "lower than 10";
            //Console.WriteLine(result);

            #endregion
            #region problem8
            //Console.WriteLine("Enter a Number");
            //double number = double.Parse(Console.ReadLine());
            ////explicit casting
            //int ExpCastedNumber = (int)number;
            //Console.WriteLine("Explicit Casting  " + ExpCastedNumber);

            //// implict casting
            //// will throw an exception this 
            //// implicit casting from double to int will cause datafault
            //int impCastedNumber = number;
            //Console.WriteLine("Explicit Casting  " + ExpCastedNumber);
            #endregion
            #region problem9
            //Console.WriteLine("Enter Your age");
            //int Age = int.Parse(Console.ReadLine());
            //if (Age > 0)
            //    Console.WriteLine(" OK ");
            //else { 
            //    Console.WriteLine("In valid");

            //}


            #endregion
            #region problem10
            //// difference between prefix and postfix
            //int x = 5; 
            //Console.WriteLine("the Value of x :  " + x++);
            //// now the statement will be print and then increment the value of x 
            ////  the value id x is 5 and x is now 6 
            //Console.WriteLine("the Value of x : " + ++x); // x is 7 
            #endregion




        }
    }
}
