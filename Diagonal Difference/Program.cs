using System;

public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] arrRowItems = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                int arrItem = Convert.ToInt32(arrRowItems[j]);
                arr[i, j] = arrItem;
            }
        }
        int result = DiagonalDifference(arr);
        Console.WriteLine(result);
    }

    public static int DiagonalDifference(int[,] arr)
    {
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum1 += arr[i, i];
            sum2 += arr[i, arr.GetLength(0) - 1 - i];
        }
        return Math.Abs(sum1 - sum2);
    }
}