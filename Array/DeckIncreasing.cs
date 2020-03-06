//In a deck of cards, every card has a unique integer.  You can order the deck in any order you want.
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
    class DeckIncreasing
    {
        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            int[] cards = new int[deck.Length];
            Array.Sort(deck);
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < deck.Length; i++)
            {
                que.Enqueue(i);
            }

            int index = 0;
            while (que.Count > 0)
            {
                cards[que.Dequeue()] = deck[index++];
                if (que.Count > 0)
                    que.Enqueue(que.Dequeue());
            }

            return cards;
        }
        static void Main(string[] args)
        {
            int[] array = new[] {17, 13, 11, 2, 3, 5, 7};
            int[] result = DeckRevealedIncreasing(array);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
