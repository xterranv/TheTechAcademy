using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //File I/O EXAMPLE - WRITE A FILE
            string text = "Here's some text";
            File.WriteAllText(@"C:\Users\xterr\Logs\Log.txt", text);

            //File I/O EXAMPLE - READ A FILE
            string txt = File.ReadAllText(@"C:\Users\xterr\Logs\Log.txt");

            //File I/O EXAMPLE - APPEND TO A TEXT FILE --- put in Dealer.cs
            string card = string.Format(Deck.Cards.First().ToString() + "\n");



            //INHERITENCE EXAMPLE
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Finley", "Jake", "Sofia" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();


            //POLYMORPHISM EXAMPLE - used with "Main Example"
            //Game game = new TwentyOneGame();


            //ABSTRACT EXAMPLE
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Finley", "Sofia", "Jake" };
            //game.ListPlayers();
            //Console.ReadLine();

            //OVERLOAD OPERATOR EXAMPLE
            //Game game = new TwentyOneGame();
            //instantiated the List from the Game class --public List<Player> Players { get; set; }
            //game.Players = new List<Player>(); 

            //Player player = new Player();
            //player.Name = "Finley";
            //game += player;
            //game -= player;

            //GENERICS EXAMPLE
            //Player<Card> player = new Player<Card>();
            //player.Hand = new List<Card>();

            //ENUM EXAMPLE video 1 pg252 - comment out foreach loop below
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds); //Casted Suit.Diamonds to an INT 
            //// can also type for Convert.ToInt32 above as: (int)Suit.Diamonds
            //Console.WriteLine(underlyingValue);

            //REFERENCE TYPE - Comment out Main Ex
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //Console.WriteLine(card1.Face); //class result = 8 --struct result = 8
            //Console.WriteLine(card2.Face); //class result = 8 -- struct result = 2
            //card2.Face = Face.King;
            //Console.WriteLine(card1.Face); //class result = king -- struct result = 8
            //Console.WriteLine(card2.Face); //class result = king -- struct result = king

            //MAIN EXAMPLE - Comment out when testing the "Inheritance Example"
            Deck deck = new Deck(); // Deck Object -- instantiate the object called Deck and assigned it to a variable called deck

            //LAMBDA EXAMPLE 1
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //LAMBDA EXAMPLE 2
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach ( Card card in newList)
            //{
            //    Console.WriteLine($"{card.Face} of {card.Suit}");
            //}

            //LAMBDA EXAMPLE 3 - sum the numbers in the list
            //List<int> numberList = new List<int>() { 1, 2, 3, 4, 535, 342, 23 };
            //int sum = numberList.Sum();

            //Console.WriteLine(sum);

            //LAMBDA EXAMPLE 4 - add 5 to each item
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            //int sum = numberList.Sum(x => x +5);

            //Console.WriteLine(sum);

            //LAMBDA EXAMPLE 5 - Maximum value in the list
            //List<int> numberList = new List<int>() { 1, 2, 3, 4, 535, 342, 23 };
            //int sum = numberList.Max();

            //Console.WriteLine(sum);

            //LAMBDA EXAMPLE 6 - Min value in the list
            //List<int> numberList = new List<int>() { 1, 2, 3, 4, 535, 342, 23 };
            //int sum = numberList.Min();

            //Console.WriteLine(sum);

            //LAMBDA EXAMPLE 7 - Concatenate methods (chain methods together) number list where the items are greater than 20 and sum
            //List<int> numberList = new List<int>() { 1, 2, 3, 4, 535, 342, 23 };
            //int sum = numberList.Where(x => x > 20).Sum();

            //Console.WriteLine(sum);


            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
