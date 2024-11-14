using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{

    internal class Program
    {

        // ex1 
        // type input array 
        public static void InputArray(int size)
        {
            if (size == 0) return;

            int[] arrayInput = new int[size];
            int userInput;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("type number 1 to 100");

                userInput = Convert.ToInt32(Console.Read());

                if (userInput > 100 && userInput < 0)
                {
                    Console.WriteLine("try again");
                    userInput = Convert.ToInt32(Console.Read());
                }

                arrayInput[i] = userInput;
            }
        }

        // xuat mang
        public static void OutPutArray(int[] array)
        {
            if (array == null) return;

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        // ex2 
        public static double AvgAm(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;
            foreach (int value in array)
            {
                if (value < 0)
                {
                    sum += value;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }
        // ex3 
        public static double AvgDuong(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;
            foreach (int value in array)
            {
                if (value > 0)
                {
                    sum += value;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }
        // ex 4 

        public static bool CheckNT(int number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static double AvgNT(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;
            foreach (int value in array)
            {
                if (CheckNT(value))
                {
                    sum += value;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }

        // ex5 
        // check perfect number
        public static bool CheckPerfectNumber(int number)
        {
            if (number <= 1) return false;

            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }

        public static double AvgHH(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;
            foreach (int value in array)
            {
                if (CheckPerfectNumber(value))
                {
                    sum += value;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }

        // ex 6 
        // check so chinh phuong 
        public static bool CheckNumberCP(int number)
        {
            if (number < 0) return false;

            int sqrt = (int)Math.Sqrt(number);

            return sqrt * sqrt == number;
        }

        public static double AvgCP(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;
            foreach (int value in array)
            {
                if (CheckNumberCP(value))
                {
                    sum += value;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }

        // ex 7 
        public static double AvgChia3(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            double sum = 0;
            int count = 0;
            foreach (int value in array)
            {
                if (value % 3 == 0)
                {
                    sum += value;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }

        // ex 8  
        public static int FindMaxNumber(int[] array)
        {
            if (array == null)
                return 0;
            int maxNumber = array[0];

            foreach (int value in array)
            {
                if (value > maxNumber)
                    maxNumber = value;
            }

            return maxNumber;
        }

        // ex 9 

        public static int FindMiNmber(int[] array)
        {
            if (array == null)
                return 0;
            int maxNumber = array[0];

            foreach (int value in array)
            {
                if (value < maxNumber)
                    maxNumber = value;
            }

            return maxNumber;
        }

        // ex10 
        public static void SortNumberUP(ref int[] array)
        {
            if (array == null)
                return;

            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    int currentNumber = array[i];
                    if (currentNumber > array[j])
                    {
                        array[i] = array[j];
                        array[j] = currentNumber;
                    }
                }
            }
        }

        // ex 11

        public static void SortNumberDown(ref int[] array)
        {
            if (array == null)
                return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int currentNumber = array[i];
                    if (currentNumber < array[j])
                    {
                        array[i] = array[j];
                        array[j] = currentNumber;
                    }
                }
            }
        }

        // ex 12

        public static void PrintNumberNT(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("array not element");
                return;
            }

            foreach (int i in array)
            {
                if (CheckNT(i))
                {
                    Console.WriteLine(i);
                };
            }
        }

        // ex 13

        public static int PrintNTLT(int[] array, int k)
        {
            if (array == null)
                return 0;

            int count = 0;

            foreach (int i in array)
            {
                if (CheckNT(i) && i < k)
                {
                    count++;
                }
            }
            return count;
        }
        // ex 14

        public static void PrintCpK(int[] array)
        {
            if (array == null)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                if (CheckNT(array[i]) && i % 2 == 1)
                    Console.WriteLine(array[i]);
            }
        }

        // ex 15

        public static int FirstNumberPosition(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        // ex 16
        static int FindLastPosition(int[] a, int x)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        // ex 17
        public static int FindMaxAmPosition(int[] a)
        {
            int maxNe = int.MinValue;
            int maxPosition = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0 && a[i] > maxNe)
                {
                    maxNe = a[i];
                    maxPosition = i;
                }
            }

            return maxPosition;
        }

        // ex 18 

        public static int[] RemoveNT(int[] a)
        {
            List<int> result = new List<int>();

            foreach (int num in a)
            {
                if (!CheckNT(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        // ex 19 

        public static (int CountAm, int CountDuong) CountNegativeAndPositive(int[] a)
        {
            int CountAm = 0;
            int CountDuong = 0;

            foreach (int num in a)
            {
                if (num < 0)
                {
                    CountAm++;
                }
                else if (num > 0)
                {
                    CountDuong++;
                }
            }

            return (CountAm, CountDuong);
        }

        // 20 
        public static int CountOccurrences(int[] a, int x)
        {
            int count = 0;

            foreach (int num in a)
            {
                if (num == x)
                {
                    count++;
                }
            }

            return count;
        }

        // 21
        static void SortLeNumbers(int[] a)
        {

            var oddNumbers = a.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();

            int leIndex = 0;

            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    a[i] = oddNumbers[leIndex];
                    leIndex++;
                }
            }
        }

        // 22 

        public static void SortEvenNumbers(int[] a)
        {
            
            var evenNumbers = a.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();

            int evenIndex = 0;

            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    a[i] = evenNumbers[evenIndex];
                    evenIndex++;
                }
            }
        }

        // 23 
        public static int[] InsertAfterPosition(int[] a, int x, int k)
        {
            
            if (k < 0 || k >= a.Length)
            {
                Console.WriteLine("possition khong hop le");
                return a;  
            }

            
            int[] newArray = new int[a.Length + 1];

            
            for (int i = 0; i <= k; i++)
            {
                newArray[i] = a[i];
            }

            newArray[k + 1] = x;

            for (int i = k + 1; i < a.Length; i++)
            {
                newArray[i + 1] = a[i];
            }

            return newArray;  
        }

        // 24 

        public static int[] RemoveAllNumberKhop(int[] a, int x)
        {
            
            if (!a.Contains(x))
            {
                return null;  
            }

      
            var result = a.Where(num => num != x).ToArray();

            return result; 
        }

        // 25 
        public static int CountNumberDif(int[] a)
        {
            HashSet<int> uniqueElements = new HashSet<int>(a);

            return uniqueElements.Count;
        }

        // 26
        public static int[] InsertInSortedArray(int[] a, int X)
        {
            int[] newArray = new int[a.Length + 1];

            int i = 0;
            
            while (i < a.Length && a[i] < X)
            {
                newArray[i] = a[i];
                i++;
            }

            newArray[i] = X;

            while (i < a.Length)
            {
                newArray[i + 1] = a[i];
                i++;
            }

            return newArray;  
        }

        // 27

        public static int FindLargestEven(int[] a)
        {
            int largestEven = -1; 

            foreach (int num in a)
            {
                if (num % 2 == 0 && num > largestEven)
                {
                    largestEven = num;
                }
            }

            return largestEven;
        }

        public static int FindSmallestOddGreatThanEven(int[] a)
        {
            int largestEven = FindLargestEven(a);

            if (largestEven == -1)
            {
                return -1;
            }
            
            int minNumberOdd = a[0];
            foreach (int i in a)
            {
                if(minNumberOdd % 2 == 0 && minNumberOdd > largestEven)
                {
                    if (minNumberOdd > i)
                        minNumberOdd = i;
                } 
                    
                   
            }

            return minNumberOdd;
        }

        // 28 
        public static int FindLargestOdd(int[] a)
        {
            int largestOdd = -1;

            foreach (int num in a)
            {
                if (num % 2 == 1 && num > largestOdd)
                {
                    largestOdd = num;
                }
            }

            return largestOdd;
        }

        public static int FindMaxEveGreatThanOdd(int[] a)
        {
            int largestOdd = FindLargestOdd(a);

            if (largestOdd == 0)
            {
                return -1;
            }

            int maxNumberEven = a[0];
            foreach (int i in a)
            {
                if (maxNumberEven % 2 == 1 && maxNumberEven > largestOdd)
                {
                    maxNumberEven = i;
                    if (maxNumberEven > i)
                        maxNumberEven = i;
                }    
                    
            }

            return maxNumberEven;
        }

        // 29 
        public static int FindMostNumberXH(int[] a)
        {
            int n = a.Length;
            int mostFrequentElement = a[0];
            int maxCount = 1;

          
            for (int i = 0; i < n; i++)
            {
                int count = 1;  

                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])  
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentElement = a[i];
                }
            }

            return mostFrequentElement;
        }

        // 30 
        public static bool CheckArrayDX(int[] a)
        {
            int n = a.Length;

            
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[n - i - 1])  
                {
                    return false; 
                }
            }

            return true;  
        }

        // 31
        static bool IsArrayPrime(int[] a)
        {
            foreach (int num in a)
            {
                if (!CheckNT(num)) 
                {
                    return false;
                }
            }

            return true; 
        }

        // 32
        public static int FindSmallestPositive(int[] a)
        {
            int n = a.Length;
            int smallestPositive = int.MaxValue;  

            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0 && a[i] < smallestPositive)  
                {
                    smallestPositive = a[i];
                }
            }

            return smallestPositive == int.MaxValue ? 0 : smallestPositive;
        }

        // 33
        public static int FindLargestNegative(int[] a)
        {
            int n = a.Length;
            int largestNegative = int.MinValue;  
            
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0 && a[i] > largestNegative)  
                {
                    largestNegative = a[i];
                }
            }

            return largestNegative == int.MinValue ? 0 : largestNegative;
        }

        // 34 
        public static void TachPrimesChangeAToB(int[] a, ref int[] b)
        {
            List<int> primeList = new List<int>();

         
            foreach (int num in a)
            {
                if (CheckNT(num))
                {
                    primeList.Add(num); 
                }
            }

            b = primeList.ToArray();
        }

        // 35 
        public static void SplitArray(int[] a, out int[] b, out int[] c)
        {
            List<int> bList = new List<int>();
            List<int> cList = new List<int>();

            foreach (int num in a)
            {
                if (num > 0)  
                {
                    bList.Add(num);
                }
                else  
                {
                    cList.Add(num);
                }
            }

            b = bList.ToArray();
            c = cList.ToArray();
        }

        // 36 
        public static int [] SortArrayEvenToOddToZero( int[] a)
        {
            List<int> positive = new List<int>();  
            List<int> negative = new List<int>();  
            List<int> zeros = new List<int>();    

            
            foreach (int num in a)
            {
                if (num > 0)
                    positive.Add(num);
                else if (num < 0)
                    negative.Add(num);
                else
                    zeros.Add(num);
            }

            positive.Sort();
            negative.Sort();

            positive.AddRange(negative);
            positive.AddRange(zeros);

           
            positive.CopyTo(a);

            return positive.ToArray();
        }

        // 37 
        public static void EditPrimeToZero(ref int[] a)
        {
            if (a == null)
                return;
            for (int i = 0; i < a.Length; i++)
            {
                if (CheckNT(a[i]))
                {
                    a[i] = 0;
                }
            }
        }


        static void Main(string[] args)
        {
            
            int[] arr = { 1, -2, 3, 0, -5, 6, 7, 0, -3 };
            
            arr =  SortArrayEvenToOddToZero(arr);

            
            Console.WriteLine("after sort ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
