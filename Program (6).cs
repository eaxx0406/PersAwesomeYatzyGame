using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Test_yatzy;

//Setup af spil
Console.ForegroundColor = ConsoleColor.White; //teksten i konsollen er hvid
const int RoundsInGame = 15; // der er 15 runder i et spil Yatzy
const int ThrowsEachTurn = 3; // man har 3 omslag pr. runde 

List<Player> PlayerList = new List<Player>();//Liste over spillere i spillet
DiceCup DiceCup = new DiceCup(); //Terningebægeret
Die[] dice; //Array af terninger

//Velkomst
Console.WriteLine("Velkommen til Yatzy!");

//Tilføj spillere
PlayerList = PlayerController.AddPlayersToGame();
Console.Clear();


for (int i = 1; i <= RoundsInGame; i++) // Styrer hvor man runder der er spillet i forhold til hvor mange runder der er i spillet så vi undgår magic numbers
{
    foreach (Player player in PlayerList) //Hver spiller har en tur hver runde.
    {
        Console.WriteLine($"Det er nu {player.Name}s tur. ");
        Console.WriteLine("Tryk på Enter for at kaste med terningerne ");
        Console.ReadKey();
        dice = DiceCup.ThrowDice("1 2 3 4 5"); // Kaster alle 5 terninger i første slag
        PrintDice();
        
        for (int j = 2; j <= ThrowsEachTurn; j++) //j = 2 da du har kastet alle terninger i første slag
        {
            Console.WriteLine("Indtast numrene på de terning du vil kaste om: ");
            string diceToThrowAgain = Console.ReadLine();
            dice = DiceCup.ThrowDice(diceToThrowAgain);
            PrintDice();
        }
        //Vælg Kombination
        // 1) Find en måde spilleren vælger en kombination det kunne fx. være ved at indtaste noget 
        // 2) Tjek om den valgte kombination er valgt 
        // 2a) hvis kombinationen ikke er valgt tidligere: find udad om spilleren opfylder kravene for at få point (tjek om spiller reelt har fået fx. Yatzy)
        // hvis spilleren ikke opfylder kravene skal der tildeles 0 point for kombinationen og kombinationen er brugt!
        // 2b) Hvis Kombinationen er taget tidligere skal brugeren spørges igen indtil vedkommende vælger en mulig kombination
        // 3) lig de point Spilleren har scoret i denne runde til brugeren samlede score 

        int NumberOfOnes = CountDice(1); //tæller hvor mange 1´ere der er slået
        int NumberOfTwos = CountDice(2); //tæller hvor mange 2'ere der er slået
        int NumberOfThrees = CountDice(3); //tæller hvor mange 3'ere der er slået
        int NumberOfFoures = CountDice(4); //tæller hvor mange 4'ere der er slået
        int NumberOfFives = CountDice(5); //tæller hvor mange 5'ere der er slået
        int NumberOfSixes = CountDice(6); //tæller hvor mange 6'ere der er slået

        int sumOfEyes = CalculateChance(); //Chancen


    }
}

void PrintDice() //Viser hvad terningerne har slået
{
    Console.WriteLine($"Terningerne er kastet og viser: ");
    foreach (Die die in dice) //For hver terning
    {
        Console.Write($" {die.Eyes} "); //print hvad terningen viser
    }
    Console.WriteLine("");
}


int CountDice(int specifiedNumberOfEyes) // bruges til at finde udad hvor mange terninger der har et bestemt antal øjne
{
    int DiceWithSpecifiedNumberOfEyes = 0;
    foreach (Die die in dice) //For hver Terning
    {
        if (die.Eyes == specifiedNumberOfEyes) // Hvis antal af øjne svarer til det specificede antal af øjne i paramateren
        {
            DiceWithSpecifiedNumberOfEyes++; //lig 1 til det samlede antal
        }
    }
    return DiceWithSpecifiedNumberOfEyes; //returnere det samlede antal med antal øjne
}

int CalculateChance() //udregner hvad summen af alle terningernes øjne er 
{
    int sum = 0;
    foreach (Die die in dice) //For hver terning
    {
        sum = sum + die.Eyes; //tag den foreløbige sum og lig antal af øjne til resultatet bliver den nye sum
    }
    return sum; //Når alle terninger er gennemgået returneres den endelige sum.
}




