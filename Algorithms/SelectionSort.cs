namespace Algorithms;

/// <summary>
/// Analogy - How will you arrange 5-10 cards
/// You will simply find out the minimum element and move it to the farthest left and so on...
///
/// Best Case - O(n^2)
/// Worst Case - O(n^2)
/// Space Complexity - O(1)
///
/// 3,2,1,5,4
/// 1,2,3,5,4
/// 1,2,3,4,5
/// </summary>
public static class SelectionSort
{
    public static void Sort(int[] arr)
    {
        var length = arr.Length;

        for (int i = 0; i < length - 1; i++)
        {
            var minIndex = i;

            for (int j = i + 1; j < length; j++)
            {
                // find out the minimum element index
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // swap the found minimum element with the current element
            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }
}