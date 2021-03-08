using System;
using System.Collections.Generic;
using System.Text;

namespace OzowQuestionOne.SortEngine
{
    public class Sorting : ISorting
    {

        public string SortLinq(Char[] listOfLetters)
        {
            Array.Sort(listOfLetters);
            return new string(listOfLetters);
        }
    }
}
