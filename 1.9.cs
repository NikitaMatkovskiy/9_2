using System;


class Program
{
    public struct Time
    {
        public int h, m, s;

        public long kolsek()
        {
            return s + m * 60 + h * 60 * 60;
        }

        public void Show()
        {

            Console.WriteLine("с начала суток прошло {0} сек.", kolsek());
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Введите количество моментов времени: ");
        int n = int.Parse(Console.ReadLine());
        Time[] array = new Time[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите день часы, минуты, секунды", i + 1);
            Console.Write("\th=");
            array[i].h = int.Parse(Console.ReadLine());
            if (array[i].h < 0 && array[i].h > 24) { break; }
            Console.Write("\tm=");
            array[i].m = int.Parse(Console.ReadLine());
            if (array[i].m < 0 && array[i].m > 60) { break; }
            Console.Write("\ts=");
            array[i].s = int.Parse(Console.ReadLine());
            if (array[i].s < 1 && array[i].s > 60) { break; }
            array[i].Show();
        }
        Console.ReadLine();
    }
}
