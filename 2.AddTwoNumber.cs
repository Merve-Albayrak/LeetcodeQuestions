using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_AddTwoNumbers
{
    internal class AddTwoNumbers
    {
         ListNode head = new ListNode(0);
            ListNode current = head;
            int carry = 0;
            int sum = 0;
            while (l1 != null || l2 != null || carry != 0)
            {





                sum =
                   (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;

                int val = sum;

                if (sum >= 10)
                {


                    int realVal = sum % 10;
                    val = realVal;
                    //   listNode=new ListNode(0);
                    current.next = new ListNode(val);
                }
                else
                {

                    current.next = new ListNode(val);
                }

                // current.next=new ListNode(val);
                current = current.next;
                carry = sum / 10;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;


            }

            return head.next;
    }
}
