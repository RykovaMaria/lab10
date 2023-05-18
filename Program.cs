using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BubbleSort
{
    class Program
    {        
         public static void Bubble_Sort(int[] anArray)
         {
             PrintArray(anArray);
 
             for (int i = 0; i < anArray.Length; i++)
             {
                 for (int j = 0; j < anArray.Length - 1 - i; j++)
                 {
                     if (anArray[j] > anArray[j + 1])
                     {
                         Swap(ref anArray[j], ref anArray[j + 1]);
                     }
                 }
 
                 PrintArray(anArray);
            }
        }

        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            int tmpParam = aFirstArg;
 
            aFirstArg = aSecondArg;
  
            aSecondArg = tmpParam;
        }
 
        public static void PrintArray(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                Console.Write(anArray[i] + " ");
            }
 
            //Перевод строки
            Console.WriteLine("\n");
        }
 
        static void Main(string[] args) 
        { 
            int[] someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0}; 
 
            Bubble_Sort(someArray); 
 
            Console.ReadKey(); 
        }
    }
}