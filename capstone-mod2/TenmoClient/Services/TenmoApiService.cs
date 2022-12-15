using RestSharp;
using System.Collections.Generic;
using TenmoClient.Models;


namespace TenmoClient.Services
{
    public class TenmoApiService : AuthenticatedApiService
    {
        

        protected static RestClient client = null;

        public TenmoApiService(string apiUrl) : base(apiUrl)
        {
            if (client == null)
            {
                client = new RestClient(apiUrl);
            }
        }

        public decimal GetBalance(int id = 0)
        {
            string url;
            if (id != 0)
            {
                url = $"transfer/{id}";
            }
            else
            {
                url = "transfer";
            }

            RestRequest request = new RestRequest(url);

            IRestResponse<decimal> response = client.Get<decimal>(request);
            return response.Data;
        }

        public bool ValidTransfer(int id, decimal amtToTransfer)
        {
            RestRequest request = new RestRequest($"transfer/verify/{id}");
            request.AddJsonBody(amtToTransfer);
            IRestResponse<bool> response = client.Post<bool>(request);
            return response.Data;
        }

        public string DoTransfer(int id1, int id2, decimal amtToTransfer)
        {
            UpdateTransfer theTransfer = new UpdateTransfer { Account_From = id1, Account_To = id2, Amount = amtToTransfer };
            RestRequest request = new RestRequest("transfer/swap");
            request.AddJsonBody(theTransfer);
            IRestResponse<string> response = client.Post<string>(request);
            return response.Data;
        }

        public List<string> GetTransfers()
        {
            RestRequest request = new RestRequest("transfer/list");
            IRestResponse<List<string>> response = client.Get<List<string>>(request);
            return response.Data;
        }

        public List<string> ListUsers(int id)
        {
            string url = $"Login/{id}";
            RestRequest request = new RestRequest(url);
            IRestResponse<List<string>> response = client.Get<List<string>>(request);
            return response.Data;

        }

        public void TransferFunds(int id1 = 0)
        {
            string url; 
            if (id1 != 0)
            {
                url = $"transfer/{id1}";
            }
            else
            {
                url = "transfer";
            }

            RestRequest request = new RestRequest(url);
        }
        // Add methods to call api here...



    }
}
