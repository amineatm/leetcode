public class _01MaxConsecutiveOnes
{
    public static void main(string[] args)
    {
        int[] array = { 1, 2, 3, 6, 8, 9, 7, 10 };

        Console.WriteLine(FindMaxConsecutiveOnes(array));
    }
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0, currentCount = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 0;
            }
        }

        return maxCount;

    }
}