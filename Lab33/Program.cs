using System;

namespace Lab33
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("C:\Users\vladi\RiderProjects\Lab33\input.txt");
            foreach (string s in "0 1 2 3 4 5 6 7 8 9".Split(' '))
            {
                text = text.Replace(s, "");
            }
            System.IO.File.WriteAllText("C:\Users\vladi\RiderProjects\Lab33\output.txt", text);

            Console.ReadKey();
        }
    }
} 
