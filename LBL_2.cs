using System;

namespace LBL_1_ionova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x  =  ");
            double x = Convert.ToDouble(Console.ReadLine()); //cчитывание х
            double f1;
            f1 = Math.Log(1 + x); //подсчёт левой части выражения
            double f2 = 0;
            double g = 0;
            int i = 1;
            //подсчёт правой части выражения
            do
            {
                g = Math.Pow(x, i) / i; //подсчёт слагаемого
                //цикл, меняющий знаки в моём выражении
                if (i % 2 == 0)
                    f2 -= g;
                else
                    f2 += g;
                i++;
            } while (Math.Abs(g) >= Math.Pow(10, -7)); //условие из текста задания

            Console.WriteLine("Левая часть выражения = " + "\t" + f1);
            Console.WriteLine("Правая часть выражения = " + "\t" + f2);
            Console.ReadKey();        
}
    }
}
