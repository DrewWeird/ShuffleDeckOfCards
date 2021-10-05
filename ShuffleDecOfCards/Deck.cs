using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleDecOfCards
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        string[] CreatedCards = new string[52];
        public void CreateDeck()
        {

            for (int i = 0; i < 52; i++)
            {
                Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                int val = i % 13 + 2;
                Cards.Add(new Card(val, suite));
            }
        }

        public void ShowDeck()
        {
            int i = 0;
            foreach (Card card in this.Cards)
            {
                Console.WriteLine(card.Name);
                CreatedCards[i] = card.Name;
                i++;
                
            }
        }

        public void ShuffleDeck()
        {
            Random Shuffle = new Random();
            CreatedCards = CreatedCards.OrderBy(x => Shuffle.Next()).ToArray();
            foreach (var card in this.CreatedCards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
