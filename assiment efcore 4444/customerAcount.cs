using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
    #region customerAcount
    public class customerAcount
    {
        public DateTime OwnerShipStartDate { get; set; }
        public string OwnerShipType { get; set; }
        public string AccountStatus { get; set; }
        public Customer customer { get; set; }
        public account account { get; set; }

        public int customerid { get; set; }
        public int accountid { get; set; }

    }
    #endregion
}
