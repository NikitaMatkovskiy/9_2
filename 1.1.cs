using System;
namespace _9._2
{
    class Program
    {
        struct Parallelogram
        {
            public int a;
            public int b;
            public double Alf;

            public Parallelogram(int a, int b, double Alf)
            {
                this.a = a;
                this.b = b;
                this.Alf = Alf;
            }
            public string Type()
            {
                if (a == b && Alf == 90) { return "квадрат"; }
                else if ((a > b || a < b) && Alf == 90) { return "прямоугольник"; }
                else return "ромб";
            }
            public void Type1()
            {
                if (a == b && Alf == 90) { Console.WriteLine("квадрат"); }
                else if ((a > b || a < b) && Alf == 90) { Console.WriteLine("прямоугольник"); }
                else Console.WriteLine("ромб");
            }
        }

        static void Main(string[] args)
        {
            int Q = 0, P = 0, R = 0;
            Console.WriteLine("введите количество фигур");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("введите стороны a, b и угол между ними альфа");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                double Alf = double.Parse(Console.ReadLine());
                Parallelogram p = new Parallelogram(a, b, Alf);
                p.Type1();
                if (p.Type() == "квадрат") { Q = Q + 1; }
                else if (p.Type() == "прямоугольник") { P = P + 1; }
                else if (p.Type() == "ромб") { R = R + 1; }
            }
            Console.WriteLine("количество квадратор : {0}", Q);
            Console.WriteLine("количество прямоугольников : {0}", P);
            Console.WriteLine("количество ромбов : {0}", R);
            Console.ReadLine();
        }
    }
}
