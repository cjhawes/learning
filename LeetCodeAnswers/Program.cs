using LeetCodeAnswers.Constants;

namespace LeetCodeAnswers;

public class Program
{
	public static void Main()
	{
		Delegate problemRunner;

		Console.Write("Enter L33tcod3 problem number to run: ");

		if (!int.TryParse(Console.ReadLine(), out int problemNumber))
		{
			Console.WriteLine("Error: Please enter whole integer between 1 and 2407.");
			return;
		}

		if (!ImplementedProblems.Problems.TryGetValue(problemNumber, out problemRunner!))
		{
			Console.WriteLine("Error: Please enter an implemented problem number.");
			return;
		}

		problemRunner.DynamicInvoke();
		Console.ReadLine();
	}
}