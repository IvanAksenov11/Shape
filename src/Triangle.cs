using System;

namespace Square
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            // если введенные числа могут быть сторонами треугольника, инициализируем поля
            if (a > 0 && b > 0 && c > 0 && IsTriangle(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            //иначе выбросим исключение
            else throw new ArgumentException("numbers can't be sides of triangle");
        }

        bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a; 
        }

        //треугольник прямоугольный?
        public bool IsRight()
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a;
        }

        //поиск площади по формуле Герона
        public double getSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        public double A
        {
            get { return a;}
            set
            {
                if (IsTriangle(value, b, c) && value > 0)
                    a = value;
                else
                    throw new ArgumentException("wrong number");
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (IsTriangle(a, value, c) && value > 0)
                    b = value;
                else
                    throw new ArgumentException("wrong number");
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (IsTriangle(a, b, value) && value > 0)
                    c = value;
                else
                    throw new ArgumentException("wrong number");
            }
        }

        private double a;
        private double b;
        private double c;
    }
}
