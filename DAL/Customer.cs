using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer
    {
        public int customerID { get; set; }
        public string NameSurname { get; set; }
        public string Adress { get; set; }

        public string Phone { get; set; }
        public string Mail { get; set; }
        public string PaymentSituation { get; set; }

        public int employeeID {get; set; }
    }
}
