using System;
using System.IO;
using System.Linq;

namespace Lab32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть чисел: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введiть n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введiть {i+1} елемент: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            File.WriteAllText("C:\\Users\\vladi\\RiderProjects\\Lab32\\numbers.txt", string.Join(" ", arr));

            string[] arr2 = File.ReadAllText("numbers.txt").Split(' ').ToArray();
            int count = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (int.Parse(arr2[i]) > n) count++;
            }
            Console.WriteLine($"Кiлькiсть чисел бiльших за {n}: {count}");
        }
    }
} 
