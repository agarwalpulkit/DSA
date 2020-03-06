//On an 8x8 chessboard, there can be multiple Black Queens and one White King.
//Given an array of integer coordinates queens that represents the positions of the Black Queens,
//and a pair of coordinates king that represent the position of the White King,
//return the coordinates of all the queens (in any order) that can attack the King.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class QueensAttackingKing
    {
        public static IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {
            // all the 8 relative directions from where a queen can attack a king.
            int[][] directions =
            {
                new int[] {-1, -1},
                new int[] {0, -1},
                new int[] {1, -1},
                new int[] {1, 0},
                new int[] {1, 1},
                new int[] {0, 1},
                new int[] {-1, 1},
                new int[] {-1, 0}
            };
            IList<IList<int>> result = new List<IList<int>>();
            foreach (var direction in directions)
            {
                int x = king[0];
                int y = king[1];
                while (true)
                {
                    x += direction[0];
                    y += direction[1];

                    if (x < 0 || x > 7 || y < 0 || y > 7)
                        break;
                    if (!queens.Any(q => q[0] == x && q[1] == y))
                        continue;
                    result.Add(new[] { x, y });
                    break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[][] queens = new[]
            {
                new []{0,1},
                new []{1,0},
                new []{4,0},
                new []{0,4},
                new []{3,3},
                new []{2,4}
            };
            int[] king = new[] { 0, 0 };
            var result = QueensAttacktheKing(queens, king);
            foreach (var res in result)
            {
                foreach (var r in res)
                    Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }
}
