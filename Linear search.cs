using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unsorted_Arrays
{
    public class Linear_search
    {
        #region 36. Given an unsorted integer array A and a target value X, find if A contains the value X.
        public static bool FindXinA(int[] MyArray, int value)
        {
            bool IsFound = false;
            int i = 0;
            while(i<MyArray.Length)
            {
                if (MyArray[i]==value)
                {
                    IsFound = true;
                }
                i++;
            }
            return IsFound;
        }
        #endregion

        #region 37. Given an unsorted integer array A and a target value X, return the index at which X is located in A or return -1 if it is not found in A.
        public static int FindXLocinA(int[] MyArray, int value)
        {
            int i = 0;
            int index = -1;
            while(i<MyArray.Length)
            {
                if (MyArray[i]==value)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        #endregion

        #region 38. Given an unsorted integer array A and a target value X, find if X is found more than in A.
        public static bool FindXinAtime(int[] MyArray, int value)
        {
            int i = 0;
            int count = 0;
            bool IsFound = false;
            while(i<MyArray.Length)
            {
                if (MyArray[i]==value)
                {
                    count++;
                }
                i++;
                if(count>1)
                {
                    IsFound = true;
                }
            }
            return IsFound;
        }
        #endregion

        #region 39. Given an unsorted integer array and a target value X, return the location of the second occurence of the target value in the array and -1 if there no second occurence of target.
        public static int Find2ndOccurLocation(int[] MyArray, int value)
        {
            int i = 0;
            int index = -1;
            int count = 0;
            int flag = 2;
            while(i<MyArray.Length && count<2)
            {
                if (MyArray[i]==value)
                {
                    count++;
                    if(flag==count)
                    {
                        index = i;
                        break;
                    }
                }
                i++;
            }
            return index;
        }
        #endregion

        #region 40. Given an unsorted integer array A and a target value X, return the location of the Kth occurence of the target value in the array and -1 if there is no Kth occurence of target.
        public static int FindKthOccurLocation(int[] MyArray, int value, int K)
        {
            int i = 0;
            int count = 0;
            int index = -1;
            while(i<MyArray.Length)
            {
                if (MyArray[i]==value)
                {
                    count++;
                    if(count==K)
                    {
                        index = i;
                        break;
                    }
                }
                i++;
            }
            return index;
        }
        #endregion

        #region 41. Given an unsorted integer array A and an integer value X, return the number of times X is found in A.
        public static int FindXtimesA(int[] MyArray, int X)
        {
            int i = 0;
            int count = 0;
            while (i < MyArray.Length)
            {
                if (MyArray[i] == X)
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region 42. Given an unsorted integer array A and an integer value X, return the indices of the locations where X is found in A.
        public static int[] ReturnIndicesLocX(int[] MyArray, int X)
        {
            int i = 0;
            int count = 0;
            while (i<MyArray.Length)
            {
                if (MyArray[i]==X)
                {
                    count++;
                }
                i++;
            }
            int[] Arr = new int[count];
            int j = 0;
            int k = 0;
            if(count!=0)
            {
                while (j < MyArray.Length)   //{ 73, 25, -23, 55, 73, 94, -17, 0, 89, 100,73 }
                {
                    if (MyArray[j] == X)
                    {
                        Arr[k] = j;
                        k++;
                    }
                    j++;
                }
            }
            else
            {
                Console.WriteLine("Provided X number is not available in the given array...");
            }
            
            return Arr;
        }
        #endregion

        #region 43. Given an unsorted integer array A of size N and an integer K, 
        //find and remove the occurrences of K from the given array and return a new array of appropriate length after removal of K.
        //Return the same input array, if K is not found.
        public static int[] RemoveOccurenceOfK(int[] MyArray, int K)
        {
            int i = 0;
            int count = 0;
            while (i<MyArray.Length)
            {
                if (MyArray[i]!=K)
                {
                    count++;
                }
                i++;
            }
            int[] NewArr = new int[count];
            int j = 0;
            int k = 0;
            while(j<MyArray.Length)
            {
                if (MyArray[j]!=K)
                {
                    NewArr[k] = MyArray[j];
                    k++;
                }
                j++;
            }
            return NewArr;
        }

        #endregion

        #region 44. Given an unsorted array A of size N, an integer K and a location X, 
        //insert K at the location X of A and return the new array of size N+1.  Other array elements should not be removed or replaced.
        public static int[] InsertKatXLocation(int[] MyArray, int K, int X)
        {
            int[] newArray = new int[MyArray.Length + 1];
            for(int i = 0; i<MyArray.Length+1;i++)
            {
                if(i<X)
                {
                    newArray[i] = MyArray[i];                    
                }
                else if(X==i)
                {
                    newArray[i] = K;
                }
                else
                {
                    newArray[i] = MyArray[(int)i-1];
                }
            }
            return newArray;
        }

        #endregion

        #region 45. Given an unsorted array A of size N and a location X, remove the element at location X and return a new array of size N-1.
        //Other array elements should not be removed or replaced.
        public static int[] RemoveAtXlocation(int[] MyArray, int X)
        {
            int[] newArray = new int[MyArray.Length - 1];
            for(int i = 0; i< MyArray.Length;i++)
            {
                if(i<X)
                {
                    newArray[i] = MyArray[i];
                    //newArray[i].Equals(MyArray[i]);
                }
                else if(i>X)
                {
                    newArray[i-1] = MyArray[(int)i];
                    //MyArray[i].Equals(MyArray[i] - 1);
                }
            }
            return newArray;
        }
        #endregion

        #region 46. Given an unsorted integer array A, find the smallest number.
        public static int FindSmallest(int[] MyArray)
        {
            int Smallest = int.MaxValue;
            int i = 0;
            int count = 0;
            while(i<MyArray.Length)
            {
                if (MyArray[i] < Smallest)
                {
                    Smallest = MyArray[i];
                    count++;
                }
                i++;
            }
            return Smallest;
        }
        #endregion

        #region 47. Given an unsorted integer array A, print the number of comparisons, made to find the smallest element in the array.
        public static int FindSmallestNoOfComparisons(int[] MyArray)
        {
            int Smallest = int.MaxValue;
            int i = 0;
            int count = 0;
            while(i<MyArray.Length)
            {
                if(Smallest> MyArray[i])
                {
                    Smallest = MyArray[i];
                    count++;
                }
                i++;
            }
            //Console.WriteLine("{0} number of comparison made.", count);
            return count;
        }
        #endregion

        #region 48. Given an unsorted integer array A, find the index of the smallest element in the array.
        public static int FindIndexOfSmallestElement(int[] MyArray)
        {
            int Smallest = int.MaxValue;
            int i = 0;
            int index = 0;
            while (i < MyArray.Length)
            {
                if (Smallest > MyArray[i])
                {
                    Smallest = MyArray[i];
                    index = i;
                }
                i++;
            }
            //Console.WriteLine("Found smallest element at the {0}", index);
            return index;
        }
        #endregion

        #region 49. Given an unsorted integer array A, find the largest number.
        public static int FindLargest(int[] MyArray)
        {
            int Largest = int.MinValue;
            int i = 0;
            while (i < MyArray.Length)
            {
                if (MyArray[i] > Largest)
                {
                    Largest = MyArray[i];
                }
                i++;
            }
            return Largest;
        }
        #endregion

        #region 50. Given an unsorted integer array A, find the second largest number.
        public static int FindSecondLargest(int[] MyArray)
        {
            int i = 0;
            int largest = int.MinValue;
            int second = int.MinValue;
            while(i<MyArray.Length)
            {
                if (MyArray[i] > largest)
                {
                    second = largest;
                    largest = MyArray[i];
                }
                else if (second < MyArray[i])
                {
                    second = MyArray[i];
                }
                i++;
            }
            return second;
        }
        #endregion

        #region 51. Given an unsorted integer array A, find the largest and second largest number in the array.
        public static void FindLargestAndSecondLargest(int[] MyArray)
        {
            Console.WriteLine("Largest number is: {0} and Second largest number is {1}", FindLargest(MyArray), FindSecondLargest(MyArray));
        }
        #endregion

        #region 52. Given an unsorted integer array A, find the maximum Pairwise Product which returns the maximum product that can be 
        //obtained by multiplying two integers in the array.
        #endregion

        #region 53. Given an unsorted integer array A, find the number of times the smallest number is found in the array.
        public static int FindSmallestNoOccurrenceCount(int[] MyArray)
        {
            int Smallest = int.MaxValue;
            int i = 0;
            int count = 0;
            while (i < MyArray.Length)
            {
                if (MyArray[i] < Smallest)
                {
                    Smallest = MyArray[i];
                    count++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region 54. Given an unsorted integer array A, find the number of times the largest number is found in the array.
        public static int FindLargestNoOccurrenceCount(int[] MyArray)
        {
            int Largest = int.MinValue;
            int i = 0;
            int count = 0;
            while (i < MyArray.Length)
            {
                if (Largest < MyArray[i])
                {
                    Largest = MyArray[i];
                    count++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region 55. Given an unsorted array of size N-1 such that it can only contain distinct integers in the range of 1 to N.  Find the missing element.
        public static int FindMissingElement()
        {
            int[] Arr = new int[] { 1, 3, 4, 2 };
            int length = Arr.Length;
            int[] temp = new int[length+1];
            for(int i=0; i<length;i++)
            {
                temp[Arr[i] - 1] = 1;
            }
            int ans = 0;
            for(int j=0; j<=length;j++)
            {
                if (temp[j]==0)
                {
                    ans = j+1;
                    break;
                }
            }
            //Console.WriteLine(ans);
            return ans;
        }
        #endregion

        #region 56. Given an unsorted integer array, return the count of the elements with values that falls within a given range.
        public static int FindCountofMissingElement()
        {
            int[] Arr = new int[] { 1,5,4,3,6,9};
            int minValue = Arr.Min();
            int maxValue = Arr.Max();
            int length = maxValue - minValue;
            int[] temp = new int[length+1];
            for(int i=0; i<Arr.Length;i++)
            {
                temp[Arr[i] - 1] = 1;
            }
            int count = 0;
            for(int j=0; j<=length;j++)
            {
                if (temp[j]==0)
                {
                    count++;
                }
            }
            //Console.WriteLine(count);
            return count;
        }
        #endregion

        #region 57. Given an unsorted integer array A containing elements from 0-9, find the number of unique elements.
        public static int FindUniqueNumber()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9,4,5,7,9,1,0,3,6,7  };
            int[] temp = new int[10];
            for(int i=0; i<Arr.Length;i++)
            {
                temp[Arr[i]] += 1;
            }
            int UniqueCount = 0;
            for(int j=0; j<temp.Length;j++)
            {
                if (temp[j]==1)
                {
                    UniqueCount++;
                }
            }
            return UniqueCount;
        }
        #endregion

        #region 58. Given an unsorted integer array A containing elements from 0-9, find the element that occurs the most
        public static int MostOccurence()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 6, 7 };
            int[] temp = new int[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                temp[Arr[i]] += 1;
            }
            int MostOccurCount = int.MinValue;
            int MostOccurElement = 0;
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] > MostOccurCount)
                {
                    MostOccurElement = j;
                    MostOccurCount = temp[j];
                }
            }
                return MostOccurElement;
        }
        #endregion

        #region 59. Given an unsorted integer array A containing elements from 0-9, find the element that occurs the least. (ignore the missing element)
        public static int LeastOccurence()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 4, 7,0 };
            int[] temp = new int[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                temp[Arr[i]] += 1;
            }
            int LeastOccurCount = int.MaxValue;
            int LeastOccurElement = 0;
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] <= LeastOccurCount && temp[j]!=0)
                {
                    LeastOccurElement = j;
                    LeastOccurCount = temp[j];
                }
            }
            return LeastOccurElement;
        }
        #endregion

        #region 60. Given an unsorted integer array A containing elements from 0-9, find the missing elements.
        public static int FindMissing()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 4, 7, 0 };
            int[] temp = new int[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                temp[Arr[i]] += 1;
            }
            //int LeastOccurCount = int.MaxValue;
            int MissingElement = 0;
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] == 0)
                {
                    MissingElement = j;
                }
            }
            return MissingElement;
        }
        #endregion

        #region 61. Given an unsorted integer array A containing elements from 0-9, find the count of occurrence of each of the elements.
        public static void FindCountOccurenceEachElement()
        {
            int[] Arr = new int[] { 1, 3, 5, 6, 3, 8, 9, 4, 5, 7, 9, 1, 0, 3, 4, 7, 0 };
            int[] temp = new int[10];
            for(int i=0; i<10;i++)
            {
                for(int j=0;j<Arr.Length;j++)
                {
                    if (i == Arr[j])
                    {
                        temp[i] += 1;
                    }
                }
            }
            for (int k=0; k<temp.Length;k++)
            {
                Console.WriteLine(k+" = "+ temp[k]);
            }
        }
        #endregion
    }
}