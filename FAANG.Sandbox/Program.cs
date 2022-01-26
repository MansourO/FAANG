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
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[,] b = { { 1,  2,  3,  4  },
                         { 5,  6,  7,  8  },
                         { 9,  10, 11, 12}};


            for(int i = 0; i <= b.GetLength(0)-1; i++)
            {
                for(int j =0; j <= b.GetLength(1)-1; j++)
                {
                    if(b[i,j] % 2 != 0)
                      Console.WriteLine(b[i, j]);
                }
            }

            
        }
    }
}
