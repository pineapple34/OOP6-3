using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            Triangle tr1 = new Triangle();
            Console.WriteLine("Введите стороны треугольника (через пробел):");
            string[] input = Console.ReadLine().Split(' ');

            try
            {
                if (input.Length > 3) goto Start;
                tr1.a = double.Parse(input[0]);
                tr1.b = double.Parse(input[1]);
                tr1.c = double.Parse(input[2]);
            }
            catch (Exception)
            {
                goto Start;
            }

            if (tr1.CheckExistence())
            {
                Console.WriteLine("Треугольник существует");
                tr1.CalculateAngles();
            }
            else Console.WriteLine("Треугольник не существует");

            Console.ReadKey();
        }
    }

    class Triangle
    {
        public double a, b, c, alpha, beta, gamma;

        public bool CheckExistence()
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }
        public void CalculateAngles()
        {
            alpha = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI;
            beta = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI;
            gamma = Math.Acos((Math.Pow(c, 2) + Math.Pow(b, 2) - Math.Pow(a, 2)) / (2 * c * b)) * 180 / Math.PI;
            Console.WriteLine("Углы: {0:#.##} градусов, {1:#.##} градусов, {2:#.##} градусов", alpha, beta, gamma);
        }
    }
}
