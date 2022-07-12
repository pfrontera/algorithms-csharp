namespace Algorithms.Core
{
    public static class Sorter
    {
        public static IEnumerable<int> QuickSort(int[] unorderedArray)
        {
            // TODO
            throw new NotImplementedException();
        }

        public static IEnumerable<int> SelectionSort(int[] unorderedArray)
        {
            for (var i = 0; i < unorderedArray.Length; i++)
            {
                var smallestIndex = i;

                for (var remainingIndex = i + 1; remainingIndex < unorderedArray.Length; remainingIndex++)
                {
                    if (unorderedArray[remainingIndex] < unorderedArray[smallestIndex])
                    {
                        smallestIndex = remainingIndex;
                    }
                }
                (unorderedArray[i], unorderedArray[smallestIndex]) = (unorderedArray[smallestIndex], unorderedArray[i]);
            }

            return unorderedArray;
        }

        public static IEnumerable<int> SelectionSort(List<int> unorderedList)
        {
            var orderedList = new int[unorderedList.Count];
            for (var i = 0; i < orderedList.Length; i++)
            {
                var smallest = FindSmallest(unorderedList);
                orderedList[i] = unorderedList[smallest];
                unorderedList.RemoveAt(smallest);
            }
            return orderedList;
        }

        private static int FindSmallest(List<int> numbersList)
        {
            var smallest = numbersList[0];
            var smallestIndex = 0;
            for (var i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] < smallest)
                {
                    smallest = numbersList[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }
}