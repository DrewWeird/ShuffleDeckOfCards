using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleDecOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck DecofCards = new Deck();
            DecofCards.CreateDeck();
            DecofCards.ShowDeck();
            Console.WriteLine();
            DecofCards.ShuffleDeck();
        }
    }


}
