using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //CLASS
    //public class Card

    //STRUCT EXAMPLE - change "class" to "struct"
    public struct Card
    {
        //constructor - it's values are assigned to an object upon creating
        //The constructor Method Name is always the name of the class. that's how c# knows it's a constructor
        
        
        //This says the card class has a property of data type String called Suit.
        //you can Get this property or Set this property
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    //ENUM EXAMPLE - below defines the ENUM
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }
}
