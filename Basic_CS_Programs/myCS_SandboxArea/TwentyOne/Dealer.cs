using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string name {get; set;}
        public Deck Deck {get; set;}
        public int Balance {get; set;}

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //I/O APPEND TO A FILE EXAMPLE line 1
            Console.WriteLine(card); //moved deck.cards.First etc up to string card
            using (StreamWriter file = new StreamWriter(@"C:\Users\xterr\Desktop\logs\log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);

        }

    }
}
