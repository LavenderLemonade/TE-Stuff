using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    class BuyoutAuction : Auction
    {
        //Auction is now the parent class 

        public BuyoutAuction(int buyoutPrice) : base() //that tells it to call the base constructor when we do that 
        {
            _buyoutPrice = buyoutPrice;
        }
        //Buyout Price
        private int _buyoutPrice;

        //we want this bouyout price to be a readonly
        public int BuyoutPrice
        {
            get
            {
                return _buyoutPrice;
            }
        }

        public override bool PlaceBid(Bid offerBid)
        {
            bool newHighBid = base.PlaceBid(offerBid);
            
            if (newHighBid && offerBid.BidAmount >= this.BuyoutPrice)
            {
                Console.WriteLine($"Buyout met by: {offerBid.Bidder} with a price of {offerBid.BidAmount.ToString("C")}");
                base.EndAuction();
            }
            
            return false;
        }
    }
}
