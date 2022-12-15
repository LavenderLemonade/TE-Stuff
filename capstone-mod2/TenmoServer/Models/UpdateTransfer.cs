using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    public class UpdateTransfer
    {

        public int Account_From { get; set; }
        public int Account_To { get; set; }
        public decimal Amount { get; set; }
    }
}
