//Given an array A of non-negative integers, half of the integers in A are odd, and half of the integers are even.
//Sort the array so that whenever A[i] is odd, i is odd; and whenever A[i] is even, i is even.
//You may return any answer array that satisfies this condition.

using System;

namespace Arrays
{
    class NUniqueIntegers
    {
        public static int[] SortArrayByParityII(int[] A)
        {
            int evenIndex = 0, oddIndex = 1;
            int[] res = new int[A.Length];
            foreach (var t in A)
            {
                // if the number is even store it in even index. 
                if (t % 2 == 0)
                {
                    res[evenIndex] = t;
                    evenIndex += 2;
                }
                // if the number is odd store it in odd index. 
                else
                {
                    res[oddIndex] = t;
                    oddIndex += 2;
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            int[] array = new[] {4, 2, 5, 7};
            int[] result = SortArrayByParityII(array);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}
