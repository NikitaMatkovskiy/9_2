using System;


class Program
{
    public struct Point
    {
        public double X1, Y1;
        public void Show()
        {
            if (X1 > 0 && Y1 > 0)
                Console.WriteLine("точка находится в 1 четверти");
            else if (X1 > 0 && Y1 < 0)
                Console.WriteLine("точка находится во 2 четверти");
            else if (X1 < 0 && Y1 < 0)
                Console.WriteLine("точка находится в 3 четверти");
            else if (X1 < 0 && Y1 > 0)
                Console.WriteLine("точка находится в 4 четверти");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество точек: ");
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите координаты {0}-й точки", i + 1);
            Console.Write("\tX1=");
            points[i].X1 = double.Parse(Console.ReadLine());
            Console.Write("\tY1=");
            points[i].Y1 = double.Parse(Console.ReadLine());
            points[i].Show();
        }
        Console.ReadLine();
    }
}
