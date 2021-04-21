using System;
using System.Collections.Generic;

namespace NumberStringHelper
{
	public static class KoreanNumberFormat
	{
		public static string ToKorMobileWith(this string mobileString, string separator = "-")
		{
			if (string.IsNullOrEmpty(mobileString)) return string.Empty;
			if (mobileString.Length < 10 || mobileString.Length > 11) return string.Empty;

			int chunk1stLength = 3;
			int chunk2ndLength = mobileString.Length == 10 ? 3 : 4;

			var chunks = new string[]
			{
				mobileString.Substring(0,chunk1stLength),
				mobileString.Substring(chunk1stLength, chunk2ndLength),
				mobileString.Substring(chunk1stLength + chunk2ndLength, 4)
			};

			return $"{chunks[0]}{separator}{chunks[1]}{separator}{chunks[2]}";
		}
	}
}
