using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_yatzy
{
    internal static  class PlayerController
    {
        public static List<Player> AddPlayersToGame()
        {
            Console.WriteLine("Hvem er med i spillet?");
            bool AddPlayer = true;
            int PlayerId = 1;
            List<Player> PlayerList = new List<Player>();

            while (AddPlayer == true)
            {
                string playerName;
                Console.WriteLine($"Tilføj spiller {PlayerId}: ");
                playerName = Console.ReadLine();

                //Hvis brugeren ikke indtaster et spillernavn så check om der er oprettet minimum 2 spillere
                if (string.IsNullOrWhiteSpace(playerName) && PlayerList.Count < 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Indtast minimum 2 spillere!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (string.IsNullOrWhiteSpace(playerName) && PlayerList.Count >= 2)
                {
                    AddPlayer = false;
                }
                else
                {
                    PlayerList.Add(new Player(PlayerId, playerName));
                    PlayerId++;
                }
            }
            return PlayerList;
        }
    }
}
