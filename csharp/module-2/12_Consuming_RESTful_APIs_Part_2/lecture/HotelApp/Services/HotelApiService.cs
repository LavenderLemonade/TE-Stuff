using HotelReservationsClient.Models;
using HotelReservationsClient.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelReservationsClient.Services
{
    public class HotelApiService
    {
        protected static RestClient client = null;

        public HotelApiService(string apiUrl)
        {
            if (client == null)
            {
                client = new RestClient(apiUrl);
            }
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest("hotels");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            CheckForError(response, "Get hotels");
            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId = 0)
        {
            string url;
            if (hotelId != 0)
            {
                url = $"hotels/{hotelId}/reservations";
            }
            else
            { 
                url = "reservations";
            }

            RestRequest request = new RestRequest(url);
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            CheckForError(response, $"Get reservations for hotel {hotelId}");
            return response.Data;
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest($"reservations/{reservationId}");
            IRestResponse<Reservation> response = client.Get<Reservation>(request);

            CheckForError(response, $"Get reservation {reservationId}");
            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            //build request and send to the localhost
            // endpoint won't change 
            RestRequest request = new RestRequest("reservations");
            request.AddJsonBody(newReservation); //attach data to request
            IRestResponse<Reservation> response = client.Post<Reservation>(request); //send the request
            //check for success
            CheckForError(response, $"Add reservation for {newReservation.HotelId}");
            //we know that when we POST to the endpoint, we get a reservation object back with a reservation ID
            return response.Data;

        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            //remember that we have to update the whole object when we update, not part of it
            //it'll take what we update and leave the rest blank otherwise
            RestRequest request = new RestRequest($"reservations/{reservationToUpdate.Id}");
            request.AddJsonBody(reservationToUpdate); //add the object being updated
            IRestResponse<Reservation> response = client.Put<Reservation>(request); //PUT will overwrite the whole object on the server
            CheckForError(response, $"Update reservation for {reservationToUpdate.Id}");
            return response.Data;
        }

        public bool DeleteReservation(int reservationId)
        {
            RestRequest request = new RestRequest($"reservations/{reservationId}");
            IRestResponse response = client.Delete(request); //no data type to deserialize into because delete doesn't return data
            CheckForError(response, $"Delete reservation {reservationId}");
            return true;
        }

        /// <summary>
        /// Checks RestSharp response for errors. If error, writes a log message and throws an exception 
        /// if the call was not successful. If no error, just returns to caller.
        /// </summary>
        /// <param name="response">Response returned from a RestSharp method call.</param>
        /// <param name="action">Description of the action the application was taking. Written to the log file for context.</param>
        private void CheckForError(IRestResponse response, string action)
        {
            if (!response.IsSuccessful)
            {
                // TODO: Write a log message for future reference

                throw new HttpRequestException($"There was an error in the call to the server");
            }

        }
    }
}
