using System;

namespace LinkedList
{
    
    public class LinkList
    {
        public class ListNode
        {
            public int val;

            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }

        }

        public ListNode head;

        public void PushFront(int data)
        {
            if (head == null)
                CreateHead(data);
            else
            {
                ListNode node = new ListNode(data);
                node.next = head;
                head = node;
            }
        }

        private void CreateHead(int data)
        {
            head = new ListNode(data);
        }

        public void PushBetween(ListNode prevNode, int data)
        {
            if (prevNode == null)
                return;
            ListNode node = new ListNode(data);
            node.next = prevNode.next;
            prevNode.next = node;
        }

        public void PushAfter(int data)
        {
            if (head == null)
                CreateHead(data);
            else
            {
                ListNode node = new ListNode(data);
                node.next = null;
                ListNode tmp = head;
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }

                tmp.next = node;
            }
        }
    }
}
