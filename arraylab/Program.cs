using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab
{
    class Program
    {
        static void ShowArray(params int[] array)
        {
            long s = 0;// in order to prevent Sum OverflowException
            for (int i = 0; i < array.Length; i++)
            {
                
                s += array[i];
            }
            Console.WriteLine("Random nambers are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Max number is: {0} ", array.Max());
            Console.WriteLine("Min number is: {0} ", array.Min());
            Console.WriteLine("The sum of all nambers is: {0} ", s);
            Console.WriteLine("Numbers average is: {0} ", array.Average());
        }


        static void Main()
        {
            Console.WriteLine("Please, specify array length. ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[a];

             System.Random rand = new System.Random();
             for (int i = 0; i < a; i++)
             {
                array1[i] = rand.Next();
             }

            ShowArray(array1);

            // Delay.
            Console.ReadKey();

        }
    }
}
