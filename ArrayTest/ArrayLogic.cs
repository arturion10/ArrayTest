using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    public class ArrayLogic
    {
        public int[,] SortedStringArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        for (int k = 1; k < arr.GetLength(1); k++)
                        {
                            if(arr[i, j] < arr[i, k])
                            {
                                (arr[i, j], arr[i, k]) = (arr[i, k], arr[i, j]);
                            }                            
                        }
                }
                else
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        for (int k = 1; k < arr.GetLength(1); k++)
                        {
                            if (arr[i, j] > arr[i, k])
                            {
                                (arr[i, j], arr[i, k]) = (arr[i, k], arr[i, j]);
                            }
                        }
                }
            }
            return arr;
        }
        public int[] QuickSortArray(int[] array, int minIndex, int maxIndex)
        {
            if(minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSortArray(array, minIndex, pivotIndex -1);

            QuickSortArray(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if(array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }
        public void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
    }
}
