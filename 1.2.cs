using System;
namespace _9._2
{
    class Program
    {
        struct Circle
        {
            public double x0;
            public double y0;
            public double R;

            public Circle(double x0, double y0, double R)
            {
                this.x0 = x0;
                this.y0 = y0;
                this.R = R;
            }
            public void Type()
            {
                if (R >= Math.Abs(x0) && R < Math.Abs(y0)) { Console.WriteLine("пересекает ось Oy"); }
                else if (R >= Math.Abs(y0) && R < Math.Abs(x0)) { Console.WriteLine("пересекает ось Ox"); }
                else if (R >= Math.Abs(y0) && R >= Math.Abs(x0)) { Console.WriteLine("пересекает ось Ox и Oy"); }
                else Console.WriteLine("не пересекает ни одну ось");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите количество окружностей");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("координаты центра окружности x0, y0 и радиус");
                double x0 = double.Parse(Console.ReadLine());
                double y0 = double.Parse(Console.ReadLine());
                double R = double.Parse(Console.ReadLine());
                Circle p = new Circle(x0, y0, R);
                p.Type();
            }
            Console.ReadLine();
        }
    }
}
