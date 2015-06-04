namespace HyperTomlProcessor
{
	using System.Collections.Generic;
	using System.Linq;

	public sealed class ArrayItem
	{
		public readonly TomlValue Value;
		public readonly IEnumerable<Comment> Before;
		public readonly IEnumerable<Comment> After;

		public ArrayItem(TomlValue value, IEnumerable<Comment> before, IEnumerable<Comment> after)
		{
			this.Value = value;
			this.Before = before ?? Enumerable.Empty<Comment>();
			this.After = after ?? Enumerable.Empty<Comment>();
		}
	}
}