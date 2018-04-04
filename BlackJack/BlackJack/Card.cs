using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public enum SymbolEnum { Spades , Hearts , Clubs , Diamonds}
        private int _number;
        private SymbolEnum _symbol;
        private string _outNumber;
        public int Number
        {
            get { return _number; }
            set { _number = Math.Max(2, Math.Min(14, value)); }
        }
        public SymbolEnum Symbol
        {
            get { return _symbol; }
            private set { _symbol = value; }
        }
        public Card(int number , SymbolEnum symbol)
        {
            Number = number;
            Symbol = symbol;
        }
        public Card() : this(0, 0)
        {
        }
        public override string ToString()
        {
            if (Number == 11)
                _outNumber = "Jack";
            else if (Number == 12)
                _outNumber = "Queen";
            else if (Number == 13)
                _outNumber = "King";
            else if (Number == 14)
                _outNumber = "Ace";
            else
                _outNumber = Number.ToString();
            return $"{_outNumber} \t {Symbol}";
        }
    }
}
