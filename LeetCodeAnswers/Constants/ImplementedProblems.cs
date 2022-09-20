using LeetCodeAnswers.Problems.LeetFifteen;
using LeetCodeAnswers.Problems.LeetFiftySix;
using LeetCodeAnswers.Problems.LeetOne;
using LeetCodeAnswers.Problems.LeetOneHundredAndTwo;
using LeetCodeAnswers.Problems.LeetSeventyTwo;
using LeetCodeAnswers.Problems.LeetThirtyFour;
using LeetCodeAnswers.Problems.LeetTwentyOne;
using LeetCodeAnswers.Problems.LeetTwo;
using LeetCodeAnswers.Problems.LeetTwoHundred;
using LeetCodeAnswers.Problems.LeetTwoHundredAndSix;

namespace LeetCodeAnswers.Constants;

public static class ImplementedProblems
{
	public static readonly Dictionary<int, Delegate> Problems = new Dictionary<int, Delegate>()
	{
		{ 1, new Action(LeetOne.Run) },
		{ 2, new Action(LeetTwo.Run) },
		{ 15, new Action(LeetFifteen.Run) },
		{ 21, new Action(LeetTwentyOne.Run) },
		{ 34, new Action(LeetThirtyFour.Run) },
		{ 56, new Action(LeetFiftySix.Run) },
		{ 72, new Action(LeetSeventyTwo.Run) },
		{ 102, new Action(LeetOneHundredAndTwo.Run) },
		{ 200, new Action(LeetTwoHundred.Run) },
		{ 206, new Action(LeetTwoHundredAndSix.Run) },
	};
}
