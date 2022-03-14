using Algorithms.Core;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests;

public class Tests
{
    [Fact]
    public void Binary_search_should_be_faster_than_simple_search()
    {
        var orderedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var expected = 6;
        
        var binarySearchResult = Search.BinarySearch(orderedArray, 7);
        var simpleSearchResult = Search.SimpleSearch(orderedArray, 7);

        // TODO : do it with Benchmark.
        binarySearchResult.Should().BeLessThan(simpleSearchResult);
    }
}