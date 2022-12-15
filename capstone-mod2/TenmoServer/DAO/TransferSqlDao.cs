using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TenmoServer.Models;
using TenmoServer.Security;
using TenmoServer.Security.Models;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.DAO
{
    public class TransferSqlDao : ITransferDao
    {
        private readonly string connectionString;
		public TransferSqlDao(string dbConnectionString)
		{
			connectionString = dbConnectionString;
		}
		public List<Transfer> SeeTransferHistory()
		{
			List<Transfer> transferList = new List<Transfer>();

			using (SqlConnection conn = new SqlConnection(connectionString))
            {
				conn.Open(); //open up the connection 

				SqlCommand cmd = new SqlCommand("SELECT * FROM transfer", conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
                {
					Transfer transfer = MakeTransferFromReader(reader);
					transferList.Add(transfer);
                }

            }
			return transferList;
		}

		public decimal GetBalance(int userId)
        {
			decimal balance = 0;

			using (SqlConnection conn = new SqlConnection(connectionString))
            {
				conn.Open();

				SqlCommand cmd = new SqlCommand("SELECT balance FROM account WHERE user_id = @user_id", conn);
				cmd.Parameters.AddWithValue("@user_id", userId);

				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
                {
					balance = Convert.ToDecimal(reader["balance"]);
                }
			}

			return balance;
        }

        public string TransferFunds(int userId1, int userId2, decimal amtToTransfer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

				SqlCommand cmd = new SqlCommand("BEGIN TRANSACTION; UPDATE account SET balance -= @transferAmount WHERE user_id = @user_id_1; " +
                    "UPDATE account SET balance += @transferAmount WHERE user_id = @user_id_2; COMMIT;", conn);
                cmd.Parameters.AddWithValue("@user_id_1", userId1);
                cmd.Parameters.AddWithValue("@user_id_2", userId2);
                cmd.Parameters.AddWithValue("@transferAmount", amtToTransfer);

                cmd.ExecuteNonQuery();
				// do SQL command to get user's balance
				Transfer currentTransfer = new Transfer { Account_From = userId1, Account_To = userId2, Amount = amtToTransfer };
				AddToTransfers(currentTransfer);
				return $"Your balance is: {GetBalance(userId1)}";

			}
        }

		public string FindAccountFromUser(int userId)
        {
			string accountNum = "";

			using (SqlConnection conn = new SqlConnection(connectionString))
            {
				conn.Open();

				SqlCommand cmd = new SqlCommand("SELECT account_id FROM account WHERE user_id = @user_id", conn);
				cmd.Parameters.AddWithValue("@user_id", userId);
				SqlDataReader readerRabbit = cmd.ExecuteReader();

				while (readerRabbit.Read())
                {
					accountNum = Convert.ToString(readerRabbit["account_id"]);
                }
            }
			return accountNum;
        }

		public void AddToTransfers(Transfer theTransfer)
        {
			using (SqlConnection conn = new SqlConnection(connectionString))
            {
				conn.Open();

				SqlCommand cmd = new SqlCommand("INSERT INTO transfer (transfer_type_id, transfer_status_id, account_from, account_to, amount) VALUES (@type_id, @status_id, @id1, @id2, @amount)", conn);
				cmd.Parameters.AddWithValue("@type_id", 2);
				cmd.Parameters.AddWithValue("@status_id", 2);
				cmd.Parameters.AddWithValue("@id1", FindAccountFromUser(theTransfer.Account_From));
				cmd.Parameters.AddWithValue("@id2", FindAccountFromUser(theTransfer.Account_To));
				cmd.Parameters.AddWithValue("@amount", theTransfer.Amount);

				cmd.ExecuteNonQuery();
			}
        }

		public List<string> GetAllTransfers()
        {
			List<string> theseTransfers = new List<string>();

			using (SqlConnection conn = new SqlConnection(connectionString))
            {
				conn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM transfer", conn);
				SqlDataReader readerRabbit = cmd.ExecuteReader();

				while (readerRabbit.Read())
                {
					Transfer theNewOne = MakeTransferFromReader(readerRabbit);
					theseTransfers.Add($"Transfer ID: {theNewOne.Transfer_Id} -- Account From: {theNewOne.Account_From} -- Account To: {theNewOne.Account_To} -- Transfer Type: {theNewOne.Transfer_Type} -- Transfer Status: {theNewOne.Transfer_Status} -- Transfer Amount: {theNewOne.Amount}");
                }
            }

			return theseTransfers;
        }



		public bool ValidTransfer(int userId, decimal amountToTransfer)
        {
			decimal balance = GetBalance(userId);

			if (balance > 0 && balance > amountToTransfer)
			{

				return true;

            }
            else if(amountToTransfer > balance)
            {
                Console.WriteLine("Nope, get lost! Back to work!!");
				return false;
            }

			return false;

        }


		public Transfer MakeTransferFromReader(SqlDataReader reader)
        {
			Transfer transfer = new Transfer()
			{
				Transfer_Id = Convert.ToInt32(reader["transfer_id"]),
				Account_From = Convert.ToInt32(reader["account_from"]),
				Account_To = Convert.ToInt32(reader["account_to"]),
				Transfer_Type = Convert.ToInt32(reader["transfer_type_id"]),
				Transfer_Status = Convert.ToInt32(reader["transfer_status_id"]),
				Amount = Convert.ToDecimal(reader["amount"]),

			};
			return transfer;

        }





	}
}
