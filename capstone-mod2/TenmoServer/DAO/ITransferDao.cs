using System.Collections.Generic;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
 
		public interface ITransferDao
		{
		string TransferFunds(int account_from, int account_to, decimal amtToTransfer);

		void AddToTransfers(Transfer theTransfer);

		List<string> GetAllTransfers();
			decimal GetBalance(int user_id);
		//List<Transfer> SeeTransactionHistory();
		// within this will be TransferDetails(int transfer_id)
		//Transfer TransferDetails(int transfer_id);

		bool ValidTransfer(int id, decimal amt);
		}
	
}
