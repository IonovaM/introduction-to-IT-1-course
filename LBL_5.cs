using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBL_5_ionova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double[] A; //объявляется массив из чисел объявляется
            A = new double[20]; //инициализирование переменной массива (выделяем память)

            Random rand = new Random(); //создание объекта для генерации чисел

            //заполнение основного массива
            Console.WriteLine("    Основной массив :");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
            Console.WriteLine();


            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (A[j] < 0) 
                        { 
                            double x = A[i]; 
                            A[i] = A[j]; 
                            A[j] = x; 
                        }
                    }
                }
            }


            Console.WriteLine("    Полученный массив :");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
