using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_yatzy
{
    internal class DiceCup
    {
        Die[] Dice = new Die[5];

        public DiceCup()
        {
            Dice = [new Die(), new Die(), new Die(), new Die(), new Die()];// opret array med 5 terninger
        }
        public Die[] ThrowDice(string DiceToRoll) //Kaster de nævnte terninger
        {
            if (DiceToRoll.Contains("1")) //Hvis terning 1 er nævnt
            {
                Dice[0] = Dice[0].ThrowDie(); //Kast den terning der er på index 0, husk at samlinger er 0 indexeret i c#
            }
            if (DiceToRoll.Contains("2")) //Hvis terning 2 er nævnt
            {
                Dice[1] = Dice[1].ThrowDie(); //Kast den terning der er på index 1, husk at samlinger er 0 indexeret i c#
            }
            if (DiceToRoll.Contains("3")) //Hvis terning 3 er nævnt
            {
                Dice[2] = Dice[2].ThrowDie(); //Kast den terning der er på index 2, husk at samlinger er 0 indexeret i c#
            }
            if (DiceToRoll.Contains("4")) //Hvis terning 4 er nævnt
            {
                Dice[3] = Dice[3].ThrowDie();  //Kast den terning der er på index 3, husk at samlinger er 0 indexeret i c#
            }
            if (DiceToRoll.Contains("5")) //Hvis terning 5 er nævnt
            {
                Dice[4] = Dice[4].ThrowDie();  //Kast den terning der er på index 4, husk at samlinger er 0 indexeret i c#
            }
            return Dice; // Når alle de nævnte terninger er rullet, returnerer du terninge arrayet
        }
    }
}
