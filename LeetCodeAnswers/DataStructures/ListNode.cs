namespace LeetCodeAnswers.DataStructures;

public class ListNode
{
	public int val;
	public ListNode next;

	public ListNode(int val = 0, ListNode next = null!)
	{
		this.val = val;
		this.next = next;
	}

	public void Print()
	{
		var node = this;
		Console.Write($"{node.val} ");

		do
		{
			node = node.next;
			Console.Write($"{node.val} ");
		} 
		while (node.next != null);
	}
}
