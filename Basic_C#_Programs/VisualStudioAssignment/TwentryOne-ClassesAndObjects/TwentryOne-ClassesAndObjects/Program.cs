using System;
using System.Collections.Generic;

namespace TwentryOne_ClassesAndObjects
{
    static class Program
    {
        static void Main()
        {
            Card card = new Card();

            card.Suit = Suit.Clubs;
            int underlyingValue = (int)Suit.Clubs;
            Console.WriteLine(underlyingValue);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
