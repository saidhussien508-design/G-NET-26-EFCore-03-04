using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
    #region account
    public class account
    {
        [Key]
        public int AcountNumber { get; set; }   
        public string AccountType { get; set; }

        public DateTime openingDate { get; set; }   
        public int currentBalance { get; set; }
       
        public string Branchcode { get; set; }
        public List <Transaction> Transaction { get; set; }
        public branch branch { get; set; }

        public int branchid { get; set; }   


    }
    #endregion
}
