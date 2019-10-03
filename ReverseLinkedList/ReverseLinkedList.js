/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */

// iteration version
var reverseList = function (head) {
    // initiall first node
    var prev = null;
    var curr = head;
    // iteration start
    while(curr != null){
        var nextNode = curr.next;
        curr.next = prev;
        prev = curr;
        curr = nextNode;
    }
    return prev;
}