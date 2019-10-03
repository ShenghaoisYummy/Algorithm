/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList (ListNode head) {

        if (head == null || head.next == null) return head;
        ListNode next = head.next;
        next.next = head;
        head.next = null;
        ListNode p = ReverseList (next);
        return p;
    }

}