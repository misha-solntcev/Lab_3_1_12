using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 12. Дано целое число N (> 1). Вывести наибольшее из целых чисел K, 
    для которых сумма 1 + 2 + … + K будет меньше или равна N, 
    и саму эту сумму. */

namespace Lab_3_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 104;
            int sum = 0;
            int K = 0;
            while (sum <= N)
            {
                K++;                               
                sum += K;
                Console.WriteLine($"K = {K}, sum = {sum}");
            }            
            Console.ReadKey();
        }
    }
}
