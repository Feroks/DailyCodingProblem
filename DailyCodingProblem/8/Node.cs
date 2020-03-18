using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DailyCodingProblem._8
{
	public class Node
	{
		[JsonConstructor]
		public Node()
		{
		}

		public Node(int value, Node[] nodes)
		{
			Value = value;
			Nodes = nodes;
		}

		public int Value { get; [UsedImplicitly] set; }

		public Node[] Nodes { get; [UsedImplicitly] set; }

		public void Deconstruct(out int value, out Node[] nodes)
		{
			value = Value;
			nodes = Nodes;
		}
	}
}