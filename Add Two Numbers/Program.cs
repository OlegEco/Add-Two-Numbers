ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

Solution sol = new Solution();
var result = sol.AddTwoNumbers(l1, l2);

Console.WriteLine("Result: ");
while (result != null)
{
    Console.Write(result.val);
    if (result.next != null) Console.Write(" -> ");
    result = result.next;
}


