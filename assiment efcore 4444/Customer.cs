using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
# region Customer
    public class Customer
    {
        public int customerid { get; set; } 
        public string fullname { get; set; }
        public DateTime DateofBirth { get; set; }   
        public int Nationalid { get;set; }
        public string Email { get; set; }

        public int phone { get; set; }
        public string Address { get; set; }
        public string type { get; set; }    
    }
    #endregion
}
