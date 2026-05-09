using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
    #region Transaction
    public class Transaction
    {
        public int transactionid { get; set; }
        public DateTime transactionDate { get; set; }

        public int Amount { get; set; }
        public string transactiontype { get; set; }
        public string Description { get; set; }
        public account account { get; set; }
        public int accountid { get; set; }  
    }
    #endregion
}
