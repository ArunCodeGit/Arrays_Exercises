using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Unsorted_Arrays
{
    internal class ComparisonSwaps
    {
        #region 62. Given an unsorted array, swap two elements of the array given their indices
        public static int[]  SwapElementIndices()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            temp = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = temp;
            return Arr;
        }
        #endregion

        #region 63. Check to see if the given array contains elements in non-decreasing order (Ascending order)
        public static bool AscOrder()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9 };
            bool IsStatus = false;
            for(int i=0; i<Arr.Length-1;i++)
            {
                if (Arr[i] < Arr[i+1])
                {
                    IsStatus = true;
                }
                else
                {
                    IsStatus &= false;
                    break;
                }
            }
            return IsStatus;
        }
        #endregion

        #region 64. Write a function that takes two unsorted integer arrays as input and returns true if the two arrays are the same.
        public static bool IsTwoArraySame()
        {
            int[] Arr1 = new int[] { 1, 3, 5, 6, 3, 8, 9 };
            int[] Arr2= new int[] { 1, 3, 9, 7, 6, 8, 9 };
            bool IsStatus = false;
            if(Arr1.Length==Arr2.Length)
            {
                for (int i = 0; i < Arr1.Length; i++)
                {
                    if (Arr1[i] == Arr2[i])
                    {
                        IsStatus = true;
                    }
                    else
                    {
                        IsStatus = false;
                        break;
                    }
                }
            }
            else
            {
                IsStatus = false;
            }
            return IsStatus;
        }
        #endregion

        #region 65. Write a function that takes an unsorted integer array as input and returns an array with the values in reverse order.
        public static int[] Reverse_Array()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            int[] RevArray = new int[Arr.Length];
            int i = Arr.Length-1;
            int j = 0;
            while(i>=0)
            {
                RevArray[j] = Arr[i];
                i--;
                j++;
            }
            return RevArray;
        }
        #endregion

        #region 66. Write a function to reverse the elements of the given array, in place.
        public static int[] Reverse_Array2()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            
            int i = Arr.Length-1;
            int j = 0;
            while(i>=0 && i>j)
            {
                if (i!=j)
                {
                    int temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = temp;
                }
                else if(i==j)
                {
                    continue;
                }
                i--;
                j++;
            }
            return Arr;
        }
        #endregion

        #region 67. Write a function that takes two unsorted integer arrays as input and returns the index up-to, which they are identical, Return -1 otherwise.

        #endregion

        #region 68. Given an unsorted array A of size N, which contains duplicates, print only the distinct elements of the array.
        public static void PrintDistinctNumber()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            for(int i=0; i<Arr.Length;i++)
            {
                int j;
                for(j=0; j<i;j++)
                {
                    if (Arr[i] == Arr[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.WriteLine(Arr[i]);
                }
            }
        }
        #endregion

        #region 69. Write a function that takes an unsorted integer array as input and returns an array with the duplicates removed.
        public static void RemoveDuplicates()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            Array.Sort(Arr);
            for(int i=0;i<Arr.Length;i++)
            {
                if(i==0)
                {
                    Console.WriteLine(Arr[i]);
                }
                else if (Arr[i-1] != Arr[i])
                {
                    Console.WriteLine(Arr[i]);
                }
            }
        }
        #endregion

        #region 70. Given an unsorted integer array as input, find the Kth largest/smallest element.
        public static void FindKthLargest()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            Array.Sort(Arr);
            Array.Reverse(Arr);
            Console.Write("Enter the value of Kth Position to find result: ");
            int K = int.Parse(Console.ReadLine());
            for (int i = Arr.Length; i > 0; i--)
            {
                if (i - 1 == K)
                {
                    Console.WriteLine("Find the {0}th largest number is {1} in the given array", K, Arr[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public static void FindKthSmallest()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            Array.Sort(Arr);
            Console.Write("Enter the value of Kth Position to find result: ");
            int K = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Arr.Length; i++)
            {
                if (i - 1 == K)
                {
                    Console.WriteLine("Find the {0}th smallest number is {1} in the given array", K, Arr[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #endregion

        #region 71. Given an unsorted integer array and an integer value X as input, return the count of the values less than or equal to X.
        public static void FindCountofLessthanX()
        {
            int[] Arr = new int[] { 101, 353, 5363, 6632, 3642, 8331, 9633, 413536, 51235, 76342, 946424, 146421, 135360, 346474, 63546, 74231 };
            Array.Sort(Arr);
            Console.Write("Enter the value of X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int count = 0;
            while(i<Arr.Length && Arr[i-1] <= X )
            {
                count++;
                i++;
            }
            Console.WriteLine(count);
        }
        #endregion

        #region 72. Given an unsorted integer array and an integer value X as input, return the count of the values greater than or equal to X.
        public static void FindCountofGreaterthanX()
        {
            int[] Arr = new int[] { 101, 353, 5363, 6632, 3642, 8331, 9633, 413536, 51235, 76342, 946424, 146421, 135360, 346474, 63546, 74231 };
            Array.Sort(Arr);
            Console.Write("Enter the value of X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            int i = Arr.Length;
            int count = 0;
            while (i > 0 && Arr[i-1] >= X)
            {
                count++;
                i--;
            }
            Console.WriteLine(count);
        }
        #endregion
    }
}
