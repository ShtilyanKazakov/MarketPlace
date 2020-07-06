using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace
{
    public class Silver : Card
    {
        public override float DiscountRate 
        { 
            get 
            {
                if (Turnover > 300) return 3.5f;
                else return 2;
            } 
        }
        public Silver(decimal turnover) : base(turnover)
        {
        }
    }
}
