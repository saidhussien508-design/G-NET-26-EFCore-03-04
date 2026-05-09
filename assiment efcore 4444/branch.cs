using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
    #region branch
    public  class branch
    {
        [Key] 
        public int Branchcoude { get; set; }  
        public string Name { get; set; }


        public string Address { get; set; }

        public string phoneNumber { get; set; }
       
        public Manger Manger { get; set; }
        public int mangerid { get; set; }

        public List<account> accounts { get; set; }

    }
    #endregion
}
