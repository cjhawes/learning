using LeetCodeAnswers.Problems.LeetOne;
using LeetCodeAnswers.Problems.LeetTwo;

namespace LeetCodeAnswers.Constants;

public static class ImplementedProblems
{
	public static readonly Dictionary<int, Delegate> Problems = new Dictionary<int, Delegate>()
	{
		{ 1, new Action(LeetOne.Run) },
		{ 2, new Action(LeetTwo.Run) },
	};
}
