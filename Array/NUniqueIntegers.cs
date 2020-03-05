//Given an integer n, return any array containing n unique integers such that they add up to 0.

using System;
using System.Linq;

namespace Array
{
    class NUniqueIntegers
    {
        public static int[] SumZero(int n)
        {
            int[] arr = new int[n];
            // if array size is one then just add 0 to it.
            if (n == 1)
            {
                arr[0] = 0;
                return arr;
            }
            else
            {
                Random random = new Random();
                // if array size is even then add random number from start and negative of that from end.
                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n / 2; i++)
                    {
                        int a = random.Next();
                        while (arr.Contains(a))
                            a = random.Next();
                        arr[i - 1] = a;
                        arr[n - i] = -(arr[i - 1]);
                    }
                    return arr;
                }
                // if array size is odd then add 0 in middle and random number from start and negative of that from end.
                if (n % 2 != 0)
                {
                    arr[n / 2] = 0;
                    for (int i = 1; i <= n / 2; i++)
                    {
                        int a = random.Next();
                        while (arr.Contains(a))
                            a = random.Next();
                        arr[i - 1] = a;
                        arr[n - i] = -(arr[i - 1]);
                    }
                    return arr;
                }
            }

            return null;
        }
        static void Main(string[] args)
        {
            int[] result = SumZero(10);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}
