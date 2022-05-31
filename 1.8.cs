using System;


class Program
{
    public struct Date
    {
        public double d, m;
        public int y;
        public double Decada()
        {
            if (d >= 1 && d <= 10)
                return 1;
            if (d >= 11 && d <= 20)
                return 2;
            else
                return 3;
        }
        public string VrGoda()
        {
            if (m >= 1 && m < 3 && m == 12) { return "зима"; }
            else if (m >= 3 && m < 6) { return "весна"; }
            else if (m >= 6 && m < 9) { return "лето"; }
            else return "осень";
        }
        public int CenturyOfYear()
        {
            return (y - 1) / 100 + 1;
        }
        public void Show()
        {

            Console.WriteLine("декада {0}-я , время года {1}, {2} век", Decada(), VrGoda(), CenturyOfYear());
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Введите количество человек: ");
        int n = int.Parse(Console.ReadLine());
        Date[] array = new Date[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите день рождения, месяц рождения, год рождения", i + 1);
            Console.Write("\td=");
            array[i].d = double.Parse(Console.ReadLine());
            if (array[i].d < 1 && array[i].d > 31) { break; }
            Console.Write("\tm=");
            array[i].m = double.Parse(Console.ReadLine());
            if (array[i].m < 1 && array[i].m > 12) { break; }
            Console.Write("\ty=");
            array[i].y = int.Parse(Console.ReadLine());
            if (array[i].d > 9999) { break; }
            array[i].Show();
        }
        Console.ReadLine();
    }
}
