//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


namespace StringBuilderSubstring
{
    using System.Text;

    public static class SubstringExtension
    {
        public static StringBuilder MySubstring(this StringBuilder sb, int index, int length)
        {
            var result = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                result.Append(sb[i]);
            }
            return result;
        }
    }
}
