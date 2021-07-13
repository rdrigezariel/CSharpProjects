using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentryOne_ClassesAndObjects
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
