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
            bool AddPlayer = true; //viser at der skal tilføjes spillere til spillet
            int PlayerId = 1;
            List<Player> PlayerList = new List<Player>(); //liste over spiller

            while (AddPlayer == true) //Så længe der skal tilføjes flere spillere
            {
                Console.WriteLine($"Tilføj spiller {PlayerId}: "); 
                string playerName = Console.ReadLine(); //brugeren indtaster spillernavn

                if (string.IsNullOrWhiteSpace(playerName) && PlayerList.Count < 2) // Hvis brugeren ikke har indtastet et gyldigt spillernavn OG spillerantal er mindre end 2
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; //skift tekstfarve til rød
                    Console.WriteLine("Indtast minimum 2 spillere!!"); //fejlmeddelse
                    Console.ForegroundColor = ConsoleColor.White; //skift tekstfarve tilbage til hvis
                }
                else if (string.IsNullOrWhiteSpace(playerName) && PlayerList.Count >= 2) //Hvis brugeren ikke har indtastet et gyldigt spillernavn OG spillerantal er 2 eller over
                {
                    AddPlayer = false; //Der skal ikke længere tilføjes flere spillere og while loopet afsluttes da betingelsen nu er falsk
                }
                else //Brugeren indtaster et validt spillernavn
                {
                    PlayerList.Add(new Player(PlayerId, playerName)); //opret spiller
                    PlayerId++; //gør spillerid klar til næste spiller der (måske) skal oprettes
                }
            }
            return PlayerList; //returner den færdige spiller liste
        }
    }
}
