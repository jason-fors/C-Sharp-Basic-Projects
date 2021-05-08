using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Deck
    {
        // Method to create a deck.
        public Deck()
        {
            // Using nested loop to create deck
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;        // Way to cast enum
                    card.Suit = (Suit)j;        // Way to cast enum
                    Cards.Add(card);
                }
            }



            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            //List<string> Faces = new List<string>()
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};

            //foreach (string face in Faces)
            //{
            //    foreach (string suit in Suits)
            //    {
            //        Card card = new Card();
            //        card.Suit = suit;
            //        card.Face = face;
            //        Cards.Add(card);

            //    }
            //}
        }
       
        // Properties
        public List<Card> Cards { get; set; }


        // Method for shuffling the deck.
        public void Shuffle(int times = 1)  // Takes a deck object and number of shuffles as parameters
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();           // Creating random object so we can use random methods


                while (Cards.Count > 0)            // Iterates through deck until it is empty
                {
                    int randomIndex = random.Next(0, Cards.Count);     // Choose a random index from 0 to 52 (number of cards in a deck)
                    TempList.Add(Cards[randomIndex]);              // Select the card at that index from the TempList and add it to the new deck
                    Cards.RemoveAt(randomIndex);           // Remove the selected card from the deck
                }

                Cards = TempList;                          // Makes re-ordered list the Cards attribute in deck object. Now it is a shuffled deck.
            }
        }
    }
}
