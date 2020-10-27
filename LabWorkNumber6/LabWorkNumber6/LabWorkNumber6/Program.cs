using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabWorkNumber6
{
    class Ball
    {
        private double radius;

        public void Set_radius(double pradius) { radius = pradius; }

        public double Get_radius() { return radius; }


        public double GetD()
        {
            return radius * 2;
        }
        public double GetV()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
        public double GetS()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public void PrintFullInformation()
        {
            string str = "       **\n" +
                                  "   *         *\n" +
                                  " *              *\n" +
                                  "*       ШАР      *\n" +
                                  "*                *\n" +
                                  " *              *\n" +
                                  "   *          *\n" +
                                  "       ****\n";


            Console.WriteLine(str);

            Console.WriteLine("Радиус шара равен {0}", radius);
            Console.WriteLine("Обьем шара равен {0}", GetV());
            Console.WriteLine("Площадь шара равна {0}", GetS());
            Console.WriteLine("Диаметр шара равна {0}", GetD());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Шар";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            Ball p;

            p = new Ball();
            p.Set_radius(10.5);


            p.PrintFullInformation();
            Console.ReadKey();
        }
    }
}
