using System;

namespace FAANG.Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //1. Daily Array Drills
            // Print Each Row of Array
            // Print Each Row of Array Backwards
            // Print Each Column of Array
            // Print Each Column of Array Backwards
            // Print Each Matching Corner of Arrays 
            //2. Daily For Loop Drills
            // Print all i values of array to 50
            // Print all event value of array to 50
            // Print all odd values of array to 50
            //3. Daily String Builders Drills


            //Daily Array Drills
            //One Dimensional Array
            int[] a = { 11, 2, 3, 10, 5, 6, 7, 8 };
            int[,] b = { { 1,  2,  3,  4  },
                         { 5,  6,  7,  8  },
                         { 9,  10, 11, 12}};

            string c = "testmyrideacces";


            //Building a sorting algorithm will continue tomorrow
            int idx = 0;
            int[] sortedArray = new int[a.Length];
            while (idx < a.Length - 1)
            {
                var curr = a[idx];
                var next = a[idx + 1];

                if (curr < next && Array.IndexOf(sortedArray, curr) == -1)
                {
                    sortedArray[idx] = curr;
                } 
                else if(curr > next && Array.IndexOf(sortedArray, curr) == -1)
                {
                    for (int i = idx; i < a.Length; i++)
                    {
                        if (a[i] < curr && Array.IndexOf(sortedArray, a[i]) == -1)
                            sortedArray[idx] = a[i];
                    }
                }

                idx++;
            }

            foreach(var v in sortedArray)
            {
                Console.WriteLine($"{v}");
            }
        }
    }
}
