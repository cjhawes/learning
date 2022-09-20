using LeetCodeAnswers.Constants;

namespace LeetCodeAnswers;

public class Program
{
	public static void Main()
	{
		Console.Write("Enter L33tcod3 problem number to run: ");

		if (!int.TryParse(Console.ReadLine(), out var problemNumber))
		{
			Console.WriteLine("Error: Please enter whole integer between 1 and 2407.");
			return;
		}

		if (!ImplementedProblems.Problems.TryGetValue(problemNumber, out var problemRunner))
		{
			Console.WriteLine("Error: Please enter an implemented problem number.");
			return;
		}

		problemRunner.DynamicInvoke();
	}
}