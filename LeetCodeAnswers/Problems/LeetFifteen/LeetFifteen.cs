namespace LeetCodeAnswers.Problems.LeetFifteen;

public class LeetFifteen
{
	public static void Run()
	{
		var nums = new int[] { -1, 0, 1, 2, -1, -4 };
		var ans = ThreeSum(nums);

        foreach (var a in ans)
		{
            Console.WriteLine($"[{a[0]}, {a[1]}, {a[2]}]");
		}
	}

	private static IList<IList<int>> ThreeSum(int[] nums)
	{
        IList<IList<int>> result = new List<IList<int>>();

        if (nums.Length <= 2) return result;

        Array.Sort(nums);

        int start = 0, left, right;
        int target;

        while (start < nums.Length - 2)
        {
            target = nums[start] * -1;
            left = start + 1;
            right = nums.Length - 1;

            while (left < right)
            {   
                if (nums[left] + nums[right] > target)
                {
                    --right;
                }
                else if (nums[left] + nums[right] < target)
                {
                    ++left;
                }
                else
                {
                    List<int> OneSolution = new List<int>() { nums[start], nums[left], nums[right] };
                    result.Add(OneSolution);

                    while (left < right && nums[left] == OneSolution[1])
                        ++left;
                    while (left < right && nums[right] == OneSolution[2])
                        --right;
                }

            }

            int currentStartNumber = nums[start];
            while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                ++start;
        }
        return result;
    }
}
