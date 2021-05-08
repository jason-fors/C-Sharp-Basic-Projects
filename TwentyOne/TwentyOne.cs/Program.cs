using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
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
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter the digits only, no decimals.");
            }
       

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);

            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Jason Fors\Desktop\IO_Practice\Logs\log.txt", true))
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
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Goodbye for now.");
            Console.Read();


            // EXPERIMENTATION AND NOTES ------------------------------

            //// Declaring constants -- can't be changed once compiled.
            //const string casinoName = "Grand Hotel and Casino"; 

            //// Globally unique identifier
            //Guid identifier = Guid.NewGuid();

            //// Constructor chain
            //Player newPlayer = new Player("Jesse");

            //// Instantiating DateTime object.
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;



            //// Some file input/output practice. 
            //string text = "Here is some text.";
            //// @ means ignore the escape characters. 
            //File.WriteAllText(@"C:\Users\Jason Fors\Desktop\IO_Practice\Logs\log.txt", text);
            //string text2 = File.ReadAllText(@"C:\Users\Jason Fors\Desktop\IO_Practice\Logs\log.txt");



            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();  // Workaround for now.
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;       // Using overloaded operator to add player to game.
            //game -= player;       // Using overloaded operator to remove player.

            //Deck deck = new Deck();


            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //Console.WriteLine(count);


            //deck.Shuffle();

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}


            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();



            //// Counting aces with lambda function
            //// x is like 'for x in cards'
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //// Filtering list with lambda function
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //// Examples of umber lambda functions
            //List<int> numberList = new List<int> { 1, 2, 3, 535, 342, 33 };
            //int sum = numberList.Sum(x => x + 5);  // Summing each (item + 5) on list.
            //Console.WriteLine(sum);
            //// You can concatenate functions...
            //int sum2 = numberList.Where(x => x > 20).Sum();

            // Another way to instantiate an object with values (in one line)
            // Card card = new Card() { Face = "King", Suit = "Spaces" };

            // Demonstration of inheritance
            //TwentyOneGame game = new TwentyOneGame();
            //game.Dealer = "Jesse";
            //game.Name = "TwentyOne";
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe"};
            //game.ListPlayers();
            //game.Play();

            // TwentyOneGame game = new TwentyOneGame();
            // game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            // game.ListPlayers();




            //int timesShuffled = 0;
            //deck = Shuffle(deck);       // Calling shuffle method below to shuffle deck.
            //deck = Shuffle(deck: deck, timesShuffled: out timesShuffled, times: 3);     // Can use parameter names with colons to make code more readable. 
            //deck = Shuffle(deck, out timesShuffled, 3);     // Calling shuffle with optional parameter, 3 shuffles. Call 'out parameter' with keyword out.

            // Example of enum
            // ConsoleColor color = ConsoleColor.DarkCyan;
            //// How to use the enum Suit
            //Card card = new Card();
            //card.Suit = Suit.Clubs;


            //Console.WriteLine("Times shuffled: {0}", timesShuffled);


        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
                                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                   (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

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
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
                                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
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
