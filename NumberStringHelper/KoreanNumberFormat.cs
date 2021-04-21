using System;
using System.Collections.Generic;

namespace NumberStringHelper
{
	public static class KoreanNumberFormat
	{
		public static string ToKorTelWith(this string telString, string separator = "-")
		{
			if (string.IsNullOrEmpty(telString)) return string.Empty;
			if (telString.Length < 10 || telString.Length > 11) return string.Empty;

			int chunk2ndEndIndex = telString.Length == 10 ? 3 : 4;

			var chunks = new string[]
			{
				telString.Substring(0,3),
				telString.Substring(3, chunk2ndEndIndex),
				telString.Substring(chunk2ndEndIndex + 3, 4)
			};

			return $"{chunks[0]}{separator}{chunks[1]}{separator}{chunks[2]}";
		}
	}
}
