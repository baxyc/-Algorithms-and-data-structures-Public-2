using System;

namespace LinkedListImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, null)));
            ListNode reversed = ListNode.ReverseList(head);
            while (reversed != null)
            {
                Console.Write(reversed.val + " ");
                reversed = reversed.next;
            }
        }
    }
}
