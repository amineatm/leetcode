public class _02FindNumberswithEvenNumberofDigits
{
    public static void main(string[] args)
    {
        int[] nums = [12, 345, 2, 6, 7896];
        Console.WriteLine(FindNumberswithEvenNumberofDigits(nums));
    }
    public static int FindNumberswithEvenNumberofDigits(int[] nums)
    {
        int length = 0;
        foreach (int x in nums)
        {
            if (x.ToString().Length%2 == 0)
            {
                length++;
            }
        }
        return length;

        //return nums.Where(x => x.ToString().Length % 2 == 0).Count();

    }
}