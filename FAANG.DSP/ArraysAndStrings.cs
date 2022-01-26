using System;
using System.Collections.Generic;
using System.Text;

/*
 * 
 * Title: ArraysAndStrings
 * 
 * 
 * This file contains the template for the Arrays adn Strings exercises in
 * the DS & Algos Primer. Fill in the exercises here and refer to
 * ArrayAndStringsSolutions.java for the complete code solution
 */

namespace FAANG.DSP
{
    public static class ArraysAndStrings
    {
     /*
         * Exercise 1.1: Write a function that takes an integer array and reverses
         * the values in place
         *
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public static void reverseArray(int[] arr)
        {
            // Accessing and modifying values
            //Note: When doing something like a reverse swapping maybe an idea
            //Note: The pivot point is important here
            for(int i = 0; i < arr.Length/2; i++)
            {
                int frontVal = arr[i];
                int backVal = arr[arr.Length - 1 - i];

                arr[arr.Length - 1 - i] = frontVal;
                arr[i] = backVal;
            }
        }


        /*
         * Exercise 1.2: Given a 2D matrix, write a function to print the values in
         * the matrix in a clockwise spiral from outside to inside
         *
         * Time Complexity: O(n^2)
         * Space Complexity: O(1)
         */
        public static void printSpiral(int[,] arr)
        {
            //We need to keep track of the boundaries of the current layer of
            //of the spiral tha we are traversing
            int minRow = 0;
            int minCol = 0;
            int maxRow = arr.GetLength(0)-1;
            int maxCol = arr.GetLength(1)-1;


            //Once the mins and maxes converage, we are at the center of teh spiral. The spiral follows 
            //a fixed set of steps. We go left, down, right, up. 
            //For each of these, we just interate to the bounds, so we express each one explicity
            while (minRow < maxRow && minCol < maxCol)
            {
                //Go across top
                Console.WriteLine("Go across top");
                for (int col = minCol; col <= maxCol; col++)
                {
                    Console.WriteLine($"{arr[minRow, col]}");
                }
                minRow++;

                Console.WriteLine("Go down right side");
                //Go down right side
                for (int row = minRow; row <= maxRow; row++)
                {
                    Console.WriteLine($"{arr[row, maxCol]}");
                    
                }
                maxCol--;


                Console.WriteLine("Go across the bottom");
                for (int col = maxCol; col >= 0; col--)
                {
                    Console.WriteLine($"{arr[maxRow, col]}");
                }
                maxRow--;

                Console.WriteLine("Go up left side");
                for (int row = maxRow; row > 0; row--)
                {
                    Console.WriteLine($"{arr[row, minCol]}");
                }
                minCol++;
            }
        }

        /*
         * Exercise 1.3: Given a 2D matrix, write a function to print the values in
         * the matrix in a zig-zag order
         *
         * Time Complexity: O(n^2)
         * Space Complexity: o(1)
         */
        public static void printDiagonals(int[,] arr)
        {
            int row = 0;
            int col = 0;
            int maxRow = arr.GetLength(0) - 1;
            int maxCol = arr.GetLength(1) - 1;


            // Like the spiral, we have clearly defined directions we need to go. In
            // this case we either go up to the right or down to the left. We define
            // each of these explicitly and just go back and forth between doing one
            // and the other
            while (true)
            {
                //Go up to the right
                while(row > 0 && col < maxCol)
                {
                    Console.WriteLine(arr[row, col]);
                    row--;
                    col++;
                }

                // Without this we won't print the final value in the diagnoal
                Console.WriteLine(arr[row, col]);


                //Check whether we're at the bottom right corner
                if (row == maxRow && col == maxCol)
                    break;
                // We need to update our position differently depending on whether
                // we're still going along the top of the matrix or the down rigt hand side
                else if (col + 1 < maxCol) 
                    col++;
                else 
                    row++;

                //Go down to the left
                while(row < maxRow && col > 0)
                {
                    Console.WriteLine(arr[row, col]);
                    row++;
                    col--;
                }

                // Without this we won't print the final value of the diagonal 
                Console.WriteLine(arr[row, col]);

                //Check whether we're at the bottom right corner
                //Check whether we're at the bottom right corner
                if (row == maxRow && col == maxCol)
                    break;
                // We need to update our position differently depending on whether
                // we're still going along the top of the matrix or the down rigt hand side
                else if (row + 1 < maxRow)
                    row++;
                else
                    col++;
            }
        }

        /*
        * Exercise 1.4: Write a function that takes in a string and removes every
        * even-indexed character
        *
        * Time Complexity: O(n)
        * Space Complexity: O(n)
        */
        public static string removeEven(string s)
        {
            string result = "";

            for(int i = 1; i < s.Length-1; i+=2)
            {
                  result += s[i];
            }

            Console.WriteLine(result);
            return result;
        }

        /*
        * Exercises 1.5: Zig Zag Conversion
        * Full Problem Definition: https://leetcode.com/problems/zigzag-conversion/
        *
        * Time Complexity: O(n)
        * Space Complexity: O(n)
        */
        public static string zigZag(string s, int numRows)
        {
            // We'll compute each row and then merge them all together at the end
            StringBuilder[] rows = new StringBuilder[numRows];
            for (int i = 0; i < rows.Length; i++) rows[i] = new StringBuilder();

            // We have 2 actions. Frist we iterate down over each row, then we
            // iterate back up. Do one then the other
            int idx = 0;
            while(idx < s.Length)
            {
                // Iterate from row 0 to numRows-1
                for (int i = 0; i < rows.Length && idx < s.Length; i++)
                {
                    rows[i].Append(s[idx++]);
                }

                // Iterate back up from numRows-2 to 1. Make sure we go from
                // numRows-2 to 1 and not numRows-1 to 0 because othewise we'll
                // add 2 characters to row 0 and 2 characters to row numRows-1
                Console.WriteLine($"{idx}");
                for (int i = rows.Length - 2; i >= 1 && idx < s.Length; i--)
                {
                    rows[i].Append(s[idx++]);

                }
            }

            // Combine all the strings together
            StringBuilder result = new StringBuilder();
            foreach(var row in rows) result.Append(row);

            return result.ToString();
        }
    
       /*
        * Exercise 2.1: Given a string, print out all of the substrings
        *
        * Time Complexity: O(N^3)
        * Space Complexity: O(1)
        */
        public static void printSubstrings(string s)
        {
            for(int i=1; i <= s.Length; i++)
            {
                for(int j=0; j <= s.Length - i; j++)
                {
                    int end = j + i - 1;
                    for(int k=j; k <= end; k++)
                    {
                        Console.Write(s[k]);
                    }
                    Console.WriteLine();
                }
            }
        }

        /*
        * Exercise 2.2: Write a function to find all duplicates in an array. The
        * array will contain exactly 1 duplicated value
        *
        * Time Complexity: O(arr.Length^2)
        * Space Complexity: O(1)
        */
        public static int findDuplicates(int[] arr)
        {
            for(int i =0; i < arr.Length; i++)
            {
                var curVal = arr[i];
                for(int j = 0; j < arr.Length; j++)
                {
                    if (curVal == arr[j] && i != j)
                        return arr[j];
                }
            }

           return -1;
        }

        /*
        * Exercise 2.3: Given a sorted array, find every pair of values in the
        * array that sum up to a given target
        *
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        */
        public static List<int[]> twoSum(int[] arr, int target)
        {
            List<int[]> result = new List<int[]>();

            //We start our pointers at the beginning and move towards the center
            int i = 0;
            int j = arr.Length - 1;


            while (i < j)
            {
                int sum = arr[i] + arr[j];

                //If we found the target, we add it to the result. Then we either
                // increment i or decrement j. It doesn't matter which we do
                if (sum == target)
                {
                    result.Add(new int[] { arr[i], arr[j] });

                    //We want to avoid including the same pair multiple times so we
                    //skip the pointer ahead to the next unique value. Since our array is sourted,
                    //we just keep incrementing until we see  new value
                    while (arr[i] == arr[i + 1]) i++;
                    i++;
                }

                // We can find a larger sum by incrementing i. This makes the 
                // smaller value in our pair larger so the sum is larger
                if (sum < target) i++;

                //If it's too big, we do opposite by decrementing j
                if (sum > target) j--;
            }

            return result;
        }

        /*
        * Exercise 3.1: Given two arrays, compare them to see if they are equal
        *
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        */
        public static bool arraysAreEqual(int[] arr1, int[] arr2)
        {
            // INSERT YOUR SOLUTION HERE

            //Check if array is null
            //Check if arrays are the same length
            //For every value in the first array find the matching value in the second.

            if (arr1 == null ||  arr2 == null)
                return false;

            if (arr1.Length != arr2.Length)
                return false;

            for(int i =0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        /*
            * Exercise 3.2: Given two strings, determine if one string is the reverse
            * of the other string
            *
            * Time Complexity: O(n)
            * Space Complexity: O(1)
            */
        public static bool stringsAreOpposite(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            for(int i =0; i < s1.Length; i++)
            {
                if (s1[i] != s1[s1.Length - 1 - i])
                    return false;
            }

            return true;
        }

        /*
        * Exercise 3.3: Given two strings, determine whether they are anagrams of
        * each other
        *
        * Time Complexity: O(n)
        * Space Complexity: O(n)
        */
        public static bool areAnagrams(String s1, String s2)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();


            if (s1.Length != s2.Length)
                return false;


            foreach(var c in s1)
            {
                int count = 1;
                hash.Add(c, count);
            }

            foreach(var c in s2)
            {
                var myValue = hash.GetValueOrDefault(c);
                if(myValue == null) return false;
            }


            return true;
        }

        /*
        * Exercise 4.1: Given an array, compute the sum of each length-k subarray
        *
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        */
        public static int[] subarraySums(int[] arr, int k)
        {
            // This size of our result will be arr.length - k + 1
            int[] results = new int[arr.Length - k + 1];

            //Compute the sum of the initial length-k subarray
            int sum = 0;
            for (int i = 0; i < k; i++) sum += arr[i];
            results[0] = sum;

            //Use a sliding window to go through the remainder of the array wihtout
            //recomputing the sume for every subarray
            int left = 0;
            int right = k - 1;
            while(right < arr.Length-1)
            {
                //The value at right+1 needs to be added to the sum and the value
                // at left needs be subtracted
                sum += arr[++right];
                sum -= arr[left++];
                results[left] = sum;
            }


            return results;
        }

        /*
        * Exercise 4.2: Given a string, find the longest substring of the string
        * that does not contain any repeated characters
        *
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        */
        public static int noRepeatedChars(string s)
        {
            HashSet<char> inSubstring = new HashSet<char>();

            int maxSubstring = 0;
            int left = 0;
            int right = 0;

            // We expand right out as much as we can without getting duplicates
            // chars. If we ened up with duplicates, we increment left to shrink the substring
            // substring no longer duplicates
            while(right < s.Length)
            {
                //We have a duplicate character, so increment left until the
                //substring no longer contains duplicates
                while(inSubstring.Contains(s[right]))
                {
                    inSubstring.Remove(s[left++]);
                }

                //We have a valid substring so is it the longest one?
                maxSubstring = Math.Max(maxSubstring, right - left + 1);

                inSubstring.Add(s[right++]);
            }

            return maxSubstring;
        }

        /*
        * Exercise 4.3: Given two strings, s and p, find all occurrences of
        * anagrams of p in s. The output is the starting index of each anagram
        *
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        */
        public static List<int> findAllAnagrams(string s, string p)
        {
            List<int> result = new List<int>();

            // Storing character counts. We can also use a HashMap like in the
            // solution for 3.3 but if we know that all of our characters are
            // English letters, this is easier for us to work with. 
            int[] chars = new int[256];
            foreach (char c in p) chars[c]++;
            //Do our slidig window
            int left = 0;
            int right = 0;

            while(right < s.Length)
            {
                //Add in the right character to our current window. We account for
                // this by removing it from character count we have for p
                char rightChar = s[right++];
                chars[rightChar]--;

                // If the value is negative, then we have too many of right char in 
                //our substring so we need to make it smaller until we no longer
                // have too many of that character
                while(chars[rightChar] < 0)
                {
                    chars[s[left]]++;
                    left++;
                }

                // If we have the exact right number of occurences of character
                // AND the substring is the right length, then this is valid substring.
                if (chars[rightChar] == 0 && right - left == p.Length) result.Add(left);
            }

            return result;
        }

        /*
        * Exercise 4.4: Given two strings, s and p, find the smallest substring of
        * s that contains all the characters in p
        *
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        */
        public static string smallestSubstring(string s, string p)
        {
            //Same as 4.3, we use an array to store character count
            int[] chars = new int[256];
            foreach(char c in p) chars[c]++;

            int left = 0;
            int right = 0;

            //In addition to tracking left and right, we'll track the start and
            //length of the string, as well as the count of characters from p that
            //we have in our substring includes all the characters in p or not
            int count = 0;
            int minLength = int.MaxValue;
            int minStart = 0;

            while(right < s.Length)
            {
                //This is basically opposite of 4.3 where we want all the values to
                // get to 0 or negative because we want the string to be inclusive
                // of all the character in p
                char rightChar = s[right++];
                chars[rightChar]--;

                if(chars[rightChar] >= 0)
                {
                    count++;
                }

                //If count == p.length we have valid substring. In this case
                // keep shrinking it as much as we can by incrementing left
                while(count == p.Length)
                {
                    if(right - left < minLength)
                    {
                        minLength = right - left;
                        minStart = left;
                    }

                    //If we have extra of a character, we don't decrement the count
                    //until we have fewer occurences of that char than there are in p
                    if (++chars[s[left]] > 0) count--;
                    left++;
                }
            }

            // If we don't fimnd a valid substring, return ""
            if (minLength > s.Length) return "";

            return s.Substring(minStart, minStart + minLength);
        }
    }
}
