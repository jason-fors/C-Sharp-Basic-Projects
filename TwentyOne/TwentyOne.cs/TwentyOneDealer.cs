using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne.cs
{
    public class TwentyOneDealer: Dealer
    {
        // Need to make sure the lists is not empty. Cannot add to null, so starting with empty list.
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }

        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
