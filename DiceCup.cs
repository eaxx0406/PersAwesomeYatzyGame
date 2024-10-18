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
            Dice = [new Die(), new Die(), new Die(), new Die(), new Die()];
        }
        public Die[] ThrowDice(string DiceToRoll)
        {
            if (DiceToRoll.Contains("1"))
            {
                Dice[0] = Dice[0].ThrowDie(); //I c# er samlinger 0 indexeret
            }
            if (DiceToRoll.Contains("2"))
            {
                Dice[1] = Dice[1].ThrowDie();
            }
            if (DiceToRoll.Contains("3"))
            {
                Dice[2] = Dice[2].ThrowDie();
            }
            if (DiceToRoll.Contains("4"))
            {
                Dice[3] = Dice[3].ThrowDie();
            }
            if (DiceToRoll.Contains("5"))
            {
                Dice[4] = Dice[4].ThrowDie();
            }
            return Dice;
        }
    }
}
