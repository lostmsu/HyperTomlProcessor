namespace HyperTomlProcessor
{
	public sealed class TomlValue
	{
		public readonly TomlItemType Type;
		public readonly object Value;

		public TomlValue(TomlItemType type, object value)
		{
			this.Type = type;
			this.Value = value;
		}
	}
}