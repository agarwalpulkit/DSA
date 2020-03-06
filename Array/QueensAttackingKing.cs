//Given a m * n matrix of ones and zeros, return how many square sub matrices have all ones.

using System;

namespace Arrays
{
    class SquareSubMatrices
    {
        public static int CountSquares(int[][] matrix)
        {
            int n = matrix.Length;
            if (n == 0)
            {
                return 0;
            }
            int m = matrix[0].Length;

            int res = 0;
            int[,] dp = new int[n, m];

            //Converted the jagged array into matrix.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = matrix[i][j];
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        dp[i, j] = 0;
                        continue;
                    }
                    // check the min of all other three elements of square matrix. 
                    dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i, j - 1], dp[i - 1, j])) + 1;
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    res += dp[i, j];
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            int[][] array = new[]
            {
                new []{0,1,1,1},
                new []{1,1,1,1},
                new []{0,1,1,1}
            };
            Console.WriteLine(CountSquares(array));
            Console.ReadKey();
        }
    }
}
