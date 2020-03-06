//Given an array of integers, return how many of them contain an even number of digits.

using System;

namespace Arrays
{
    class ArrayParity
    {
        public static int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach (var num in nums)
            {
                // Convert the int to string and calculate the length.
                int length = num.ToString().Length;
                
                //If length is even then increase the counter.
                if (length % 2 == 0)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] array = new[] {555, 901, 482, 1771};
            Console.WriteLine(FindNumbers(array));
            Console.ReadKey();
        }
    }
}
