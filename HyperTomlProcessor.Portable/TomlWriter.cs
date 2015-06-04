namespace HyperTomlProcessor
{
	public sealed class TomlWriter
	{
		internal TomlWriter(TomlVersion version)
		{
			this.Version = version;
		}

		public TomlVersion Version { get; private set; }
	}
}
