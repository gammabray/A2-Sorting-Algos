using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    static class Printers
    {
        public static void Print<T>(this T[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
   
    class Program
    {
        static int[] createRandomArray(int size)
        {
            int[] array = new int[size];
            Random r = new Random();
           
            for(int i = 0; i < size; i++)
            {
                array[i] = r.Next(1, 10000);
            }
            return array;
        }
        static void Main(string[] args)
        {
            TimeSpan quicktime = Benchmark(createRandomArray(10000), QuickSort.Sort);
            Console.WriteLine("Quick Sort took " + quicktime.ToString(@"mm\:ss\.fffffff"));
            TimeSpan mergetime  = Benchmark(createRandomArray(10000), MergeSort.Sort);
            Console.WriteLine("Merge Sort took " + mergetime.ToString(@"mm\:ss\.fffffff"));
            TimeSpan instime    = Benchmark(createRandomArray(10000), InsertionSort.Sort);
            Console.WriteLine("Insertion Sort took " + instime.ToString(@"mm\:ss\.fffffff"));
            TimeSpan bubbletime = Benchmark(createRandomArray(10000), BubbleSort.Sort);
            Console.WriteLine("Bubble Sort took " + bubbletime.ToString(@"mm\:ss\.fffffff"));
            
            Console.ReadKey();

        }
       
        static TimeSpan Benchmark<T>(T[] array, Action<T[]> algorithm)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            algorithm(array);
            
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
