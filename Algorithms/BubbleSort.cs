namespace Algorithms;

public static class BubbleSort
{
    /// <summary>
    /// Best case O(n) -- in sorted array with a flag
    /// Worst case O(n^2)
    /// Space complexity O(1)
    /// 
    /// here to get best case, we need to add a flag which will exit the loop
    /// if there is no swap
    /// </summary>
    /// <param name="arr"></param>
    
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }
}