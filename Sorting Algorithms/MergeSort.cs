using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    ///<summary>
    ///Split the array into n sublists recursively.
    ///The sublists are then combined and sorted.
    ///</summary>
    class MergeSort
    {
        
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr.Length < 2)//Escape for recursion
                                //When sublist length = 1(so must be sorted)
            {
                return;
            }
            int midpoint = arr.Length / 2;
            //Create two arrays, one with left hand side of array, the other with the right hand side
            T[] left = new T[midpoint];
            T[] right = new T[arr.Length - midpoint];
            for (int i = 0; i <= midpoint - 1; i++)
            {
                left[i] = arr[i];
            }
            for (int i = midpoint; i < arr.Length; i++)
            {
                //i = midpoint originally,
                //so code will run from 0 to length - 1 - midpoint
                right[i - midpoint] = arr[i];
            }
            //Recursively sort both sides
            Sort(left);
            Sort(right);
            //Merge the arrays into parent array
            merge(left, right, arr);

        }

        private static void merge<T>(T[] leftArray, T[] rightArray, T[] outArray) where T : IComparable<T>
        {
            int i = 0, j = 0, k = 0;
            while(i < leftArray.Length && j < rightArray.Length)
                //Choose the smallest element in each sublist and add them to the new array
                //Iterate through each array
            {
                if (leftArray[i].CompareTo(rightArray[j]) < 1)
                {
                    outArray[k] = leftArray[i];
                    i++;
                }
                else
                {
                    outArray[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            //Only one of following whiles will execute
            //Since previous loop exits when i < la.length
            //or j < ra.length
            while (i < leftArray.Length)
            {
                outArray[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightArray.Length)
            {
                outArray[k] = rightArray[j];
                j++;
                k++;
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
