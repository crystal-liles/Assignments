using System;
using System.Collections.Generic;
using System.Text;

namespace CommonFramework.Core
{
    /// <summary>
    /// Various extension methods for string manipulation.
    /// </summary>
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }

        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }

        public static string Left(this string content, int numCharacters)
        {
            if (content == null) return null;
            if (content.Length < numCharacters) return content;

            return content.Substring(
                startIndex: 0,
                length: numCharacters);
        }

        public static string Right(this string content, int numCharacters)
        {
            if (content == null) return null;
            if (content.Length < numCharacters) return content;

            return content.Substring(
                startIndex: content.Length - numCharacters,
                length: numCharacters);
        }
    }
}
