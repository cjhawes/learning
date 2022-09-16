namespace LeetCodeAnswers.Problems.LeetOne;

public static class LeetOne
{
	public static void Run()
	{
		int[] nums = { 2, 7, 11, 15 };
		int target = 9;

        var answer = TwoSum(nums, target);

		Console.WriteLine("Problem One : Two Sum");
        Console.WriteLine($"Answer = [{answer[0]}, {answer[1]}]");
	}

	private static int[] TwoSum(int[] nums, int target)
	{
        var numbers = nums.ToList();

        for (var i = 0; i < numbers.Count; i++)
        {
            for (var j = 0; j < numbers.Count; j++)
            {
                if (numbers[i] + numbers[j] == target && i != j)
                    return new int[] { i, j };
            }
        }
        return null!;
    }
}
