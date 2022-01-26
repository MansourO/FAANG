using System;
using System.Collections.Generic;
using System.Text;

namespace FAANG.DSP
{
    public class SinglyLinkedList
    {
      
        // A simple node class
        public class SinglyLinkedListNode
        {
            public int Value { get; set; }
            public SinglyLinkedListNode Next { get; set; }
        }


        public static SinglyLinkedListNode _head = null;
        public int _length = 0;

  
        /*
         * Insert new node at the head of the list
         *
         * Time Complexity: O(1)
         * Space Complexity: O(1)
         */
        public void insert(int n)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode();
            newNode.Value = n;

            newNode.Next = _head;
            _head = newNode;

            this._length++;
        }

        /*
         * Delete the first occurrence of n from the list
         *
         * Time Complexity: O(N)
         * Space Complexity: O(1)
         */
        public bool delete(int n)
        {
            SinglyLinkedListNode curr = _head;
            SinglyLinkedListNode prev = null;

            while(curr != null)
            {
                if (curr.Value == n)
                {
                   
                    if (prev == null)
                    {
                        _head = curr.Next;
                    }
                    else
                    {
                        prev.Next = curr.Next;

                        this._length--;
                        return true;
                    }
                }

                prev = curr;
                curr = curr.Next;
            }

            return false;
        }

        /*
         * Return the number of items in the list
         *
         * Time Complexity:
         * Space Complexity:
         */
        public int size()
        {
            return this._length;
            // INSERT YOUR CODE HERE
        }

        /*
         * Convert the list to a string
         *
         * Time Complexity:
         * Space Complexity:
         */
        public string toString()
        {
            var curr = _head;
            string s = "";

            while(curr != null)
            {
                s += $"{curr.Value},";
                curr = curr.Next;
            }

            return s;
        }
    }

    // Exercise 1.2: Implement a doubly-linked list

    // Doubly linked list class
    public class DoublyLinkedList
    {

        // A simple node class
        public class DoublyLinkedListNode
        {
            // INSERT YOUR CODE HERE
        }

        /*
         * Constructor
         *
         * Time Complexity:
         * Space Complexity:
         */
        public DoublyLinkedList()
        {
            // INSERT YOUR CODE HERE
        }

        /*
         * Insert node at the front of the list
         *
         * Time Complexity:
         * Space Complexity:
         */
        public void insert(int n)
        {
            // INSERT YOUR CODE HERE
        }

        /*
         * Delete the first occurrence of n from the list
         *
         * Time Complexity:
         * Space Complexity:
         */
        public bool delete(int n)
        {
            // INSERT YOUR CODE HERE
            return false;
        }

        /*
         * Return the number of items in the list
         *
         * Time Complexity:
         * Space Complexity:
         */
        public int size()
        {
            // INSERT YOUR CODE HERE
            return 1;
        }

        /*
         * Convert the list to a string
         *
         * Time Complexity:
         * Space Complexity:
         */
        public string toString()
        {
            // INSERT YOUR CODE HERE
            return null;
        }
    }
}
