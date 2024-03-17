using CustomExceptionLibrary;
using System.Text.RegularExpressions;

namespace Task_4_StringExtension
{
    public static class StringExtensions
    {
        public static int CountSubString(this string mainString,string subString)
        {
            if (string.IsNullOrWhiteSpace(mainString))
                throw new NotEmptyException("MainSring can not be empty");

            if (string.IsNullOrWhiteSpace(subString))
                throw new NotEmptyException("SubString can not be empty");

            return Regex.Matches(mainString, subString).Count;
        }
    }
}
