using RestSharp;
using System.Collections.Generic;
using AuctionApp.Models;
using System.Net.Http;

namespace AuctionApp.Services
{
    public class AuctionApiService
    {
        public IRestClient client;

        public AuctionApiService(string apiUrl)
        {
            client = new RestClient(apiUrl);
        }

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest("auctions");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest requestOne = new RestRequest($"auctions/{auctionId}");
            IRestResponse<Auction> response = client.Get<Auction>(requestOne);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTerm)
        {
            RestRequest request = new RestRequest($"auctions?title_like={searchTerm}");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest($"auctions?currentBid_lte={searchPrice}");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new HttpRequestException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new HttpRequestException("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            return response.Data;
        }

        public Auction AddAuction(Auction newAuction)
        {
            RestRequest request = new RestRequest("auctions");
            request.AddJsonBody(newAuction); //attach the data to the request 
            IRestResponse<Auction> response = client.Post<Auction>(request); //send the request 
            //check for success
            CheckForError(response, $"Add reservation for {newAuction.Id}");
            return response.Data;
        }

        public Auction UpdateAuction(Auction auctionToUpdate)
        {
            RestRequest request = new RestRequest($"auctions/{auctionToUpdate.Id}");
            request.AddJsonBody(auctionToUpdate); //add the object that is being updated 
            IRestResponse<Auction> response = client.Put<Auction>(request); //keep in mind that PUT will overwrite the whole object on the server
            CheckForError(response, $"Update auction for {auctionToUpdate.Id}");
            return response.Data;
        }

        public bool DeleteAuction(int auctionId)
        {
            RestRequest request = new RestRequest($"auctions/{auctionId}");
            IRestResponse response = client.Delete(request); //no data type to deserialize into because delete doesn't return data 
            CheckForError(response, $"Delete auction {auctionId}");
            return true;
        }

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
