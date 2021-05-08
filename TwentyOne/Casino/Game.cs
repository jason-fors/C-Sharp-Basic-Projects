using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    // Abstract class. Cannot be instatiated.
    public abstract class Game
    {
        // Need to make sure the lists is not empty. Cannot add to null, so starting with empty list.
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        
        public string Name { get; set; }

        // Need to make sure the dictionary is not empty. Cannot add to null, so starting with empty list.
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        // Abstract methods can only exits in abtract class. Has no implementation.
        // Any class inheriting this class must implement this method.
        public abstract void Play();

        // This method gets inherited, but due to 'virtual' keyword, it can be overridden.
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }




    }
}
