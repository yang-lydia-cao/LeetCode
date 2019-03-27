/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        // egde cases
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        // always need dummy node
        var dummy = new ListNode(-1);
        var cur = dummy;
        // two pointers
        var cur1 = l1;
        var cur2 = l2;
        // while
        while(cur1 != null || cur2 != null)
        {
            if (cur1 != null && cur2 != null)
            {
                if (cur1.val < cur2.val)
                {
                    cur.next = cur1;
                    cur1 = cur1.next;
                }
                else if (cur1.val >= cur2.val)
                {
                    cur.next = cur2;
                    cur2 = cur2.next;
                }
            }
            else
            {
                if (cur1 != null)
                {
                    cur.next = cur1;
                    cur1 = cur1.next;
                }
                else if (cur2 != null)
                {
                    cur.next = cur2;
                    cur2 = cur2.next;
                }
            }
            cur = cur.next;
        }
        // dummy node operation
        var newHead = dummy.next;
        dummy.next = null;

        return newHead;  
    }
}