using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace
{
    public class Gold : Card
    {
        public override float DiscountRate
        {
            get 
            { 
                if (Turnover < 100) return 2;
                if (Turnover > 800) return 10;
                return (float)(Math.Floor(Turnover / 100) + 2);
            }
        }


        public Gold(decimal turnover) : base(turnover)
        {
        }
    }
}
