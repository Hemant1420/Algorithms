using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Methods
    {
        public void Permutations(String str)           // String permutation
        {
            List<char> chars = new List<char>();
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                chars.Add(str[i]);
            }

            foreach (char c1 in chars)
            {
                foreach (char c2 in chars)
                {
                    if (c1 == c2)
                    {
                        continue;
                    }
                    else
                    {
                        foreach (char c3 in chars)
                        {
                            if (c3 == c1 || c3 == c2)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"{c1},{c2},{c3}");
                                count = count + 1;

                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);


        }

        public void Bubble<T>(List<T> list1) where T : IComparable          //Method to perfrom Bubble Sorting (String)
        {
            T temp;
           for (int i = 0; i < list1.Count; i++)
           {
                for (int j = i; j < list1.Count; j++)
                {
                    if (list1[i].CompareTo(list1[j]) > 0)
                    {
                        temp = list1[i];
                        list1[i] = list1[j];
                        list1[j] = temp;

                    }

                }



           }
            foreach (T list in list1)
            {
                Console.WriteLine(list + " ");
            }
        }


        public void Bubblesort(List<int> list1)             //method to Perform Bubble sort (Integer)
        {
            int temp;
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = i; j < list1.Count; j++)
                {
                    if (list1[i] > list1[j])
                    {

                        temp = list1[i];
                        list1[j] = list1[i];
                        list1[i] = temp;
                    }
                }
            }
            foreach (int list in list1)
            {
                Console.WriteLine(list + " ");
            }

        }

        public void Anagrams(string str1, string str2)          //Check if two strings are Anagrams
        {
            Dictionary<char, int> newDict1 = new Dictionary<char, int>();
            int length1 = str1.Length;
            for (int i = 0; i < str1.Length; i++)
            {
                if (newDict1.ContainsKey(str1[i]))
                {
                    newDict1[str1[i]] = newDict1[str1[i]] + 1;
                }
                else
                {
                    newDict1[str1[i]] = 1;
                }
            }

            Dictionary<char, int> newDict2 = new Dictionary<char, int>();
            int length2 = str1.Length;


            for (int i = 0; i < str1.Length; i++)
            {
                if (newDict2.ContainsKey(str1[i]))
                {
                    newDict2[str1[i]] = newDict2[str1[i]] + 1;
                }
                else
                {
                    newDict2[str1[i]] = 1;
                }
            }

            if (length1 == length2 && newDict1 == newDict2)
            {
                Console.WriteLine($"{str1} and {str2} are Anagrams.");
            }
            else
            {
                Console.WriteLine($"{str1} and {str2} are not Anagrams.");
            }
        }


        public void Primeno()           //Prime Number in range of 1000
        {
            int i = 0;


            while (i < 1001)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {


                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine($"{i} ");
                }
                i++;



            }



        }

        public int Reverse(int n)
        {
            int sum = 0;
            while(n != 0) 
            {
                int num = n % 10;
                sum = (sum * 10) + num;
                n = n / 10;
            }
            return sum;


        }
        public void PrimeAnagram()                          //Palindrome and Anagram in Prime numbers Between 1 to 1000
        {
            int i = 0;
           List<int> newList = new List<int>();

            while (i < 1001)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {


                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    newList.Add(i);

                }
                i++;
            }

            for(int k =0  ; k < newList.Count ; k++)
            {
                for(int z=k+1;  z < newList.Count; z++)
                {
                   if( newList[k] == Reverse(newList[z]))
                    {
                        Console.WriteLine($"{newList[k]} and {newList[z]} are Palindrome and Anagrams");
                    }
                   

                    
                }
            }
        }
  


        public void Insertion<T>(T[] arr) where T : IComparable             //Insertion sort (String and integer)

        {
          for(int i = 1; i < arr.Length; i++)
          {
                T key = arr[i];
                int j = i - 1;

                while(j>=0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
          }

          for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            

        }


        public int[] Merge(int[] arr, int lb, int mb, int ub)
        {  
          int leftArrlength = 
            

        }


        public int[] MergeSort(int[] arr, int lb, int ub)
        {
            if (lb < ub)
            {
                int middleBound = (lb + ub) / 2;
                MergeSort(arr, lb, middleBound);
                MergeSort(arr, middleBound + 1, ub);
                Merge(arr, lb, middleBound, ub);
            }
            return arr;
           
          
            
            
        }

        public void Print(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }



        

    }




}
