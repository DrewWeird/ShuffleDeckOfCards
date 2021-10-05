using System;
using System.Collections.Generic;
using System.Text;

namespace ShuffleDecOfCards
{
    public class Card
    {
        public enum Suites
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public int Value
        {
            get;
            set;
        }

        public Suites Suite
        {
            get;
            set;
        }

        public string NamedValue
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                {
                    case (14):
                        name = "Ace";
                        break;
                    case (13):
                        name = "King";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (11):
                        name = "Jack";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }

                return name;
            }
        }

        public string Name
        {
            get
            {
                return NamedValue  + Suite.ToString();
            }
        }

        public Card(int Value, Suites Suite)
        {
            this.Value = Value;
            this.Suite = Suite;
        }
    }

}
