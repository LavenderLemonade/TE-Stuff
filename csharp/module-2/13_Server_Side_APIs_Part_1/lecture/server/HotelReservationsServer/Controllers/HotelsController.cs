using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    [Route("hotels")] //route attribute defines the location of the controller
    //[Route([controller])) would work too because tis is the HotelsController
    [ApiController] //this is an API controller 
    public class HotelsController : ControllerBase
    {
        private static IHotelDao hotelDao;

        public HotelsController() //in our constructor we have the DAO for the hotels
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
        }

        [HttpGet()] //this method handles the GET requests
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("{id}")] // ads id onto the route
        public ActionResult<Hotel> GetHotel(int id) //another name for a controller method is an action, thus methods and actions are interchangable
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound(); // if it isn't there, toss a 404 
            }
        }
    }
}
