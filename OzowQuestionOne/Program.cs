using OzowQuestionOne.SortEngine;
using System;

namespace OzowQuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ISorting sort = new Sorting();
            ISortService sortService = new SortService(sort);

            sortService.Run();
            Console.ReadLine();
        }
    }
}
