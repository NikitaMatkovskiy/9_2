using System;
namespace _9._2
{
    class Program
    {
        struct Rectangle
        {
            public double x, y, x1, y1, x2, y2;

            public Rectangle(double x, double y, double x1, double y1, double x2, double y2)
            {
                this.x = x;
                this.y = y;
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }

            public void Type()
            {
                if ((x - x1) * (x - x2) <= 0 && (y - y1) * (y - y2) <= 0) Console.WriteLine("точка лежит в прямоугольнике");
                else Console.WriteLine("точка не лежит в прямоугольнике");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите точку x,y");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("введите количество прямоугольников");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("вершину прямоугольника x1,y1");
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("вершину прямоугольника x2,y2");
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                Rectangle p = new Rectangle(x, y, x1, y1, x2, y2);
                p.Type();
            }
            Console.ReadLine();
        }
    }
}
