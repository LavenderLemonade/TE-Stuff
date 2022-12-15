using System;
using System.Collections.Generic;
using System.Text;

namespace TenmoClient.Models
{
    public class UpdateTransfer
    {
     
        public int Account_From { get; set; }
        public int Account_To { get; set; }
        public decimal Amount { get; set; }
    }
}
