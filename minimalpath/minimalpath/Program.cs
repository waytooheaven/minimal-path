using System;
using System.Collections.Generic;
using System.Linq;

class GFG
{

    // Util function to find  
    // minimum sum for a path 
    static int minSumPath(ref List<List<int>> A)
    {

        int[] memo = new int[A.Count];
        int n = A.Count - 1;

        // For the bottom row 
        for (int i = 0; i < A[n].Count; i++)
            memo[i] = A[n][i];

        for (int i = A.Count - 2; i >= 0; i--)
            for (int j = 0; j < A[i + 1].Count - 1; j++)
                memo[j] = A[i][j] +
                          (int)Math.Min(memo[j],
                                   memo[j + 1]);

        return memo[0];
    }

    public static void Main()
    {
        List<List<int>> A = new List<List<int>>();
        A.Add(new List<int> { 7 });
        A.Add(new List<int> { 6,3 });
        A.Add(new List<int> { 3,8,5 });
        A.Add(new List<int> { 11,2,10,9 });
        Console.WriteLine(minSumPath(ref A));
        Console.ReadLine();
    }
}