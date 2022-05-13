using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    public class GiantsBelt : Item
    {
        public GiantsBelt()
        {
            name = "Giant's Belt";
            price = 900;
            AddStat(Stat.HP, 350);
        }
    }
}
