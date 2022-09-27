using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction
    {
        private int _reservePrice;

        public int ReservePrice
        {
            get
            {
                return _reservePrice;
            }
        }

        public ReserveAuction(int reservePrice) : base()
        {
            _reservePrice = reservePrice;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            if (offeredBid.BidAmount >= ReservePrice)
            {
                Console.WriteLine("Reserve Amount has been met.");
                return base.PlaceBid(offeredBid);
            }
            else
            {
                Console.WriteLine("Bid not high enough.");
            }
            return false;
        }
    }
}
