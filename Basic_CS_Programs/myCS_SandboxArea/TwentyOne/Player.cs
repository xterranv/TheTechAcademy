using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    //public class Player<T>  //GENERICS EXAMPLE class syntax
    {
        //GENERICS EXAMPLE
        //By adding <T> to the Class (Player<T>) and List<>, this allows any data type to be passed in
        //in this example, originally List<> was a set of cards, 
        //but by adding <T> instead of <Card>, this allows Any game to use this class,
        //Such as Craps - which use dice, or Roulette - which uses a ball on a wheel
        
        //Properties of the Player class
        //public List<T> Hand { get; set; }           //GENERICS EXAMPLE List syntax
        public List<Card> Hand { get; set; }
        
        public int Balance {get; set;}
        public string Name {get; set;}
        public bool isActive {get; set;}

        //Adding an Overloaded Operator method
        //overload the + operator (to add a player into the game)
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
