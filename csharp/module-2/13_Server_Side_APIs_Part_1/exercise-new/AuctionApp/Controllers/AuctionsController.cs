using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        //first thing, let's GET all the auctions

        [HttpGet()]
        public List<Auction> GetAllAuctions(string title_like = "", double currentBid_lte = 0)
        {
            if (dao.SearchByTitle(title_like) != null && currentBid_lte > 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (currentBid_lte > 0 )
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else if (dao.SearchByTitle(title_like) != null )
            {
                return dao.SearchByTitle(title_like);
            }
            else
            {
                return dao.List();
            }  
        }

        //let's get an auction based on the ID of it 

        [HttpGet("{id}")]
        public ActionResult<Auction> GetAuctionById(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return auction;
            }
            else
            {
                return auction;
            }
            
        }
        //this is the one where we add an auction
        [HttpPost()]
        public ActionResult<Auction> AddAuction(Auction auction)
        {
            Auction addedAuction = dao.Create(auction);

            if (addedAuction != null)
            {
                return Created($"/auctions/{addedAuction.Id}", addedAuction);
            }
            else
            {
                return Problem("No can do, chief.");
            }
        }



   




    }
}
