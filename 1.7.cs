using System;


class Program
{
    public struct Parabola
    {
        public double a, b, c;
        public double X()
        {
            return -b / (2 * a);
        }
        public double Y()
        {
            return a * X() * X() + b * X() + c;
        }
        public double D()
        {
            return b * b - 4 * a * c;
        }
        public void Show()
        {
            if (D() == 0) { Console.WriteLine("парабола касается оси oX вершиной ({0}:{1})", X(), 0); }
            else if (D() > 0 && a > 0) { Console.WriteLine("парабола касается оси oX в точках ({0}:{1}) ({2}:{3})", (-b + Math.Sqrt(D()) / 2 * a), 0, (-b - Math.Sqrt(D()) / 2 * a), 0); }
            else if (D() > 0 && a < 0) { Console.WriteLine("парабола касается оси oX в точках ({0}:{1}) ({2}:{3})", (-b + Math.Sqrt(D()) / 2 * a), 0, (-b - Math.Sqrt(D()) / 2 * a), 0); }
            else Console.WriteLine("парабола не касается оси oX");
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Введите количество парабол: ");
        int n = int.Parse(Console.ReadLine());
        Parabola[] array = new Parabola[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите коэффициенты a,b,c {0}-й параболы", i + 1);
            Console.Write("\ta=");
            array[i].a = double.Parse(Console.ReadLine());
            Console.Write("\tb=");
            array[i].b = double.Parse(Console.ReadLine());
            Console.Write("\tc=");
            array[i].c = double.Parse(Console.ReadLine());
            array[i].Show();
        }
        Console.ReadLine();
    }
}
