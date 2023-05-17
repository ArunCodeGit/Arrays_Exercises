using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using Unsorted_Arrays;

namespace Arrays
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            //Console.Write("Enter the array size: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the value minimum: ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the value Maximum: ");
            //int max = Convert.ToInt32(Console.ReadLine());
            int[] MyArray = new int[] { 73, 25, -17, 55, 73, 94, -23, 0, 89, 100,73, 39 };
            double[] FloatArray = new double[] { 73.2, 25.6, -17.1, 55.4, 73.2, 94.9, -23.1, 0, 89.4, 100.2, 73.0, 39.4 };
            //foreach (int item in Linear_search.RemoveAtXlocation(MyArray, 2))
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine(Linear_search.FindSmallest(MyArray));
            //Linear_search.FindCountOccurenceEachElement();

            //foreach (int item in ComparisonSwaps.Reverse_Array2())
            //{
            //    Console.Write(item + ", ");
            //}
            ComparisonSwaps.FindCountofGreaterthanX();


            //Pass by value and Pass by reference example
            //int x = 10;
            //Console.WriteLine(x);
            //PassByValue(x);
            //Console.WriteLine(x);

            //int[] ma = new int[5] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(ma[2]);
            //PassByRef(ma);
            //Console.WriteLine(ma[2]);

        }

        public static void PassByValue(int i)
        {
            Console.WriteLine("Inside: " + i);
            i = i + 5;
            Console.WriteLine("Inside: " + i);
        }
        public static void PassByRef(int[] a)
        {
            Console.WriteLine("Inside: " + a[2]);
            a[2] = 15;
            Console.WriteLine("Inside: " + a[2]);
        }

        #region 1. Get the number of elements in an array N and a Positive integer K, from the user as input and return an array of size N with all the elements initialized to K.
        public static int[] GetArrayElement(int N)
        {
            int K = 7;
            int[] MyArray = new int[N];
            int i = 0;
            while(i < N)
            {
                MyArray[i] = K;
                i++;
            }
            Console.WriteLine("Variable type name: "+MyArray.GetType());
            return MyArray;
        }
        #endregion

        #region 2. Get the number of elements in an array N, from the user as input, create an array of size N, get the values for the array elements from the user.
        public static int[] GetNoOfElement(int N)
        {          
            int[] MyArray = new int[N];
            int i = 0;
            while(i < N)
            {
                Console.WriteLine("Enter the array element index of {0}",i);
                int value = Convert.ToInt32(Console.ReadLine());
                MyArray[i] = value;
                i++;
            }
            return MyArray;
        }
        #endregion

        #region 3. Get the number of elements in an array N and the possible range (i,j) from the user as input and return an array of size N filled with random values between i and j.
        public static int[] RandomFill(int i, int j)
        {
            Random random= new Random();
            int[] MyArray = new int[random.Next(i,j)];
            int k = 0;
            while(k<MyArray.Length)
            {
                MyArray[k] = random.Next(i, j);
                k++;
            }
            return MyArray;

        }
        #endregion

        #region 4. Get the min (X) and max (Y) possible size of an array and the possible range (i,j) from the user as input and return an array of size N
        //where N is a random number between X and Y) and filled with random values between i and j.
        public static int[] RandomPossibleRange(int N, int i, int j)
        {
            Random random = new Random();
            int ArraySize = random.Next(i,j);
            int[] MyArray = new int[ArraySize];
            Console.WriteLine("Array Size: "+ArraySize);
            int k = 0;
            while(k<ArraySize)
            {
                MyArray[k] = random.Next(i, j);
                k++;
            }
            return MyArray;
        }
        #endregion

        #region 5. Given an unsorted array A of size N, print the elements of the array.
        public static int[] PrintArrayElement(int N)
        {
            int[] A = new int[N];
            int i = 0;
            while(i<N)
            {
                A[i] = i;
                i++;
            }
            return A;
        }
        #endregion

        #region 6. Given an unsorted array A of size N, print the elements of the array in reverse.
        public static int[] Reverse(int[] Arr)
        {
            int[] reverseArray = new int[Arr.Length];
            int i,j= 0;
            for (i = Arr.Length-1 ; i>=0;i--, j++)
            {
                reverseArray[j] += Arr[i];
            }
            
            return reverseArray;
        }
        #endregion

        #region 7. Given an unsorted array A of size N. You need to print only the elements of A in the odd or even locations(for this case, index 0 is even).  
        public static void PrintOddLocation(int[] MyArray)
        {
            int i = 0;
            while(i<MyArray.Length)
            {
                if(i%2!=0)
                {
                    Console.Write(MyArray[i] + ", ");
                }
                i++;
            }
        }

        public static void PrintEvenLocation(int[] MyArray)
        {
            int i = 0;
            while (i < MyArray.Length)
            {
                if (i % 2 == 0)
                {
                    Console.Write(MyArray[i] + ", ");
                }
                i++;
            }
        }
        #endregion

        #region 8. Given an unsorted array A of size N and an integer K, print the elements of the array up to K.
        public static void PrintUptoK(int[] MyArray, int K)
        {
            int i = 0;
            while(i<=MyArray.Length && i<K)
            {
                Console.Write(MyArray[i]+",");
                i++;
            }
        }
        #endregion

        #region 9. Given an unsorted array A of size N and integer K, print the elements starting from K to end of the array.
        public static void PrintfromK(int[] MyArray, int K)
        {
            int i = 0;
            while(i<=MyArray.Length-1)
            {
                if(i>=K)
                {
                    Console.Write(MyArray[i] + ", ");
                }
                i++;
            }
        }
        #endregion

        #region 10.Given an unsorted array A of size N and an integer K.  You need to print only the elements of A in the alternate locations starting from index K and ignore the elements before K.
        public static void AlternateLocation(int[] MyArray, int K)
        {
            int i = 0;
            while(i < MyArray.Length)
            {
                if (i >= K)
                {
                    Console.Write(MyArray[i]+", ");
                    i++;
                }
                i++;
            }
        }
        #endregion

        #region 11. Given an unsorted integer array A, print the contents of the array in the given format: arrayindex: value, arrayindex: value}. Note that there is no comma after the last value.
        public static string PrintArrayFormat(int[] MyArray)
        {
            string str = string.Empty;
            int i = 0;
            while(i<MyArray.Length)
            {
                str += i + " " + " :" + " " + MyArray[i]+", ";
                i++;
            }
            
            return str.Trim().TrimEnd(',');
        }
        #endregion

        #region 12. Given an unsorted integer Array A of size N and an integer K, print the contents of array with only K elements per line in a 2D fashion.
        public static void Print2Dfashion(int[] MyArray, int K)
        {
            int Count = 0;
            if(MyArray.Length%K==0)
            {
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.Write(MyArray[i] + " " + " ");
                    Count++;
                    if (Count % K == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to the matrix table, Give array length divisible by K value");
            }
            
        }
        #endregion

        #region 13. Given an unsorted array A of size N, subtract the element found in index 0 from all elemnents in the array.
        public static int[] SubtractElement(int[] MyArray)
        {
            int i = 0;
            int SubtractElement = MyArray[0];
            while (i<MyArray.Length)
            {
                MyArray[i] -= SubtractElement;
                i++;
            }
            return MyArray;
        }
        #endregion

        #region 14. Given an unsorted integer array A, find the sum of all the elements in A.
        public static int SumofAllElement(int[] MyArray)
        {
            int i = 0;
            int sum = 0;
            while(i<MyArray.Length)
            {
                sum += MyArray[i];
                i++;
            }
            return sum;
        }
        #endregion

        #region 15. Given an unsorted array of size N, return the sum of all the elements in the even positions.  Consider 0 to be even for this case.
        public static int SumofOddLocation(int[] MyArray)
        {
            int i = 0;
            int SumofOddLocation = 0;
            while (i <= MyArray.Length - 1)
            {
                if(i%2==0)
                {
                    SumofOddLocation += MyArray[i];
                }
                i++;
            }
            return SumofOddLocation;
        }

        public static int SumofEvenLocation(int[] MyArray)
        {
            int i = 0;
            int SumOfEvenLocation = 0;
            while (i <= MyArray.Length - 1)
            {
                if (i % 2 != 0)
                {
                    SumOfEvenLocation += MyArray[i];
                }
                i++;
            }
            return SumOfEvenLocation;
        }
        #endregion

        #region 16. Given an unsorted array of size N, find if the sum of all elements in the odd positions is equal to the sum of all the elements in the even positions. Consider 0 to be even for this case.
        public static bool IsSumOfOddandEvenEqual(int[] MyArray)
        {
            bool IsEqual = false;
            if(SumofEvenLocation(MyArray) == SumofOddLocation(MyArray))
            {
                IsEqual = true;
            }
            return IsEqual;
        }
        #endregion

        #region 17. Given an unsorted integer array A, find the mean.
        public static int FindMean(int[] MyArray)
        {
            return SumofAllElement(MyArray) / MyArray.Length;
        }
        #endregion

        #region 18. Given an unsorted integer array A, find the count of all non-zero elements in the array.
        public static int FindCountOfNonZero(int[] MyArray)
        {
            int i = 0;
            int count = 0;
            while(i<MyArray.Length)
            {
                if(MyArray[i] != 0)
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region Given an unsorted integer array A, find the count of all positive elements in the array.
        public static int FindCountOfAllPositiveElement(int[] MyArray)
        {
            int i = 0;
            int count = 0;
            while(i<MyArray.Length)
            {
                if (MyArray[i]>=0)
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region 19. Given an unsorted integer array A, find if the count of all positive elements in the array is equal to the count of all negative elements in the array. 0 is positive.
        public static bool FindCountOfPositiveAndNegativeEqual(int[] MyArray)
        {
            int i = 0;
            int PositiveCount = 0;
            int NegativeCount = 0;
            bool IsEqual = false;
            while(i<MyArray.Length)
            {
                if (MyArray[i]>=0)
                {
                    PositiveCount++;
                }
                else
                {
                    NegativeCount++;
                }
                i++;
            }
            if(PositiveCount==NegativeCount)
            {
                IsEqual = true;
            }
            return IsEqual;
        }

        #endregion

        #region Given an unsorted integer array A, find the count of all negative elements in the array.
        public static int FindCountOfNegativeElement(int[] MyArray)
        {
            int i = 0;
            int count = 0;
            while(i<MyArray.Length)
            {
                if (MyArray[i]<0)
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region 20. Given an unsorted integer array A, find the mean, ignoring the elements with a value of 0.
        public static double FindMeanIgnoreZero(double[] MyArray)
        {
            int i = 0;
            int count = 0;
            double sum = 0;
            while(i<MyArray.Length)
            {
                if (MyArray[i]!=0)
                {
                    sum += MyArray[i];
                    count++;
                }
                i++;
            }
            return sum / count;
        }
        #endregion

        #region 21. Given an unsorted array A of size N, subtract the mean of the array elements from all the elements in the array and print the values in the modified array.
        public static double[] SubtractMeanOfElement(double[] MyArray)
        {
            double MeanValue = FindMeanIgnoreZero(MyArray);
            int i = 0;
            while (i < MyArray.Length)
            {
                if (MyArray[i]!=0)
                {
                    MyArray[i]-= MeanValue;
                }
                i++;
            }
            return MyArray;
        }
        #endregion

        #region 22. Given an unsorted integer array as input, return the number of odd/even numbers in it.
        public static int FindOddCount(int[] MyArray)
        {
            int i = 0;
            int OddCount = 0;
            while(i<MyArray.Length)
            {
                if ((MyArray[i]%2)!=0) 
                {
                    OddCount++;
                }
                i++;
            }
            return OddCount;
        }

        public static int FindEvenCount(int[] MyArray)
        {
            int i = 0;
            int EvenCount = 0;
            while (i < MyArray.Length)
            {
                if ((MyArray[i] % 2) == 0)
                {
                    EvenCount++;
                }
                
                i++;
            }
            return EvenCount;
        }
        #endregion

        #region 23. Given an unsorted integer array as input, return the number of perfect squares in it.
        public static void ReturnNoOfPerfectSquare(int[] MyArray)
        {
            int i = 1;
            int count = 0;
            while(i<=MyArray.Length-1)
            {
                if (MyArray[i]!=0)
                {
                    if (IsPerfectSquare(MyArray[i]))
                    {
                        count++;
                    }
                }
                i++;
            }
            Console.WriteLine("{0} number perfect squares are there in the given array.",count);
        }
        #endregion

        #region Find the Is Perfect Square in the given value.
        public static bool IsPerfectSquare(double value)
        {
            bool IsSquare = false;
            int findroot =(int) Math.Sqrt(value);
            int findSquare = (int)Math.Pow(findroot, 2);
            if(value == findSquare)
            {
                IsSquare = true;
            }
            return IsSquare;
        }
        #endregion

        #region 24. Given an unsorted integer array as input, return the number of prime numbers in it.
        public static void ReturnNoOfPrime(int[] MyArray)
        {
            int count = 0;
            int i = 0;
            while (i < MyArray.Length)
            {
                if (MyArray[i]>0) 
                {
                    if (IsPrime(MyArray[i]))
                    {
                        count++;
                        Console.WriteLine(MyArray[i]);
                    }
                }
                i++;
            }
            Console.WriteLine("{0} number of prime number are there in the given array.",count);
        }
        #endregion

        #region Find Is Prime in the given value
        public static bool IsPrime(int value)
        {
            bool IsPrime = false;
            int count = 0;
            int i = 2;
            while(i<=value/2)
            {
                if(value%i==0)
                {
                    count++;
                    break;
                }
                i++;
            }
            if(count==0)
            {
                IsPrime = true;
            }
            else
            {
                IsPrime= false;
            }
            return IsPrime;
        }
        #endregion

        #region Find the Kth prime number
        public static void FindNthPrime(int value)
        {
            int Found = 0;
            int j = 1;
            while (value>=Found)
            {
                int i = 2;
                int count = 0;
                while(i<=j/2)
                {
                    if(j%i==0)
                    {
                        count++;
                        break;
                    }
                    i++;
                }
                if (count == 0)
                {
                    Console.WriteLine("{0}, {1}",j, Found);
                    j++;
                    Found++;
                }
                else
                {
                    j++;
                }
            }
            
        }
        #endregion

        #region 25. Write a function that takes an unsorted integer array as input and returns a copy of the array as output.
        public static int[] CopyArray(int[] MyArray)
        {
            int[] CopyArray = new int[MyArray.Length];
            int i = 0;
            while (i < MyArray.Length) 
            {
                CopyArray[i] = MyArray[i];
                i++;
            }
            return CopyArray;
        }
        #endregion

        #region 26. Given an unsorted integer array, return a new array with only the odd/even numbers from the input array.
        public static int[] OddNumberArray(int[] MyArray)
        {
            int k = 0;
            int j = 0;
            int Oddcount = FindOddCount(MyArray);
            int[] OddElement = new int[Oddcount];
            while (j < MyArray.Length)
            {
                if (MyArray[j]%2!=0)
                {
                    OddElement[k] = MyArray[j];
                    k++;
                }
                j++;
            }
            return OddElement;
        }

        public static int[] EvenNumberArray(int[] MyArray)
        {
            int k = 0;
            int j = 0;
            int EvenCount = FindEvenCount(MyArray);
            int[] EvenElement = new int[EvenCount];
            while (j < MyArray.Length)
            {
                if (MyArray[j] % 2 == 0)
                {
                    EvenElement[k] = MyArray[j];
                    k++;
                }
                j++;
            }
            return EvenElement;
        }
        #endregion

        #region 27.Given an unsorted integer array, return a new array containing only the perfect squares from the input array.
        public static int[] ReturnPerfectSquareArray(int[] MyArray)
        {
            int i = 0;
            int count = 0;
            while (i < MyArray.Length)
            {
                if (IsPerfectSquare(MyArray[i]) && MyArray[i] != 0)
                {
                    count++;
                }
                i++;
            }
            int[] PerfectArray = new int[count];
            int k = 0;
            int j = 0;
            while(j<MyArray.Length)
            {
                if (IsPerfectSquare(MyArray[j]) && MyArray[j] != 0)
                {
                    PerfectArray[k] = MyArray[j];
                    k++;
                }
                j++;
            }
            return PerfectArray;
        }
        #endregion

        #region 28. Given an unsorted integer array, return a new array containing only the prime numbers from the input array.
        public static int[] ReturnPrimeNumberArray(int[] MyArray)
        {
            int i = 0;
            int count = 0;
            while(i<MyArray.Length)
            {
                if (IsPrime(MyArray[i]) && MyArray[i]>0)
                {
                    count++;
                }
                i++;
            }
            int[] PrimeArray = new int[count];
            int k = 0;
            int j = 0;
            while(j<MyArray.Length)
            {
                if (IsPrime(MyArray[j]) && MyArray[j] > 0)
                {
                    PrimeArray[k] = MyArray[j];
                    k++;
                }
                j++;
            }
            return PrimeArray;
        }
        #endregion

        #region 29. Given an unsorted integer array A of size N and an integer K (N%K==0), return a new array that contains the sum of each subarray of size K
        public static int[] SumOfEachSubArray(int[] MyArray, int K)
        {
            int length = (MyArray.Length) - K+1;
            int k = 0;
            int Count = 0;
            int[] SumOfSubarray = new int[length];
            if (MyArray.Length%K==0)
            {
                for (int i = 0; i < MyArray.Length; i++)
                {
                    if(Count<=length-1)
                    {
                        Count++;
                        for (int j = 0; j < K; j++)
                        {
                            SumOfSubarray[k] += MyArray[i + j];
                        }
                        k++;
                    }
                    
                }
            }
            return SumOfSubarray;
        }
        #endregion

        #region 30. Given an unsorted integer array, return a Boolean array, containing true or false depending on whether the element in the location is even or not.
        public static bool[] FindEvenUseBool(int[] MyArray)
        {
            int i = 0;
            bool[] BoolArray= new bool[MyArray.Length];
            while(i<MyArray.Length)
            {
                if (MyArray[i]%2==0)
                {
                    BoolArray[i]=true;
                }
                else
                {
                    BoolArray[i]=false;
                }
                i++;
            }
            return BoolArray;
        }
        #endregion

        #region Given an unsorted integer array with N elements,  return a Boolean array, containing true or false depending on whether the element in the location is odd or not.
        public static bool[] FindOddUseBool(int[] MyArray)
        {
            int i = 0;
            bool[] ResultArray = new bool[MyArray.Length];
            while (i < MyArray.Length)
            {
                if (MyArray[i] % 2 != 0)
                {
                    ResultArray[i] = true;
                }
                else
                {
                    ResultArray[i] = false;
                }
                i++;
            }
            return ResultArray;
        }
        #endregion

        #region 34. Given a positive integer N(N<=100000), return a Boolean array of size N that contains true in those indices where the index value is a prime number and false otherwise.
        public static bool[] FindPrimeOfIndicesValue()
        {
            int max = 100000;
            int n = 50;
            bool[] ResultArray = new bool[n];
            if(n>0 && max>n)
            {
                int i = 2;
                while(n>i)
                {
                    if(IsPrime(i))
                    {
                        ResultArray[i] = true;
                    }
                    else
                    {
                        ResultArray[i] = false;
                    }
                    i++;
                }
            }
            return ResultArray;
        }
        #endregion

        #region 35. Given a positive integer N(N<=100000), return a Boolean array of size N that contains true in those indices where the index value is perfect square and false otherwise.
        public static bool[] FindPerfectSquareOfIndicesValue()
        {
            int n = 100;
            bool[] ResultArray = new bool[n];
            
            int i = 0;
            while(i<n)
            {
                if(IsPerfectSquare(i))
                {
                    ResultArray[i] = true;
                }
                else
                {
                    ResultArray[i] = false;
                }
                i++;
            }
            return ResultArray;
        }


        #endregion
    }
}