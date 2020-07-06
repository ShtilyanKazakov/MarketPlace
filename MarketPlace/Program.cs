using System;

namespace MarketPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Bronze bronzeCard = new Bronze(0);
            bronzeCard.PrintData(150m);
            Silver silverCard = new Silver(600);
            silverCard.PrintData(850m);
            Gold goldCard = new Gold(1500);
            goldCard.PrintData(1300m);
        }
    }
}
