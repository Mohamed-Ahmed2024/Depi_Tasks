


using System.Text;

namespace Task3
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            #region Problem1
            //string name;
            //int parsedname;
            //Console.WriteLine("Enter Any String ");
            //name = Console.ReadLine();
            //try
            //{
            //    parsedname = int.Parse(name);
            //    Console.WriteLine("Parsed Number Using int.parse succeeded)"+ parsedname);
            //}
            //catch {


            //    Console.WriteLine("Can't Convert DataType from String to int");

            //}

            //try {
            //    parsedname = Convert.ToInt32(name);
            //    Console.WriteLine("Parsed Number Using convert.ToInt32 succeeded " + parsedname);

            //}
            //catch{
            //    Console.WriteLine("Parsing Usint Convert isn't succeeded ");

            //}


            #endregion

            #region Problem2
            //Console.Write("Please enter a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("You entered a valid integer: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Error: That is not a valid integer.");
            //}
            /*
            *  Question: Why is TryParse recommended over Parse in user-facing applications?
            *  The Answer : Because Try.parse the Return Value From it is Boolean Value dosen't cause the Program to fail
            */
            #endregion

            #region Problem3
            //object obj;


            //obj = 42;
            //Console.WriteLine("int value: " + obj);
            //Console.WriteLine("GetHashCode: " + obj.GetHashCode());

            //Console.WriteLine("--------------------------");


            //obj = "Hello";
            //Console.WriteLine("string value: " + obj);
            //Console.WriteLine("GetHashCode: " + obj.GetHashCode());

            //Console.WriteLine("--------------------------");


            //obj = 3.14;
            //Console.WriteLine("double value: " + obj);
            //Console.WriteLine("GetHashCode: " + obj.GetHashCode());

            //Console.WriteLine("--------------------------");
            #endregion

            #region Problem4
            //Point p1 = new Point();
            //p1.X = 1;
            //p1.Y = 2;
            //Console.WriteLine("Point1 X  " + p1.X);
            //Console.WriteLine("Point1 X  " + p1.Y);
            //Point p2 = new Point();
            //p2 = p1;
            //// Make P2 Refrence 
            //p2.X = 10;
            //p2.Y = 20;
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Point1 X  " + p1.X);
            //Console.WriteLine("Point1 X  " + p1.Y);







            #endregion

            #region Problem5
            //string message = "Welcome ";
            //Console.WriteLine("Original string: " + message);
            //Console.WriteLine("HashCode before modification: " + message.GetHashCode());

            //message += "Hi Willy";
            //Console.WriteLine("Modified string: " + message);
            //Console.WriteLine("HashCode after modification: " + message.GetHashCode());

            #endregion

            #region Problem6
            //StringBuilder sb = new StringBuilder("Welcome");

            //Console.WriteLine($"Hash code before: {sb.GetHashCode()}");

            //sb.Append(" Hi Willy ");

            //Console.WriteLine($"Hash code after: {sb.GetHashCode()}");

            //Console.WriteLine($"Final string: {sb.ToString()}");
            #endregion


            #region Problem7
            //Console.WriteLine("Enter The First Number ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Second Number ");
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = num1 + num2;
            //// Concatenation
            //Console.WriteLine("Sum of  " + num1 + "+" + num2 + "=" + sum);
            //// composite formatting
            //Console.WriteLine(string.Format("Sum of {0}+{1}={2}", num1, num2, sum));
            ////interpolatiom
            //Console.WriteLine($"Sum is {num1}+{num2}={sum}");





            #endregion







        }

    }

}