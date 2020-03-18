using System.Linq;

namespace DailyCodingProblem._8
{
	public class Problem8Linq : IProblem8
	{
		public int Run(Node node)
		{
			return RunInternal(node);
		}

		private static int RunInternal(Node node)
		{
			var (value, children) = node;

			var count = AllChildrenEqual(node, value)
				? 1
				: 0;
			
			return count + children.Sum(RunInternal);
		}

		private static bool AllChildrenEqual(Node node, int value)
		{
			var (nodeValue, children) = node;
			return nodeValue == value && children.All(x => AllChildrenEqual(x, nodeValue));
		}
	}
}