using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Maintest
    {
        static void Main()
        {
            List<string> list1 = new List<string> {"Pomogrante" , "Guava", "Banana", "Apple",  "Orange" };
            List<int> list2 = new List<int> { 2, 4, 3, 1, 5 ,7,0,8,6};

            string[] arr1 = { "Pomogrante", "Guava", "Banana", "Apple", "Orange" };
            int[] arr2 = { 5, 3, 6, 2, 1 };
            Methods newOp = new Methods();
            /*  newOp.Bubble(list1);
            newOp.Primeno();
            newOp.PrimeAnagram();
           Console.WriteLine(newOp.Reverse(123));*/
            //newOp.Bubble(list2);
            //newOp.Bubble(list2);
            //newOp.Insertion(arr2);
            //newOp.Insertion(arr1);
            //newOp.Permutations("abcd");
            arr2 = newOp.MergeSort(arr2, 0, arr2.Length-1);
            newOp.Print(arr2);

        }


    }
}
