using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        private Card()
        {
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
