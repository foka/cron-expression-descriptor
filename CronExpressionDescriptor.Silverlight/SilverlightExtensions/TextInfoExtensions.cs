using System.Globalization;

namespace System.Text
{
    public static class CultureInfoExtensions
    {
        /// <summary>
        /// Converts to title case: each word starts with an upper case.
        /// </summary>
        /// <remarks>
        /// Primitive replacement of missing TextInfo.ToTitleCase in Silverlight (used in ExpressionDescriptor.TransformCase)
        /// from: https://social.msdn.microsoft.com/Forums/en-US/aca32898-c161-411b-bfbb-6631956aba2d/where-is-textinfototitlecase
        /// </remarks>
        public static string ToTitleCase(this TextInfo textInfo, string value)
        {
            if (value == null)
                return null;
            if (value.Length == 0)
                return value;

            StringBuilder result = new StringBuilder(value);
            result[0] = char.ToUpper(result[0]);
            for (int i = 1; i < result.Length; ++i)
            {
                if (char.IsWhiteSpace(result[i - 1]))
                    result[i] = char.ToUpper(result[i]);
                else
                    result[i] = char.ToLower(result[i]);
            }
            return result.ToString();
        }
    }
}