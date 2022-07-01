using System;
using System.Collections.Generic;
using System.Linq;

namespace geoCalc
{

    public interface Figure
    {
        public double Area();



    }
    public class Circle : Figure
    {
        public double _r { get; set; }

        public Circle (double r)
        {
            _r = r;

            if (_r <= 0)
            {
                throw new ArgumentException("Radius of a circle must be greater than zero");
            }
        }

        public double Area()
        {
            return (Math.PI * Math.Pow(_r, 2));
        }

        public static double Area(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Radius of a circle must be greater than zero");
            }
            return (Math.PI * Math.Pow(r, 2));

        }
    }

    public class Triangle : Figure
    {
        public double _a { get; set; }
        public double _b { get; set; }
        public double _c { get; set; }

        public Triangle (double a, double b, double c)
        {
            if(a <=0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Side of the triangle must be greater then zero.");
            }

            if(a >= b+c || b >= a+c || c >= a + b)
            {
                throw new ArgumentException("Invalid triangle parameters. Sum of two sides can not be less then length of the other side.");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        public double Semiperimeter()
        {
            return (_a + _b + _c) / 2;
        }

        public double Area()
        {
            return Math.Sqrt(Semiperimeter() * (Semiperimeter() - _a) * (Semiperimeter() - _b) * (Semiperimeter() - _c));
        }

        public bool isRight()
        {
            var sides = new List<double> { _a, _b, _c };

            double greaterSide = sides.Max();

            sides.Remove(greaterSide);

            if (Math.Pow(greaterSide, 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
            {
                return true;
            }

            return false;

        }

        public static double  Area (double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Side of the triangle must be greater then zero.");
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Invalid triangle parameters. Sum of two sides can not be less then length of the other side.");
            }

            var Semiperimeter = (a + b + c) / 2;

            return Math.Sqrt(Semiperimeter * (Semiperimeter - a) * (Semiperimeter - b) * (Semiperimeter - c));
        }

        public static bool isRight(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Side of the triangle must be greater then zero.");
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Invalid triangle parameters. Sum of two sides can not be less then length of the other side.");
            }


            var sides = new List<double> { a, b, c };

            double greaterSide = sides.Max();

            sides.Remove(greaterSide);

            if (Math.Pow(greaterSide, 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
            {
                return true;
            }

            return false;
        }

    }
     
}
