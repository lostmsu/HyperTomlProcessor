namespace HyperTomlProcessor
{
	using System;
	using System.Collections.Generic;
	using Parseq;

	internal static class PortableParserWrappers
	{
		public static Parser<char, IEnumerable<char>> Select<T>(this Parser<char, T> parser, Func<T, string> selector)
		{
			return parser.Select(c => selector(c).ToCharArray());
		}

		public static Parser<char, IEnumerable<char>> Select(this Parser<char, IEnumerable<char>> parser,
			Func<IEnumerable<char>, string> selector)
		{
			return parser.Select(c => selector(c).ToCharArray());
		}
	}
}
