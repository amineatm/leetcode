public class _05MergeIntervals
{
    public static void main(string[] args)
    {
        var merger = new _05MergeIntervals();
        int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];
        var result = merger.Merge(intervals);
        foreach (var interval in result)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }

    public int[][] Merge(int[][] intervals)
    {
        return intervals;
    }
}
