using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        /// <summary>
        /// Примеры способов заполнения одномерного массива
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //1. Выполнить инициализацию одномерного массива
            //с использованием конструктора без указания значений элементов,
            //заполнить массив с клавиатуры и вывести на экран
            //Console.Write("Размер одномерного массива n: ");
            //byte n=byte.Parse(Console.ReadLine());
            //int[]omas= new int[n];
            //int i;
            //Console.WriteLine("Заполнение одномерного массива с клавиатуры");
            //for (i = 0; i < n; i++) 
            //{
            //    Console.Write($"omas[{i}]= ");
            //    omas[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод заполненного одномерного массива");
            //for(i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}"); 
            //}

            //2. Инициализировать одномерный массив с использованием конструктора,
            //без указания размерности массива и без клавиатуры
            //int[] omas = new int[]{ 5, -8, 6, 11, -2, 13 };
            //Console.WriteLine("Вывод заполненного одномерного массива");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}");
            //}

            //3. Заполнить одномерный массив соответствующими индексами (по формуле)
            //и вывести с использованием цикла foreach
            //int[] omas = new int[5];
            //int i;
            //for (i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = i;
            //}
            //Console.WriteLine("Вывод заполненного одномерного массива");
            //1-й способ вывода
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}]= {omas[i]}");
            //}
            //2-й способ вывода
            //foreach (int element in omas)
            //{
            //    Console.Write($"{element}\t");
            //}

            //4. Заполнить одномерный массив случайным образом и
            //вывести на экран с использованием цикла foreach
            Console.Write("Размер одномерного массива n: ");
            byte n = byte.Parse(Console.ReadLine());
            int[] omas = new int[n];
            int i;
            Random random = new Random();
            for(i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next(-10,10); 
            }
            foreach (int element in omas)
            {
                Console.Write($"{element}\t");
            }
            Console.Read();
        }
    }
}
