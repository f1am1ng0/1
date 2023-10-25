using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shape
    {
        protected double Area { get; set; }

        public Shape()
        {
            Area = 0;
        }
    }

    public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double CalculateArea(double length, double width)
        {
            this.Length = length;
            this.Width = width;
            Area = Length * Width;
            return Area;
        }
    }

    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double CalculateArea(double radius)
        {
            this.Radius = radius;
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
