namespace HyperTomlProcessor
{
	using System;
	using System.Collections.Generic;

	public sealed class KeyValue : TableNode
	{
		public readonly string Key;
		public readonly TomlValue Value;
		public readonly Comment Comment;

		public KeyValue(IEnumerable<char> key, TomlValue value, Comment comment)
		{
			this.Key = String.Concat(key);
			this.Value = value;
			this.Comment = comment;
		}
	}
}