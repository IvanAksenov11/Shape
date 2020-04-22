using System;

namespace Square
{
    public class Circle : Shape
    {
        public Circle(double r)
        {
            if (r > 0)
                this.r = r;
            else
                throw new ArgumentException("r must be more than zero");
        }
        public double getSquare()
        {
            return Math.PI * r * r;
        }

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("r must be more than zero");
                r = value;
            }
        }
       
         private double r;
    }
}
