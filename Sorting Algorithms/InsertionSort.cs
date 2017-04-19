using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    /// <summary>
    /// Insert the items from the unsorted array into their correct position.
    /// <para/>
    /// The left of the array becomes the sorted side (initially of the first elements)
    /// <para/>
    /// The elements are then inserted in the correct position in the sorted list
    /// </summary>
    class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                T currValue = array[i]; //The value being compared
                var valPointer = i; //The index of the value being compared
                while (valPointer > 0 && array[valPointer - 1].CompareTo(currValue) > 0)
                    //Shift elements to the right until the correct position is found
                    //i.e when array[valPointer + 1] > array[valPointer]
                {
                    array[valPointer] = array[valPointer - 1]; //Shift elements to the right
                    valPointer--;
                }
                array[valPointer] = currValue;
            }

        }
     
    }
}
