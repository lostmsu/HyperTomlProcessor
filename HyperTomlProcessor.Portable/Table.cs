namespace HyperTomlProcessor
{
	using System.Collections.Generic;

	public sealed class Table
	{
		public readonly TableInfo Info;
		public readonly IEnumerable<TableNode> Content;

		public Table(TableInfo info, IEnumerable<TableNode> content)
		{
			this.Info = info;
			this.Content = content;
		}
	}
}