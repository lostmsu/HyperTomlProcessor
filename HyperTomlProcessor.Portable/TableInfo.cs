namespace HyperTomlProcessor
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public sealed class TableInfo
	{
		public readonly string[] Name;
		public readonly Comment Comment;
		public readonly bool IsArrayOfTable;

		public TableInfo(IEnumerable<IEnumerable<char>> name, Comment comment, bool isArrayOfTable)
		{
			this.Name = name.Select(x => String.Concat<char>(x)).ToArray();
			this.Comment = comment;
			this.IsArrayOfTable = isArrayOfTable;
		}
	}
}