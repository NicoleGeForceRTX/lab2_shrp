using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_shrp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;
            int div = 0;
            Console.WriteLine("Введите число a");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("a = " + a);
            Console.WriteLine("Введите число b, не равное нулю");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
           
                int summ = a + b;
                int diff = a - b;
                int mult = a * b;
                if (b == 0)
                {
                    Console.WriteLine("на ноль делить нельзя");
                }
                else
            { 
                div = a / b;
            }
            if (b == 0)
            {
                Console.WriteLine("a + b = " + summ + "; a - b = " + diff + "; a * b = " + mult + "; a / b = " + div);
            }
            else
            {
                Console.WriteLine("a + b = " + summ + "; a - b = " + diff + "; a * b = " + mult);
            }
                Console.WriteLine("Число элементов массива = a ");
                int elementsCount = a;
                int[] myArray = new int[elementsCount];

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"Введите элемент массива индексом {i}: \t");
                    myArray[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Вывод одномерного массива: ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

        }
    }
}
