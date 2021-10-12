using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0]; //почему присваиваем значение по массиву? если написать max=0 будет тоже самое ведь?
            int min = array[0];
            foreach (int a in array)
            {
                if (a>max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }                
            }
            Console.WriteLine("Максимальное число = {0}",max);
            Console.WriteLine("Минимальное число = {0}", min);
            Console.WriteLine("Сумма max и min чисел = {0}",max+min);
            Console.ReadKey();
        }
    }
}
