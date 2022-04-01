using System;

namespace FiguresArea
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        //Метод вычисляет площадь круга по радиусу
        public virtual double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
