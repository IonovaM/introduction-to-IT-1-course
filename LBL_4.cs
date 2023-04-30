using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBL_2_ionova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] D; //объявляется массив из чисел объявляется
            D = new int[12]; //инициализирование переменной массива (выделяем память)
            int[] B; //объявляется массив из чисел объявляется
            B = new int[4]; //инициализирование переменной массива (выделяем память)
            int x, y;
            int k = 0;
            Random rand = new Random(); //создание объекта для генерации чисел
            
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = rand.Next(-20, 20);
            }


            //заполнение массива В, изменение чисел в парах из основного массива
            for (int i = 0; i < D.Length - 1; i++)
            {
                x = D[i];
                y = D[i + 1];
                if ((D[i] != 0) && (D[i + 1] != 0))
                {
                    D[i] = x + y;
                    D[i + 1] = x * y;
                }
                else
                {
                    B[k] = x;
                    B[k + 1] = y;
                    k++;
                }
            }

            //вывод результата
            Console.WriteLine("    Полученный массив с замененными числами:");
            for (int i = 0; i < D.Length; i++)
            {
                Console.Write(D[i] + "    ");
            }
            Console.WriteLine();

            Console.WriteLine("    Полученный массив В:");
            if (B[0] == 0)
                Console.WriteLine("В массив ниего не занесено");
            for (int j = 0; j < B.Length -1; j++)
            {
                if ((B[j] == 0) && (B[j + 1] == 0))
                {
                    break;
                }
                Console.Write(B[j] + "    ");
            }
            
            Console.ReadKey();
        }
    }
}

