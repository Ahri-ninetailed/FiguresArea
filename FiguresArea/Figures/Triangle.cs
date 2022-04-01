using System;

namespace FiguresArea
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Сторона треугольника не может быть отрицательной");
            if (a == 0 || b == 0 || c == 0)
                throw new ArgumentException("Сторона треугольника не может быть равной 0");
            if (!(a + b > c && a + c > b && b + c > a))
                throw new ArgumentException("Треугольник существует только тогда, когда сумма двух его сторон больше третьей");
            A = a;
            B = b;
            C = c;
        }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        //Метод определяет прямоугольный ли треугольник или нет
        protected virtual bool IsRectangular()
        {
            //Найдем большую сторону
            double longestSide = Math.Max(Math.Max(A, B), C);
            //Найдем остальные меньшие стороны
            double otherSide1, otherSide2;
            if (longestSide == A)
            {
                otherSide1 = B;
                otherSide2 = C;
            }
            else if (longestSide == B)
            {
                otherSide1 = A;
                otherSide2 = C;
            }
            else
            {
                otherSide1 = A;
                otherSide2 = B;
            }
            //Если теорема Пифагора выполняется - то треугольник прямоугольный. c^2 = a^2 + b^2, где c наибольшая сторона 
            if (Math.Pow(longestSide, 2) == Math.Pow(otherSide1, 2) + Math.Pow(otherSide2, 2))
            {
                //Если треугольник прямоугольный, то присвоим катетам и гипотенузе значения
                A = otherSide1;
                B = otherSide2;
                C = longestSide;
                return true;
            }
            else
                return false;
        }
        public virtual double Area()
        {
            //Если треугольник прямоугольный, то найдем площадь по формуле для прямоугольного треугольника
            if (IsRectangular())
            {
                return (A * B) / 2;
            }
            //Если нет, то найдем площадь по трем сторонам
            else
            {
                //Полупериметр
                double p = (A + C + B) / 2;
                //Ответ округляется до 3 знаков после запятой
                return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 3);
            }
        }
    }
}
