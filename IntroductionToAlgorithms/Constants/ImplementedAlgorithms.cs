using IntroductionToAlgorithms.Algorithms;

namespace IntroductionToAlgorithms.Constants;

public class ImplementedAlgorithms
{
	public static readonly Dictionary<string, Delegate> Algorithms = new Dictionary<string, Delegate>()
	{
		{ "DepthFirstSearch", new Action(DepthFirstSearch.Run) },
	};
}