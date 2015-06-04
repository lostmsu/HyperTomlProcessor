namespace HyperTomlProcessor
{
	using System.Collections.Generic;
	using System.Linq;

	internal class TableTree
	{
		public readonly string[] FullName;
		public readonly IEnumerable<TomlParser.TableNode> Nodes;
		public readonly Dictionary<string, List<TableTree>> ArrayOfTables = new Dictionary<string, List<TableTree>>();
		public readonly Dictionary<string, TableTree> Children = new Dictionary<string, TableTree>();

		public TableTree(string[] fullName, IEnumerable<TomlParser.TableNode> nodes)
		{
			this.FullName = fullName;
			this.Nodes = nodes ?? Enumerable.Empty<TomlParser.TableNode>();
		}

#if !PORTABLE
		public XElement ToXElement(string name)
		{
			var xe = TomlParser.CreateTableElement(name, this.Nodes);
			foreach (var kvp in this.ArrayOfTables)
			{
				xe.Add(XUtils.CreateElement(kvp.Key,
					new XAttribute("type", "array"),
					new XAttribute("toml", TomlItemType.Array.ToString()),
					kvp.Value.Select(t => t.ToXElement("item"))
					));
			}
			xe.Add(this.Children.Select(kvp => kvp.Value.ToXElement(kvp.Key)));
			return xe;
		}
#endif
	}
}