namespace Algorithms.Core;

public static class Search
{
    /* TODO Returning NumberOfGuesses before returning the position and use Benchmark.
     * Generate target randomly.
     * */
    public static int BinarySearch(int[] orderedArray, int target)
    {
        var low = 0;
        var high = orderedArray.Length - 1;
        var numberOfGuesses = 0;
        while (low <= high)
        {
            numberOfGuesses++;
            var mid = (low + high) / 2;
            var guess = orderedArray[mid];

            if (guess == target)
            {
                return mid;
            }
            if (guess < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            
        }

        return numberOfGuesses;
    }
    
    public static int SimpleSearch(IEnumerable<int> orderedArray, int target)
    {
        var numberOfGuesses = 0;
        foreach (var item in orderedArray)
        {
            numberOfGuesses++;
            if (item == target)
            {
                break;
            }
        }

        return numberOfGuesses;
    }
}