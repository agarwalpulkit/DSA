﻿//In a deck of cards, every card has a unique integer.  You can order the deck in any order you want.
//Initially, all the cards start face down (unrevealed) in one deck.
//Now, you do the following steps repeatedly, until all cards are revealed:
// 1. Take the top card of the deck, reveal it, and take it out of the deck.
// 2. If there are still cards in the deck, put the next top card of the deck at the bottom of the deck.
// 3. If there are still unrevealed cards, go back to step 1.  Otherwise, stop.
//Return an ordering of the deck that would reveal the cards in increasing order.
//The first entry in the answer is considered to be the top of the deck.

using System;
using System.Collections.Generic;

namespace Arrays
{
    class RunningSum
    {
        public static int[] RunningArraySum(int[] nums)
        {
            if (nums.Length == 1)
                return nums;
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
        static void Main(string[] args)
        {
            int[] array = new[] {1, 2, 3, 4};
            foreach (var number in RunningArraySum(array))
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
