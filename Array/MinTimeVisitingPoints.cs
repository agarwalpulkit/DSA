//On a plane there are n points with integer coordinates points[i] = [xi, yi].
//Your task is to find the minimum time in seconds to visit all points.
//You can move according to the next rules:
//In one second always you can either move vertically, horizontally by one unit or diagonally
//(it means to move one unit vertically and one unit horizontally in one second).
//You have to visit the points in the same order as they appear in the array.

using System;

namespace Arrays
{
    class MinTimeVisitingPoints
    {
        public static int MinTimeToVisitAllPoints(int[][] points) {
            int i = 0;
            int count = 0;
            while (i < (points.Length - 1))
            {
                // fetch first and second point from array.
                int [] first = points[i];
                int [] second = points[i + 1];
                int x = first[0] - second[0];
                //if x or y is in minus, multiply it by -1 to calculate total distance between them.
                if (x < 0)
                    x *= -1;
                int y = first[1] - second[1];
                if (y < 0)
                    y *= -1;
                // greater number between x and y will be total time taken to travel from first to second point.
                if (x > y)
                    count += x;
                else
                    count += y;
                i++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            int[][] array = new[]
            {
                new []{1, 1},
                new []{3, 4},
                new []{-1, 0}
            };
            Console.WriteLine(MinTimeToVisitAllPoints(array));
            Console.ReadKey();
        }
    }
}
