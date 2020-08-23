using System;
using System.Text;

namespace MatchText.Services
{

    public class MatchTextService : IMatchTextService
    {
        public string FindMatches(string text, string subText)
        {
            var result = FindAllMatchingIndexes(text, subText);

            return result;
        }

        private string FindAllMatchingIndexes (string text, string subText)
        {
            var mainText = text.ToLower();
            var textToMatch = subText.ToLower();
            var result = new StringBuilder();
            for (int index = 0;; index += textToMatch.Length) 
            {
                index = mainText.IndexOf(textToMatch, index);
                if (index == -1)
                return result.ToString().TrimEnd(',');
                result.Append(index).Append(',');
            }

        }
    }

}