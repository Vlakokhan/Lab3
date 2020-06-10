using System;

namespace Lab_31A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = 0;
            foreach (var variable in s)
            {
                if (char.IsUpper(variable))
                {
                    k++;
                }
            }
            Console.WriteLine("Кiлькiсть великих лiтер: "+k);
            Console.ReadKey();
        }
    }
} 
