using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MuOnline.Infrastructure.Core.Extensions
{
    public static class StringExtensions
    {
        public static string EnsureEndsWith(this string stringValue, char character)
        {
            return EnsureEndsWith(stringValue, character, StringComparison.Ordinal);
        }

        public static string EnsureEndsWith(this string stringValue, char character, StringComparison comparisonType)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue.EndsWith(character.ToString(), comparisonType))
            {
                return stringValue;
            }

            return stringValue + character;
        }

        public static string EnsureStartsWith(this string stringValue, char character)
        {
            return EnsureStartsWith(stringValue, character, StringComparison.InvariantCulture);
        }

        public static string EnsureStartsWith(this string stringValue, char character, StringComparison comparisonType)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue.StartsWith(character.ToString(CultureInfo.InvariantCulture), comparisonType))
            {
                return stringValue;
            }

            return character + stringValue;
        }

        public static string EnsureStartsWith(this string stringValue, char character, bool ignoreCase, CultureInfo culture)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue.StartsWith(character.ToString(culture), ignoreCase, culture))
            {
                return stringValue;
            }

            return character + stringValue;
        }

        public static bool IsNullOrEmpty(this string stringValue)
        {
            return string.IsNullOrEmpty(stringValue);
        }

        public static bool IsNullOrWhiteSpace(this string stringValue)
        {
            return string.IsNullOrWhiteSpace(stringValue);
        }

        public static string Left(this string stringValue, int len)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue.Length < len)
            {
                throw new ArgumentException("len argument can not be bigger than given string's length!");
            }

            return stringValue.Substring(0, len);
        }

        public static string NormalizeLineEndings(this string stringValue)
        {
            return stringValue.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", Environment.NewLine);
        }

        public static string RemovePostFix(this string str, params string[] postFixes)
        {
            if (str.IsNullOrEmpty())
            {
                return null;
            }

            if (postFixes.IsNullOrEmpty())
            {
                return str;
            }

            foreach (var postFix in postFixes)
            {
                if (str.EndsWith(postFix))
                {
                    return str.Left(str.Length - postFix.Length);
                }
            }

            return str;
        }

        public static string RemovePreFix(this string str, params string[] preFixes)
        {
            if (str.IsNullOrEmpty())
            {
                return null;
            }

            if (preFixes.IsNullOrEmpty())
            {
                return str;
            }

            foreach (var preFix in preFixes)
            {
                if (str.StartsWith(preFix))
                {
                    return str.Right(str.Length - preFix.Length);
                }
            }

            return str;
        }

        public static string Right(this string stringValue, int len)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue.Length < len)
            {
                throw new ArgumentException("len argument can not be bigger than given string's length!");
            }

            return stringValue.Substring(stringValue.Length - len, len);
        }

        public static string[] Split(this string stringValue, string separator)
        {
            return stringValue.Split(new[] { separator }, StringSplitOptions.None);
        }

        public static string[] Split(this string stringValue, string separator, StringSplitOptions options)
        {
            return stringValue.Split(new[] { separator }, options);
        }

        public static string[] SplitToLines(this string stringValue)
        {
            return stringValue.Split(Environment.NewLine);
        }

        public static string[] SplitToLines(this string stringValue, StringSplitOptions options)
        {
            return stringValue.Split(Environment.NewLine, options);
        }

        public static string ToCamelCase(this string str)
        {
            return str.ToCamelCase(CultureInfo.InvariantCulture);
        }

        public static string ToCamelCase(this string str, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            if (str.Length == 1)
            {
                return str.ToLower(culture);
            }

            return char.ToLower(str[0], culture) + str.Substring(1);
        }

        public static string ToSentenceCase(this string stringValue)
        {
            return stringValue.ToSentenceCase(CultureInfo.InvariantCulture);
        }

        public static string ToSentenceCase(this string stringValue, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return stringValue;
            }

            return Regex.Replace(stringValue, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToLower(m.Value[1], culture));
        }

        public static T ToEnum<T>(this string value)
            where T : struct
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return (T)Enum.Parse(typeof(T), value);
        }

        public static T ToEnum<T>(this string value, bool ignoreCase)
            where T : struct
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }

        public static string ToMd5(this string str)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(str);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                foreach (var hashByte in hashBytes)
                {
                    sb.Append(hashByte.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public static string ToPascalCase(this string str)
        {
            return str.ToPascalCase(CultureInfo.InvariantCulture);
        }

        public static string ToPascalCase(this string str, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            if (str.Length == 1)
            {
                return str.ToUpper(culture);
            }

            return char.ToUpper(str[0], culture) + str.Substring(1);
        }

        public static string Truncate(this string stringValue, int maxLength)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue.Length <= maxLength)
            {
                return stringValue;
            }

            return stringValue.Left(maxLength);
        }

        public static string TruncateWithPostfix(this string stringValue, int maxLength)
        {
            return TruncateWithPostfix(stringValue, maxLength, "...");
        }

        public static string TruncateWithPostfix(this string stringValue, int maxLength, string postfix)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }

            if (stringValue == string.Empty || maxLength == 0)
            {
                return string.Empty;
            }

            if (stringValue.Length <= maxLength)
            {
                return stringValue;
            }

            if (maxLength <= postfix.Length)
            {
                return postfix.Left(maxLength);
            }

            return stringValue.Left(maxLength - postfix.Length) + postfix;
        }

        public static bool IsEmptyString(this object value)
        {
            return value is string s && string.IsNullOrEmpty(s);
        }

        public static string GetHash(this string input)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                foreach (var @byte in hashBytes)
                    sb.Append(@byte.ToString("X2"));

                return sb.ToString();
            }
        }

        /// <summary>
        /// Converts a date to Unix epoch.
        /// </summary>
        /// <param name="date">The date to convert</param>
        /// <returns>Date converted to seconds since Unix epoch (Jan 1, 1970, midnight UTC).</returns>
        public static long ToUnixEpochDate(this DateTime date)
            => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero))
                .TotalSeconds);
    }
}
