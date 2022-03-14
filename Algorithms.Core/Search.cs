namespace Algorithms.Core;

public static class Search
{
    //Returning NumberOfGuesses before returning the position and use Benchmark.
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
        //return null;
    }
    
    public static int SimpleSearch(int[] orderedArray, int target)
    {
        var numberOfGuesses = 0;
        for (var i = 0; i < orderedArray.Length; i++)
        {
            numberOfGuesses++;
            if (orderedArray[i] == target)
            {
                //return i;
            }
        }

        return numberOfGuesses;
        //return null;
    }
}