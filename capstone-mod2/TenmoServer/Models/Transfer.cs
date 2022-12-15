using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    public class Transfer
    {
        public int Transfer_Id { get; set; }
        public int Account_From { get; set; }
        public int Account_To { get; set; }
        public int Transfer_Type { get; set; } = 2;
        public int Transfer_Status { get; set; } = 2;
        public decimal Amount { get; set; }
    }
}
