using System;
    class Program
    {
        public struct Тriangle
    {
            public int a, b, c;

        public string Type()
        {
            if (a == b && b == c) return "равносторонний";
            else if ((a == b && a != c) || (a != b && a == c) || (c == b && c != a)) return "равнобедренный";
            else return "разносторонний";
        }

            public void Show()
            {
            
             Console.WriteLine("треугольник {0}", Type()); 
            }
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Введите количество треугольников: ");
        int n = int.Parse(Console.ReadLine());
        Тriangle[] array = new Тriangle[n];
        int Q = 0, P = 0, R = 0;
        for (int i = 0; i < n; i++)
            {            
                Console.WriteLine("Введите стороны треугольника a, b, c", i + 1);
                Console.Write("\ta=");
                array[i].a = int.Parse(Console.ReadLine());
            if (array[i].a < 0)  { break; }
                Console.Write("\tb=");
                array[i].b = int.Parse(Console.ReadLine());
            if (array[i].b < 0) { break; }
            Console.Write("\tc=");
                array[i].c = int.Parse(Console.ReadLine());
            if (array[i].c < 0) { break; }
            array[i].Show();
            if (array[i].Type() == "равнобедренный") { Q = Q + 1; }
            else if (array[i].Type() == "равносторонний") { P = P + 1; }
            else if (array[i].Type() == "разносторонний") { R = R + 1; }
        }
        Console.WriteLine("количество равнобедренных : {0}", Q);
        Console.WriteLine("количество равносторонних : {0}", P);
        Console.WriteLine("количество разносторонних : {0}", R);
        Console.ReadLine();
        }
    }