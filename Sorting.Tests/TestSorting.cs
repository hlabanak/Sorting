using FluentAssertions;
using NUnit.Framework;
using OzowQuestionOne.SortEngine;

namespace SortingTests
{
    public class TestSorting
    {
        private ISortService _sortService;
        [SetUp]
        public void Setup()
        {
            ISorting sort = new Sorting();
            _sortService = new SortService(sort);
        }

        [TestCase("Karabo Hlabana", "aaaaabbhklnor")]
        public void TestSortReverseWords(string searchText,string sortResult)
        {
            var returnedResults = _sortService.ShowSortResults(searchText);

            returnedResults.Should().Be(sortResult);
        }

        [TestCase("Karabo? Hlabana", "aaaaabbhklnor")]
        public void TestPunctuationWords(string searchText, string sortResult)
        {
            var returnedResults = _sortService.ShowSortResults(searchText);

            returnedResults.Should().Be(sortResult);
        }
    }
}