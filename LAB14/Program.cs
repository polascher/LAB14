using System;

namespace LAB14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int M = 10;
            int[,] mas = new int[M, M];

            Console.WriteLine("Введите минимальное значение: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            for (int i = 0; i < M; i++)
                for (int j = 0; j < M; j++)
                    mas[i, j] = r.Next(min, max);

            for(int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(mas[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}