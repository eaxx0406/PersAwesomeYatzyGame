using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_yatzy
{
    internal class Die
    {
        public int Eyes { get; private set; }

        public Die ThrowDie() //Kaster terningen
        {
            Random rnd = new Random();
            this.Eyes = rnd.Next(1, 7); // genere et tilfældigt tal mellem 1 og 6 og sætter det til terningens øjne
            return this; //returner terningen
        }
    }
}
