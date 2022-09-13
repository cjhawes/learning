using LeetCodeAnswers.Problems.LeetOne;

namespace LeetCodeAnswers.Constants;

public static class ImplementedProblems
{
	public static readonly Dictionary<int, Delegate> Problems = new Dictionary<int, Delegate>()
	{
		{1, new Action(LeetOne.Run)},
	};
}
