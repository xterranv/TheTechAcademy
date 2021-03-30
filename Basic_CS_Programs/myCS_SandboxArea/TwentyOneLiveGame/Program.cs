using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOneLiveGame;

namespace TwentyOneLiveGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino.");
            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer || bank <= 0)
            {
                Console.WriteLine("How much money are you playing with today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer || bank <= 0) Console.WriteLine("Please enter whole positive numbers only (no decimals).");
            }

            //Console.WriteLine("How much money are you playing with today?");
            //int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {0} Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"c:\Users\xterr\Desktop\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }


                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred, please contact your system administrator.");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thanks for Playing!!");
            }
            Console.WriteLine("Feel free to look around the casino. Good Bye.");
            Console.ReadLine();
        }

        private static void UpdateDBWithException(Exception ex)
        {
            //connection string
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGameLive;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";

            //query string with Parameterized query (which helps with SQL injection attacks)
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            //using statement - to control unmanaged code
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            //query db and get all exceptions
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGameLive;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) //loops thru each record you get
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);

                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
