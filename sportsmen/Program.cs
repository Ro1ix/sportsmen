using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("РЕЗУЛЬТАТЫ ПЯТИБОРЬЯ\n");
            int[,] results = new int[10, 5];
            Random random = new Random();
            double average = 0;
            double prev_average = 0;
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i + 1 < 10)
                    Console.Write($"Спортсмен {i + 1}       ");
                else
                    Console.Write($"Спортсмен {i + 1}      ");
                for (int j = 0; j < 5; j++)
                {
                    results[i, j] = random.Next(1, 11);
                    if (results[i, j] < 10)
                        Console.Write($"{results[i, j]}    ");
                    else
                        Console.Write($"{results[i, j]}   ");
                    average = average + results[i, j];
                }
                average = Math.Round(average / 5, 2);
                if (prev_average < average)
                {
                    prev_average = average;
                    max = i + 1;
                }
                Console.WriteLine($"  Ср. оцен. {average}\n");
                average = 0;
            }
            Console.WriteLine($"У спортсмена {max} наивысшая средняя оценка");
        }
    }
}
