using System;
using System.Collections.Generic;
using System.Text;

namespace OzowQuestionOne.SortEngine
{
    public class SortService : ISortService
    {
        private readonly ISorting _sorting;
        public SortService(ISorting sorting)
        {
            _sorting = sorting;
        }

        public string ShowSortResults(string sortText)
        { 
            var newSortedString = IgnorePunctuation(sortText.Replace(" ",""));
            return _sorting.SortLinq(newSortedString.ToLowerInvariant().ToCharArray());
        }

        public string IgnorePunctuation(string sortText)
        {
            var sb = new StringBuilder();
            foreach (char c in sortText)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public void Run()
        {
            Console.WriteLine("Enter any arbitrary text to sort: ");
            var sortText = Console.ReadLine();

            Console.WriteLine($"Sort results are:\n\n {ShowSortResults(sortText)}." );
        }

        public string SortLinq(char[] characterArray)
        {
            return _sorting.SortLinq(characterArray);
        }
    }
}
