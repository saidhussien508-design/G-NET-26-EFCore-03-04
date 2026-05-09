using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
    #region manger
    public  class Manger
    {
        public int mangerid { get; set; }
        public string FullName { get; set;}

        public string Email { get; set;}
        public int phoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public branch branch { get; set; }
    }
    #endregion
}
