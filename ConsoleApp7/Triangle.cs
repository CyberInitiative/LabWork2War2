using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Triangle
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;    //стороны треугольника в сантиметрах

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public bool Exists() // метод проверки условия сущестования треугольника
        {
            bool result = sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
            return result;
        }

        public void PrintInfo()
        {
            double pi = 3.14;
            double a1 = ((sideB * sideB + sideC * sideC - sideA * sideA) / (2d * sideB * sideC));
            double a2 = (double)Math.Acos(a1);
            double a3 = (double)sideB * (double)Math.Sin(a2) / sideA;
            double b1 = (double)Math.Asin(a3) * 180d / pi;
            double b2 = a2 * 180d / pi;
            double c1 = 180d - a2 - b1;
            double square = GetSquare();
            double perimetr = GetPerimeter();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Стороны: {sideA}, {sideB}, {sideC}; Углы: {a2}, {b1}, {c1}; Периметр: {perimetr} см; Площадь: {square}.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        }

        public double GetSquare()
        {
            double a1 = ((sideB * sideB + sideC * sideC - sideA * sideA) / (2d * sideB * sideC));
            double a2 = (double)Math.Acos(a1);
            double square = (0.5 * sideA * sideB * a2);
            return square;
        }

        public double GetPerimeter()
        {
            double perimeter = sideA + sideB + sideC;
            return perimeter;
        }
    }
}
