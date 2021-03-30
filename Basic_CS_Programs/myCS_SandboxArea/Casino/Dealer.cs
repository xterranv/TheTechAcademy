using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //Deal method.
        public void Deal(List<Card> Hand)
        {             
            //Adding the card to the hand, the ca
            Hand.Add(Deck.Cards.First());
            //writing to the console what card was added to the hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            
            Deck.Cards.RemoveAt(0);
        }
    }
}
