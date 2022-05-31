using System;


class Program
{
    public struct RectParallelepiped
    {
        public double a, b, h;
        public double V()
        {
            return a * b * h;
        }
        public double S()
        {
            return 6 * (a * b);
        }
        public void Show()
        {
            Console.WriteLine("объем : {0}, площадь поверхности : {1}", V(), S());
        }
    }
    static void Main(string[] args)
    {
        int nV = 0, nS = 0;
        Console.WriteLine("Введите количество Прямоугольных Параллелепипедов: ");
        int n = int.Parse(Console.ReadLine());
        RectParallelepiped[] array = new RectParallelepiped[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите стороны основания и высоту {0}-го параллелепипеда", i + 1);
            Console.Write("\ta=");
            array[i].a = double.Parse(Console.ReadLine());
            Console.Write("\tb=");
            array[i].b = double.Parse(Console.ReadLine());
            Console.Write("\th=");
            array[i].h = double.Parse(Console.ReadLine());
            array[i].Show();
            double vmin = array[0].V();
            double smax = array[0].S();
            if (array[i].V() < vmin) { vmin = array[i].V(); nV = i; }
            if (array[i].S() > smax) { smax = array[i].S(); nS = i; }
        }
        Console.WriteLine("наименьший объем у {0}-го параллелепипеда", nV + 1);
        Console.WriteLine("наибольшая площадь у {0}-го параллелепипеда", nS + 1);
        Console.ReadLine();
    }
}
