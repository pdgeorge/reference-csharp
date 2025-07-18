namespace CSharp
{
    public static class StringExtensions
    {
        public static string FirstLetterUpperCase(this string word)
        {
            char letter = Char.ToUpper(word[0]);
            string remaining = word[1..];

            return letter + remaining;
        }
    }
}