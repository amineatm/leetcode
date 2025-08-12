public class _04RichestCustomerWealth
{
    public static void main(string[] args)
    {
        int[][] ints = [[1, 2, 3], [3, 2, 1]];
        Console.WriteLine(RichestCustomerWealth(ints));
    }

    public static int RichestCustomerWealth(int[][] accounts)
    {
        // int[] sums = new int[accounts.Length];
        // for (int i = 0; i < accounts.Length; i++)
        // {
        //     sums[i] = accounts[i].Sum();
        // }
        // return sums.Max();

        int max = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int rowSum = 0;
            var row = accounts[i];
            for (int j = 0; j < row.Length; j++)
                rowSum += row[j];

            if (rowSum > max) max = rowSum;
        }
        return max;
    }
}