public class _05CheckIfNandItsDoubleExist
{
    public static void main(string[] args)
    {
        int[] ints = [10, 2, 5, 3];
        var checker = new _05CheckIfNandItsDoubleExist();
        Console.WriteLine(checker.CheckIfNandItsDoubleExist(ints));
    }

    public bool CheckIfNandItsDoubleExist(int[] arr)
    {
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            int target = arr[i] * 2;
            int find = BinarySearch(arr, target);
            if (find != -1 && find != i)
            {
                return true;
            }
        }
        return false;
    }
    private int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) left = mid + 1;
            else if (arr[mid] > target) right = mid - 1;
        }
        return -1;
    }
}