using System;
using System.Collections.Generic;
namespace Lab31
{
       class Program
       {
           static void Main(string[] args)
           {
               string s = Console.ReadLine();
               int bestLength = int.MaxValue;
               List<string> bestWords = new List<string>();
               foreach (string word in s.Split(' '))
               {
                   if (word.Length == bestLength)
                   {
                       bestWords.Add(word);
                   }
                   else if (word.Length < bestLength)
                   {
                       bestLength = word.Length;
                       bestWords = new List<string>() { word };
                   }
               }
   
               foreach (string word in bestWords)
               {
                   Console.WriteLine(word);
               }
   
               Console.ReadKey();
           }
       }
   }