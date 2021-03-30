using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOneLiveGame
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyoneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyoneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            //Console.WriteLine("Place your bet");
            
            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter whole numbers only (no decimals).");
                }
                //int bet = Convert.ToInt32(Console.ReadLine());  CODE ABOVE REPLACED THIS LINE

                if (bet < 0)
                {
                    throw new FraudException("Security called, person removed");
                }

                bool successfulBet = player.Bet(bet);
                if (!successfulBet)
                {
                    //this says end this method and go back to the while loop in Main program
                    return;
                }
                //tracking the player's bets - using a dictionary (Bets dictionary in Game class)
                //if bet was successful, then below is run to create a dictionary entry for the player
                //Bets => dictionary, player = key, bet => value
                Bets[player] = bet;
            }
            //Dealing for loop. Starts out with 2 cards.  
            for (int i = 0; i <2; i++)
            {
                Console.WriteLine("Dealing... ");
                //foreach loop thru the players to deal each player a card
                foreach (Player player in Players)
                {
                    //Shows the players name
                    Console.Write("{0}: ", player.Name);
                    //calling the Deal method and passing in the players hand
                    Dealer.Deal(player.Hand);
                    
                    //Here we're checking for BlackJack on second card (index = 1)--- winning 1.5 times your bet
                    if ( i == 1)
                    {
                        //check for blackjack.  static rule so it's preferenced by the class name
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack!! {0} wins {1}", player.Name, Bets[player]);
                            //adds the player win to their bank balance
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            //Ends the round
                            return;
                        }
                    }
                }
                //Checks Dealer blackjack
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack!!  Everyone Loses!");
                        //If Dealer wins you give the dealer all the bets
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            //ask players if they want to Hit or Stay
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                        {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. You balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("The Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");

                //Looping thru each value pair
                foreach (KeyValuePair<Player, int> entry in Bets) 
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    
                    //Give the money to each player's balance/bank
                    //Lopping thru and Finding the Player in the Players list that matches the key value pair where the loop name = the key/value name
                    //And then it takes the player by calling "first()" and then take that balance and add what they bet * 2                    
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);

                    //Then minus that bet from the dealer
                    Dealer.Balance -= entry.Value;
                }
                //Ends the round
                return;
            }

            //compare payer and dealer hands of win lose or tie
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("PUSH!! No One Wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} Won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play Again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
                {
                    player.isActivelyPlaying = true;
                }
                else player.isActivelyPlaying = false;
            }            
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
