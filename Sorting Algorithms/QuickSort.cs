using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index = System.Int32;


namespace Sorting_Algorithms
{
    /// <summary>
    /// Recursively sort the array by selecting a value (pivot).
    /// All items lower than the pivot are placed to the left and vice versa.
    /// This is done for each sub array created from this process.
    /// </summary>
    class QuickSort
    {
        
        public static void Sort<T>(T[] arr) where T : IComparable<T>//Public exposed method
        {
            sort(arr, 0, arr.Length - 1);
        }
        private static void sort<T>(T[] arr,Index lowIndex, Index highIndex) where T : IComparable<T>
        {

            if(lowIndex < highIndex)
                //i.e when size > 1
            {
                Index pivot = partition(arr, lowIndex, highIndex);//get position of pivot
                sort(arr, lowIndex, pivot - 1); //recursively sort left side
                sort(arr, pivot + 1, highIndex);//recursively sort right side
            }

        }
        private static Index partition<T>(T[] arr, Index lowIndex, Index highIndex) where T : IComparable<T>
        {
            T pivot = arr[highIndex];//value to compare against
            Index partitionIndex = lowIndex;//value being compared
            for(Index i = lowIndex; i < highIndex; i++)
            {
                if(arr[i].CompareTo(pivot) < 1)
                {
                    swap(i, partitionIndex, ref arr);
                    partitionIndex++;
                }
            }
            swap(partitionIndex, highIndex, ref arr);

            return partitionIndex;
        }
        private static void swap<T>(int index1, int index2, ref T[] array)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
