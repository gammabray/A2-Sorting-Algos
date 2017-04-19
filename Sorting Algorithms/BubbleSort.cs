using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
   public class BubbleSort 
    {
       
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            for(int i = 1; i < array.Length - 1; i++)
            {
                for(int j = 0; j < (array.Length - i); j++) // Compare adjacent items
                {
                    if(array[j].CompareTo(array[j + 1]) > 0) // if array[j] > array[j + 1]
                    {
                        swap(j, j + 1, ref array);//Swap if bigger
                    }
                }
            }
        }

        private static void swap<T>(int index1, int index2, ref T[] array)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
