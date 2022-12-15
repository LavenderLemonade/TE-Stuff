using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenmoServer.DAO;
using TenmoServer.Models;


namespace TenmoServer.Controllers
{
    [Route("transfer")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private ITransferDao transferDao;

        public TransferController(ITransferDao transferDao)
        {
            this.transferDao = transferDao;
        }

        [HttpGet("{id}")]
        public ActionResult<decimal> GetBalance(int id)
        {
            decimal balance = transferDao.GetBalance(id);
            return balance;
        }

        [HttpPost("verify/{id}")]
        public ActionResult<bool> VerifyBalance(int id, decimal amtToTransfer)
        {
            return transferDao.ValidTransfer(id, amtToTransfer);
        }

        [HttpPost("swap")]
        public ActionResult<string> TransferFunds(UpdateTransfer transfer)
        {
            return transferDao.TransferFunds(transfer.Account_From, transfer.Account_To, transfer.Amount);
        }

        [HttpGet("list")]
        public ActionResult<List<string>> GetAllTransfers()
        {
            return transferDao.GetAllTransfers();
        }


    }
}
