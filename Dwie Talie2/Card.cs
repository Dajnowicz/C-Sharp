using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwie_Talie
{
    class Card
    {
        public Suits suit { get; set; }
        public Values value { get; set; }

        public Card (Suits suit, Values value)
        {
            this.suit = suit;
            this.value = value;
        }

        public string Name
        {
            get
            {
                return value.ToString() +" "+ suit.ToString();
            }
        }



        public enum Suits
        {
            Karo,
            Pik,
            Trefl,
            Serce,
        }

        public enum Values
        {
            Dwa =2,
            Trzy = 3,
            Cztery = 4,
            Piec = 5,
            Szesc =6,
            Siedem =7,
            Osiem = 8,
            Dziewiec = 9,
            Dziesiec = 10,
            Jopek = 11,
            Dama = 12,
            Krol = 13,
            As = 14,
        }
    }

    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.suit < y.suit)
            {
                return -1;
            }
            if  (x.suit > y.suit)
            {
                return 1; 
            }
            if(x.value < y.value)
            {
                return -1;
            }
            if (x.value > y.value)
            {
                return 1;
            }
            return 0;
        }
    }
}
