using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlace
{
    public abstract class Card : IPrintable
    {
        public string Owner { get; set; }
        public decimal Turnover { get; set; }
        public virtual float DiscountRate { get; set; }

        public Card(decimal turnover)
        {
            Turnover = turnover;
        }

        public virtual void PrintData(decimal purchaseValue)
        {
            Console.WriteLine("Purchase value: $" + purchaseValue);
            Console.WriteLine();
            Console.WriteLine("Discount rate: " + DiscountRate + "%");
            Console.WriteLine();
            Console.WriteLine("Discount: $" + purchaseValue * ((decimal)DiscountRate/100));
            Console.WriteLine();
            Console.WriteLine("Total: $" + (purchaseValue - (purchaseValue * ((decimal)DiscountRate / 100))));
            Console.WriteLine();
        }
    }
}
