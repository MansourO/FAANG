using System;

namespace FAANG.DSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 3, 4, 5 };
            int[] arr1 = new int[] { 1, 2, 2, 3, 4, 5 };
            
            int[,] arr2D = new int[3, 3] {{3, 5, 6}, 
                                          {12,15,2},
                                          {45,9,32}};


            //ArraysAndStrings.reverseArray(arr);
            //ArraysAndStrings.printSpiral(arr2D);
            //ArraysAndStrings.printDiagonals(arr2D);
            //ArraysAndStrings.removeEven("iloveinterviewprep");
            //ArraysAndStrings.zigZag("PAYPALISHIRING", 3);
            //ArraysAndStrings.printSubstrings("Osama");
            //Console.WriteLine(ArraysAndStrings.findDuplicates(arr));
            //foreach(var v in ArraysAndStrings.twoSum(arr, 6))
            //{
            //    foreach (var w in v)
            //    {
            //        Console.WriteLine(w);
            //    }
            //}
            //ArraysAndStrings.arraysAreEqual(arr, arr1);
            //Console.WriteLine(ArraysAndStrings.stringsAreOpposite("racecar", "racecar"));
            //Console.WriteLine(ArraysAndStrings.areAnagrams("cinema", "icemana"));
            //foreach(var v in ArraysAndStrings.subarraySums(new int[] { 1, 2, 3, 4, 5 }, 3))
            //{
            //    Console.WriteLine(v);
            //}
            //Console.WriteLine(ArraysAndStrings.noRepeatedChars("abcbabcd"));
            //foreach(var v in ArraysAndStrings.findAllAnagrams("cbaebabacd", "abc"))
            //{
            //    Console.WriteLine(v);
            //}
            //Console.WriteLine(ArraysAndStrings.smallestSubstring("aabbccdd", "abc"));

            SinglyLinkedList list = new SinglyLinkedList();
            list.insert(1);
            list.insert(2);

            Console.WriteLine(list.toString());

            list.delete(1);

            Console.WriteLine(list.toString());

            Console.WriteLine(list.size());


            //PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            foreach(var value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}
