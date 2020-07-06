using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace
{
    public class Bronze : Card
    {
        public override float DiscountRate 
        { 
            get 
            {
                if (Turnover < 100) return 0;
                else if (Turnover > 100 && Turnover < 300) return 1;
                else return 2.5f;
            } 
        }
        public Bronze(decimal turnover) : base(turnover)
        {
        }
    }
}
