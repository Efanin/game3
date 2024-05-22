using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game3
{
    internal class Mine(string name)
    {
        public int Ore { get; set; } = 0;
        public int Worker { get; set; } = 5;
        public string NameOre { get; set; } = name;

        public void Tick()
        {
            Ore += Worker;
        }
        public void SellOre(FormMine formMine, ref int balance)
        {
            if (formMine.isButtonSell == false)
            {
                return;
            }
            if (Ore >= formMine.SellOre())
            {
                Ore -= formMine.SellOre();
                balance += formMine.SellOre();
                formMine.Clear();
            }
        }
        public void BuyWorker(FormMine formMine, ref int balance)
        {
            if (formMine.isButtonBuy == false)
            {
                return;
            }
            if (balance >= 300)
            {
                balance -= 300;
                Worker += 1;
                formMine.isButtonBuy = false;
            }
        }
    }
}
