using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Создать класс треугольник, члены класса – длины 3-х сторон. Предусмотреть в классе методы
проверки существования треугольника, вычисления и вывода сведений о фигуре – длины сторон, углы,
периметр, площадь. Создать производный класс – равнобедренный треугольник, предусмотреть в
классе проверку, является ли треугольник равнобедренным. Написать программу, демонстрирующую
работу с классом: дано N треугольников и M равнобедренных треугольников, найти среднюю площадь
для N треугольников и равнобедренный треугольник с наименьшей площадью.
*/
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle trangle = new Triangle(10, 11, 12);
            bool exists = trangle.Exists();
            if (!exists)
            {
                Console.WriteLine("The triangle does not exist");
                return;
            }
            Console.WriteLine("Triange info:");
            trangle.PrintInfo();

            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(10, 20);
            bool isIsoscelesTriangle = isoscelesTriangle.IsIsoscelesTriangle();
            if (isIsoscelesTriangle)
                Console.WriteLine("Triange is isosceles");
            else
                Console.WriteLine("Triange is not isosceles");

            Console.WriteLine("IsoscelesTriangle info:");
            isoscelesTriangle.PrintInfo();

            /////////////////////////////////////////////
            ///
            Triangle triangle1 = new Triangle(10, 11, 12);
            Triangle triangle2 = new Triangle(10, 11, 12);
            Triangle triangle3 = new Triangle(10, 11, 12);

            IsoscelesTriangle isoscelesTriangle1 = new IsoscelesTriangle(10, 20);
            IsoscelesTriangle isoscelesTriangle2 = new IsoscelesTriangle(10, 22);
            IsoscelesTriangle isoscelesTriangle3 = new IsoscelesTriangle(10, 24);

            double trianglesSquare = triangle1.GetSquare() + triangle2.GetSquare() + triangle3.GetSquare();
            double midSq = trianglesSquare / 3;
            Console.WriteLine($"Mid Square: {midSq}");

            double isq1 = isoscelesTriangle1.GetSquare();
            double isq2 = isoscelesTriangle2.GetSquare();
            double isq3 = isoscelesTriangle3.GetSquare();

            double minSq = Math.Min(isq1, isq2);
            minSq = Math.Min(minSq, isq2);
            Console.WriteLine($"Min Square: {minSq}");

            Console.ReadKey();
        }
    }
}