using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingGame
{
    public class Betters
    {
        public int Money { get; set; }
        public bool _isBetting;
        public int _moneyToBet;

        public Betters(int money)
        {
           this.Money = money;
        }

        public void Win(int amount)
        {
            Money += amount;
        }

        public void Loose(int amount)
        {
            Money -= amount;
        }

       

    }
}
