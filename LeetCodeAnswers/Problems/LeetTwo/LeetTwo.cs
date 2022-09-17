using LeetCodeAnswers.DataStructures;
using System.Numerics;

namespace LeetCodeAnswers.Problems.LeetTwo;

public class LeetTwo
{
	public static void Run()
	{
		var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
		var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

		var answer = AddTwoNumbers(l1, l2);

        Console.WriteLine("Problem Two : Add Two Numbers");
        answer.Print();
	}

	public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
        var l1str = "";
        var l2str = "";

        while (true)
        {
            l1str += l1.val.ToString();

            if (l1.next == null)
                break;

            l1 = l1.next;
        }

        while (true)
        {
            l2str += l2.val.ToString();

            if (l2.next == null)
                break;

            l2 = l2.next;
        }

        var l1rev = new string(Reverse(l1str));
        var l2rev = new string(Reverse(l2str));

        var solution = BigInteger.Parse(l1rev) + BigInteger.Parse(l2rev);
        var solStr = solution.ToString();
        var solCharArr = Reverse(solStr);

        return CreateLN(solCharArr);
    }

    private static char[] Reverse(string s)
    {
        char[] charArr = s.ToArray();
        Array.Reverse(charArr);
        return charArr;
    }

    private static ListNode CreateLN(char[] chars)
    {
        ListNode ln = null!;

        foreach (char c in chars)
        {
            ln = Insert(ln, int.Parse(c.ToString()));
        }
        return ln;
    }

    private static ListNode Insert(ListNode root, int val)
    {
        var temp = new ListNode();
        ListNode ptr;

        temp.val = val;
        temp.next = null!;

        if (root == null)
            root = temp;
        else
        {
            ptr = root;
            while (ptr.next != null)
                ptr = ptr.next;
            ptr.next = temp;
        }
        return root;
    }
}
