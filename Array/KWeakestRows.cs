//Given a m * n matrix mat of ones (representing soldiers) and zeros (representing civilians),
//return the indexes of the k weakest rows in the matrix ordered from the weakest to the strongest.
//A row i is weaker than row j, if the number of soldiers in row i is less than the number of soldiers in row j,
//or they have the same number of soldiers but i is less than j. Soldiers are always stand in the frontier of a row,
//that is, always ones may appear first and then zeros.

using System;
using System.Linq;

namespace Array
{
    class KWeakestRows
    {
        public static int[] KWeakestRow(int[][] mat, int k)
        {
            // in select x is a row and i is index of each 
            return mat.Select((x, i) => (i, c: x.Count(y => y == 1)))
                .OrderBy(z => z.c)
                .ThenBy(z => z.i)
                .Select(z => z.i)
                .Take(k).ToArray();
        }
        static void Main(string[] args)
        {
            int[][] array = new[]
            {
                new []{1, 0, 0, 0},
                new []{1, 1, 1, 1},
                new []{1, 0, 0, 0},
                new []{1, 0, 0, 0}
            };
            int[] result = KWeakestRow(array, 2);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
