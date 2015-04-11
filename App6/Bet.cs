
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dayattheraces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount > 0)
                return Bettor.Name + "bets" + Amount + "back on dog number" + Dog;
            else
                return Bettor.Name + "hasn't placed a bet";
        }
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
                return Amount;
            else
                return -Amount;
        }
    }
}
