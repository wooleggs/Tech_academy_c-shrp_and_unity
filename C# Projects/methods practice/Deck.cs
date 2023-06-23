using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_practice
{
    public class Deck
    {
        public Deck()
        {
            //Basic constructor set up
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Facees = new List<string>()
            { "Two", "Three", "Four", "Five", "Six", "Seven",
               "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach (string Face in Facees)
            {
                foreach (string Suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = Suit;
                    card.Face = Face;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> Templist = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(Cards.Count);
                    Templist.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = Templist;
            }
            

        }
    }
}
