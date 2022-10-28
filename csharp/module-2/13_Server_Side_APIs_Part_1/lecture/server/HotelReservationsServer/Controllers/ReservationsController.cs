using HotelReservations.DAO;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservations.Controllers
{
    [Route("reservations")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;
        private static IHotelDao hotelDao;
        public ReservationsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
            if (reservationDao == null)
            {
                reservationDao = new ReservationMemoryDao();
            }
        }

        //get the reservations 
        [HttpGet()] //GET requests to /reservation

        public List<Reservation> GetAllReservations()
        {
            return reservationDao.List(); //getting all the reservations from the DAO 
        }

        //get reservation by ID 

        [HttpGet("{id}")]

        public ActionResult<Reservation> GetReservationById(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            if (reservation != null)
            {
                return reservationDao.Get(id);
            }
            else
            {
                return NotFound(); //spit out a 404
            }
            
        }

        //let's also get these reservations by the hotel id

        [HttpGet("hotels/{hotelId}/reservations")] //starting the / lets us define 
        public ActionResult<List<Reservation>> GetReservationByHotel(int hotel_id)
        {
            Hotel hotel = hotelDao.Get(hotel_id);
            if (hotel == null)
            {
                return NotFound();
            }
            
            
            return reservationDao.FindByHotel(hotel_id);
            
        }

        //add a reservation

        [HttpPost()]

        public ActionResult<Reservation> AddReservation(Reservation newReservation)
        {
            Reservation addedReservation = reservationDao.Create(newReservation); //try and add the new reservation

            if(addedReservation != null)
            {
                return Created($"/reservations/{addedReservation.Id}", addedReservation);
            }
            else
            {
                return Problem("Can't make the reservation");
            }

        }
        
        //update the reservation 

        [HttpPut("{id}")]

        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            Reservation existingReservation = reservationDao.Get(id);

            if (existingReservation == null)
            {
                return NotFound();
            }

            Reservation updatedReservation = reservationDao.Update(existingReservation.Id, reservation);
            
            return updatedReservation;
        }

        //delete reservation

        [HttpDelete("{id}")]

        public ActionResult DeleteReservation(int id, Reservation reservation)
        {
            Reservation existingReservation = reservationDao.Get(id);

            if (existingReservation == null)
            {
                return NotFound();
            }

            bool didIt = reservationDao.Delete(id);

            if (didIt)
            {
                return NoContent();
            }
            else
            {
                return StatusCode(500);
            }
        }

    }
}
