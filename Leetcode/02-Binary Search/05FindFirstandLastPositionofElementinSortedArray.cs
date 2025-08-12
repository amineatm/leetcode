public class _05FindFirstandLastPositionofElementinSortedArray
{
    public static void main(string[] args)
    {
        var finder = new _05FindFirstandLastPositionofElementinSortedArray();
        int[] array = { 5, 7, 7, 8, 8, 10 };
        int target = 8;
        var result = finder.SearchRange(array, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    public int[] SearchRange(int[] nums, int target)
    {
        return [-1, -1];
    }
}
