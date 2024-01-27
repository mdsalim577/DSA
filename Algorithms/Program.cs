namespace Algorithms
{
    public static class Program
    {
        public static void Main()
        {
            var arr = new[] { 10, 4, 1, 6, 2, 7 };
            // BubbleSort.Sort(arr);
            SelectionSort.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ,");
            }
        }
    }
}