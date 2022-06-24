using System.Collections.Generic;

namespace com.littlebigfun.addressable_importer.Editor
{
	public static class Extensions
	{
		/// <summary>
		/// Check if the string starts with a string. Implementation is slightly faster.
		/// </summary>
		/// <param name="text">text to check</param>
		/// <param name="match">text to match</param>
		/// <returns>true if the string starts with this text</returns>
		public static bool StartsWithFast(this string text, string match)
		{
			int matchLength = match.Length;
			int textLength = text.Length;

			if (textLength < matchLength)
				return false;

			for (int i = 0; i < matchLength; i++)
			{
				if (text[i] != match[i])
					return false;
			}

			return true;
		}

		/// <summary>
		/// Check if the string ends with a string. Implementation is slightly faster.
		/// </summary>
		/// <param name="text">text to check</param>
		/// <param name="match">text to match</param>
		/// <returns>true if the string ends with this text</returns>
		public static bool EndsWithFast(this string text, string match)
		{
			int matchLength = match.Length;
			int textLength = text.Length;

			if (textLength < matchLength)
				return false;

			int offset = textLength - matchLength;

			for (int i = 0; i < matchLength; i++)
			{
				if (text[i + offset] != match[i])
					return false;
			}

			return true;
		}

		/// <summary>
		/// Null checks before getting the count.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <returns>The count if the list exists, 0 if the list is null.</returns>
		public static int SafeCount<T>(this IList<T> list)
		{
			if (list == null)
				return 0;

			return list.Count;
		}
	}
}
