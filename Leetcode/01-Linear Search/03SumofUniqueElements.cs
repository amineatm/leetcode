public class _03SumofUniqueElements
{
    public static void main(string[] args)
    {
        int[] ints = [1, 2, 3, 2];
        Console.WriteLine(SumOfUnique(ints));
    }

    public static int SumOfUnique(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (dictionary.ContainsKey(n))
            {
                dictionary[n]++;
            }
            else
            {
                dictionary[n] = 1;
            }
        }

        return dictionary.Where(x => x.Value == 1).Sum(x => x.Key);
    }
}