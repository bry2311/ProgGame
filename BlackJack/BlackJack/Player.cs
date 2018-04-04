using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public List<Card> PlayerCards = new List<Card>();
        public int countNumber = 0;
        private int countCard = 0;
        private int computerChoice = 0;
        public void DrawCard(Card card)
        {
            PlayerCards.Add(card);
            countCard++;
        }

        public void ShowPlayerCard()
        {
            PlayerCards.ForEach(Console.WriteLine);
        }

        public int CountCardNumber()
        {
            countNumber = 0;
            foreach (Card c in PlayerCards)
            {
                if (c.Number > 10 && c.Number < 14)
                    countNumber += 10;
                else if (c.Number == 14 && countNumber < 21)
                    countNumber += 11;
                else if (c.Number == 14 && countNumber >= 21)
                    countNumber += 1;
                else
                    countNumber += c.Number;
            }
            return countNumber;
        }

        public int ComputerChoice()
        {
            if (countNumber <= 14)
                computerChoice = 1;
            else
                computerChoice = 0;

            return computerChoice;
        }

        public int CalculateWinner()
        {
            int tempCount = CountCardNumber();
            if (tempCount >= 21)
                tempCount -= 21;
            else
                tempCount = Math.Abs(tempCount - 21);
            return tempCount;
        }
    }
}
