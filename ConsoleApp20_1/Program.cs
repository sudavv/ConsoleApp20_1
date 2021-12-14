using System;

using System.Collections.Generic;

using System.IO;
using System.Linq;

namespace ConsoleApp3_4
{
    public class Program
    {
        delegate double MyDelegate(double a);

        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            Console.WriteLine("Введите радиус");
            double radius = 0;
            try
            {
                radius = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            }
            catch
            {
                Console.WriteLine("Не число");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }
            MyDelegate lenght = new MyDelegate(Lenght);
            MyDelegate square = new MyDelegate(Square);
            MyDelegate volume = new MyDelegate(Volume);
          
            Console.WriteLine("Длина окружности = {0}", lenght?.Invoke(radius));
            Console.WriteLine("Площадь круга = {0}", square?.Invoke(radius));
            Console.WriteLine("Объём шара = {0}", volume?.Invoke(radius));
            Console.ReadKey();
        }
        public static double Lenght(double r)
        {
            return 2*Math.PI*r;
        }

        public static double Square(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }

        public static double Volume(double r)
        {
            return (Math.PI * 4/3) * Math.Pow(r,3);
        }
    }
}



