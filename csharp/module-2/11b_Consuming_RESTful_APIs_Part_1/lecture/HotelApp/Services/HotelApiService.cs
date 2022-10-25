using HotelApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HotelApp.Services
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
            //build a request
            RestRequest request = new RestRequest("hotels");
            //send the request to the API
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);
            //IRestResponse is a container for the data coming back from the API
            //use the client (RestClient), to make a GET request for a specific type of data, and use the request object we made

            if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Something went wrong connecting to the server.");
            }

            return response.Data;
        }

        public List<Review> GetReviews()
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotel(int hotelId)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetHotelReviews(int hotelId)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetHotelsWithRating(int starRating)
        {
            throw new NotImplementedException();
        }

        public City GetPublicAPIQuery()
        {
            throw new NotImplementedException();
        }
    }
}
