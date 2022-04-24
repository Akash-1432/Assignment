using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    internal class TenMarks
    {
        public void studentTenMarks()
        {
            int number;
            Console.WriteLine("Please enter array size");
            number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[number];
            Console.WriteLine("Please enter your marks");
            for (int indexer = 0; indexer < number; indexer++)
            {
                arr[indexer] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("your enterd marks is ");
            for (int indexer = 0; indexer < number; indexer++)
            {
                Console.WriteLine(arr[indexer]);
            }
            Console.WriteLine("Your total Marks is : " + arr.Sum());
            Console.WriteLine("Your Average Marks is : " + arr.Average());
            Console.WriteLine("Your minimum marks is :" + arr.Min());
            Console.WriteLine("Your maximum marks is :" + arr.Max());
            Array.Sort(arr);
            Console.WriteLine("Result of array sort");
            foreach (int index in arr)
            {
                Console.WriteLine(index);
            }
            int temp = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = i + 1; j < number; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array values assending order is");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
