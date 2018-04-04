using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck 
    {
        public List<Card> Cards = new List<Card>();
        public Random RandomNumber = new Random();
        public Deck()
        {
            int index = 0;
            for (int s = 0; s < 4; s++)
            {
                for (int n = 2; n < 15; n++)
                {
                    Card newCard = new Card(n, (Card.SymbolEnum)s);
                    Cards.Insert(index, newCard);
                    index++;
                }
            }
          }
        public Card TopCard
        {
            get
            {
                if (Cards.Count > 0)
                {
                    Card selectedCard = Cards[0];
                    Cards.RemoveAt(0);
                    return selectedCard;
                }
                else
                    return null;
            }
        }

        public void Shuffle()
        {
            for (int s = 0; s < Cards.Count; s++)
            {
                int second = RandomNumber.Next(0,51);
                Card temp = Cards[s];
                Cards.RemoveAt(s);
                Card temp2 = Cards[second];
                Cards.RemoveAt(second);
                Cards.Insert(second, temp);
                Cards.Insert(s, temp2);
            }
        }
        public void ShowDeckCard()
        {
            Cards.ForEach(Console.WriteLine);
        }
    }
}
