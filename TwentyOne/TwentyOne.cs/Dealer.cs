using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TwentyOne.cs
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());   // Deals first card.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");  // Displays card.
            Deck.Cards.RemoveAt(0);     // Removes dealt card from deck.
        }
    }
}
