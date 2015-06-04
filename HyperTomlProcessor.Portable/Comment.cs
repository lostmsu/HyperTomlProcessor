namespace HyperTomlProcessor
{
	using System;
	using System.Collections.Generic;

	public sealed class Comment : TableNode
	{
		public readonly string Text;

		public Comment(IEnumerable<char> text)
		{
			this.Text = String.Concat(text);
		}
	}
}