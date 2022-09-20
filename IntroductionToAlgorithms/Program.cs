using IntroductionToAlgorithms.Constants;

namespace IntroductionToAlgorithms;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter ItA Algorithm to run: ");

		var algoName = Console.ReadLine();

		if (algoName == null)
		{
			Console.WriteLine("Please enter an algorithm name.");
			return;
		}

		if (!ImplementedAlgorithms.Algorithms.TryGetValue(algoName, out var algo))
		{
			Console.WriteLine();
			return;
		}

		algo.DynamicInvoke();
	}
}