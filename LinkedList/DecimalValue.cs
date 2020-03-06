﻿//Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1.
//The linked list holds the binary representation of a number.
//Return the decimal value of the number in the linked list.

using System;

namespace LinkedList
{
    class DecimalValue
    {
        public static int GetDecimalValue(ListNode head)
        {
            ListNode temp = head;
            int number = 0;
            int count = 0;
            if (head.next == null)
                return head.val;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            while (count >= 0)
            {
                if (head.val == 1)
                {
                    number += Convert.ToInt32(Math.Pow(2,count));
                }
                head = head.next;
                count--;
            }
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetDecimalValue());
            Console.ReadKey();
        }
    }
}
