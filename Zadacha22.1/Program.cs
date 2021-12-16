using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha22._1
{
    class Program
    {
        static int[] Array;
        static void Sum()
        {
            int sum = 0;
            foreach (int i in Array)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма чисел массива равна {sum}.");
        }
        static void Max(Task task)
        {
            int max = 0;
            foreach (int i in Array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Максимальное число в массиве: {max}.");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер одномерного массива: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());

            if (lengthArray > 0)
            {
                Array = new int[lengthArray];
            }
            else
            {
                Console.WriteLine("Ошибка! Размер массива далжен быть больше нуля.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();
            Console.Write("Сформированный массив: ");

            Random random = new Random();
            for (int i = 0; i < lengthArray; i++)
            {
                Array[i] = random.Next(-1000, 1000);
                Console.Write($"{Array[i]} ");
            }
            Console.Write(";");
            Console.WriteLine();
            Console.WriteLine();

            Task task1 = new Task(Sum);
            Action<Task> action = new Action<Task>(Max);
            Task task2 = task1.ContinueWith(action);

            task1.Start();

            Console.ReadKey();
        }
    }
}
