using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
        }
    }

    public class LinkedList
    {
        /**
          * 
          * Base Case
          * ------------------------------
          * 
          * -------------------------------
          * Steps:
          * -----
          * 
          * Big'O
          * -----
          *
          * **/
        private Node head;
        private Node tail;
        int length;

        public LinkedList(int value)
        {
            Node newNode = new Node(1);
            head = newNode;
            tail = newNode;
            length = 1;
        }

        //1. Print LinkedList
        public void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }

        }
        //2
        #region getHead
        public void getHead()
        {
            Console.WriteLine(head.value);
        }
        #endregion getHead

        //3.
        #region getTail
        public void getTail()
        {
            Console.WriteLine(tail.value);
        }
        #endregion getTail
        //4.
        #region getLength
        public void getLength()
        {
            Console.WriteLine(length);
        }
        #endregion getLength

        //5.Append
        #region Append
        /**
         * Append a item to the LinkedList
         * Base Case
         * ------------------------------
         * 1. if List is Empty 
         * 2. One or More items in a List
         * -------------------------------
         * Steps:
         * -----
         * Create a new New Node
         * Update the tail.next pointer to newNode
         * Asssign tail =newNode (if emptylist, update head pointer as well)
         * Increase the Length
         * 
         * Big'O
         * -----
         * O(1) - Adding an item at the end is taking Constant time
         * **/

        public void append(int value)
        {
            Node newNode = new Node(value);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            length++;
        }
        #endregion append

        //6.RemoveLastNode
        #region RemoveLastNode
        /**
         * To Remove the last item, Identify the previous Node to the tail pointer
         * Base Case
         * ------------------------------
         * 1. if List is Empty
         * 2. if One item in a List
         * 3. Two or More item in a list
         * ------------------------------
         * 
         * Steps:
         * ------
         * 1. Identify the previous node to tail pointer
         * 2. Update tail pointer to previous
         * 3. Update tail.next =null
         * 4. decrease the length
         * -------------------------
         * Big'O
         * -----
         * O(n) - Identifying the previous node takes n time complexity & updating tails taking constant time, 
         *        droping the constant will give O(n)
         *        * 
         * **/

        public Node removeLast()
        {
            if (length == 0) return null;
            Node temp = head;
            Node previous = head;
            while (temp.next != null)
            {
                previous = temp;
                temp = temp.next;
            }

            tail = previous;
            tail.next = null;
            length--;

            if (length == 0)
            {
                head = null;
                tail = null;
            }

            return temp;
        }

        #endregion RemoveLastNode

        //7.Prepend
        #region Prepend
        /**
         * 
         * Base Case
         * ------------------------------
         * 1. if List is Empty
         * 2. if One or more item in a List
         * -------------------------------
         * Steps:
         * -----
         * 1. Create a newNode
         * 2. Update newNode.next = head;
         * 3. update head to newNode
         * 4. Increase the Length
         * Big'O
         * -----
         * O(1) - its a constant time
         * **/

        public void prepend(int value)
        {
            Node newNode = new Node(value);
            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            length++;
        }
        #endregion Prepend

        //7.RemoveFirstNode
        #region RemoveFirstNode
        /**
          * 
          * Base Case
          * ------------------------------
          * 1. if List is Empty
          * 2. One item in a List
          * 3. Two or More item in a List
          * -------------------------------
          * Steps:
          * -----
          * 1.Move head pointer to head.next
          * 2.Decrease the Length
          * 3.Update the tail =null if list becomes empty
          * Big'O
          * -----
          * O(1) - Its taking constant time to remove first item from the list
          * **/

        public Node removeFirstNode()
        {
            if (length == 0) return null;

            Node temp = head;
            head = head.next;
            temp.next = null;
            length--;

            if(length == 0)
            {
                tail = null;
            }
            return temp;

        }
        #endregion RemoveFirstNode
    }

    public class LinkedListDemo
    {
        LinkedList linkedList;

        public LinkedListDemo()
        {
            linkedList = new LinkedList(1);

            linkedList.PrintList();
        }


    }
}
