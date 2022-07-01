using geoCalc;
using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region circle tests

            Console.WriteLine($"-------Circle Static Tests-------\n" );

            //Normal calculation
            Console.WriteLine($"Area: {Circle.Area(3)}\n");

            //Argument exception
            try
            {
                Console.WriteLine($"Area exception variable: {Circle.Area(-1)}\n");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"{ae.Message}\n");
            }


            Console.WriteLine($"-------Circle Non-static Tests-------\n");

            var a = new Circle(2);

            //Normal Calculation

            Console.WriteLine($"Area: {a.Area()}\n");

            //Argument Exception
            try
            {
                var a1 = new Circle(-1);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Invalid variable exception in constructor: {ae.Message}\n");
            }
            #endregion


            #region triangle tests

            Console.WriteLine($"-------Triangle Static Tests-------\n");

            //Normal Area Test
            Console.WriteLine($"Area: {Triangle.Area(2, 3, 4)}\n");

            try
            {
                Console.WriteLine($"{Triangle.Area(-1, 3, 0)}\n");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Area exception, incorrect side value: {ae.Message}\n");
            }

            try
            {
                Console.WriteLine($"{Triangle.Area(1, 4, 2)}\n");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Area exception, incorrect sides: {ae.Message}\n");
            }
            #endregion

            Console.WriteLine($"Is Triangle Right (3, 4, 5)?: {Triangle.isRight(3, 4, 5)}\n");

            Console.WriteLine($"Is Triangle Right? (4, 4, 5): {Triangle.isRight(4, 4, 5)}\n");

            Console.WriteLine($"-------Triangle Non-static Tests-------\n");
                
            var b = new Triangle(3, 4, 5);
            var c = new Triangle(2, 3, 4);

            //Normal Area calculation

            Console.WriteLine($"Area: {a.Area()}\n");

            Console.WriteLine($"Is triangle Right? (3, 4, 5): {b.isRight()}\n");

            Console.WriteLine($"Is triangle Right? (2, 3, 4): {c.isRight()}\n");

            //Exceptions

            try
            {
                var b1 = new Triangle(-1, 2, 3);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Area exception, incorrect side value: {ae.Message}\n");
            }

            try
            {
                var b1 = new Triangle(1, 4, 1);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Area exception, incorrect sides: {ae.Message}\n");
            }


        }
    }
}

