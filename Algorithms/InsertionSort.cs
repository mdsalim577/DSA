namespace Algorithms;
/// <summary>
/// Analogy - Sorting a deck of playing cards
///
/// Best Case - O(n) when the array is already sorted
/// Worst Case - O(n^2)
/// Space Complexity - O(1)
///
/// 3,2,1,5,4
/// 2,3,1,5,4
/// 1,2,3,5,4
/// 1,2,3,4,5
/// </summary>
public static class InsertionSort
{
    public static void Sort(int[] arr)
    {
        var length = arr.Length;

        for (int i = 1; i < length; i++)
        {
            var key = arr[i];
            var j = i - 1;

            // Move elements of arr[0..i-1] that are greater than key to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}