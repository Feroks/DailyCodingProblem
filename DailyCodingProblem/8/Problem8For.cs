namespace DailyCodingProblem._8
{
	public class Problem8For : IProblem8
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
			
			foreach (var t in children)
			{
				count += RunInternal(t);
			}

			return count;
		}

		private static bool AllChildrenEqual(Node node, int value)
		{
			var (nodeValue, children) = node;

			if (nodeValue != value)
				return false;

			for (var i = 0; i < children.Length; i++)
			{
				if (!AllChildrenEqual(children[i], nodeValue))
					return false;
			}

			return true;
		}
	}
}