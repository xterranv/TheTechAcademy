using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOneLiveGame
{
    //Business Logic Layer - static class
    //Contains a bunch of methods that we can call for set of rules and set card values
    public class TwentyOneRules
    {
        //PRIVATE -- Will only be accessed inside this class
        //STATIC -- So you don't have to create a twenty one rules object to access it.
        //_cardValue - naming convention to have an underscore in Private classes
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            //instantiate it with all of our cards
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] =9,
            [Face.Ten] =10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] =10,
            [Face.Ace] = 1
        };

        //This Method creates an Array of integers of all possible values
        private  static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //How many aces in the hand -- is the card's face == to an ace -- return a count
            int aceCount = Hand.Count(x => x.Face == Face.Ace);

            //how many possible results (or values) are there -- needed when you create an array (how big it will be)
            //how big it will be is how many aces there are +1
            int[] result = new int[aceCount + 1];

            //Get the value of the hand
            int value = Hand.Sum(x => _cardValues[x.Face]);

            //take the first entry in our array and assign a value
            result[0] = value;

            //if there's no aces then there's 1 value so this is done (return result) nothing else gets executed
            if (result.Length == 1) return result;

            //iterating thru putting in different values of an Ace
            for (int i = 1; i < result.Length; i++)
            {
                //Get the value, value = 1 (from above line 47) * 10
                //i is the for loop int count so 1 ace is 1 or 11 (10*1=10 +1= 11)
                value += (i * 10);
                //returns the result
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            //create an integer array of all possible values
            int[] posssibleValues = GetAllPossibleHandValues(Hand);
            //get the largest value
            int value = posssibleValues.Max();
            //if it's = 21 then true, blackjacke
            if (value == 21) return true;
            //else false, no blackjack
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;

        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            //Integer Array of possible hand values
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);

            //Dealer rules above 16 and below 22 (so between 17 and 21) the dealer Has to Stay
            //This goes thru the possible hand values and see if one is inside 16 and 22
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }                
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //highest value that's also less than 21 and compare the two
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
