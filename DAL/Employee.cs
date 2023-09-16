using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public int employeeID {get;set;}

        public string NameSurname { get;set;}

        public string employeeDuty { get; set; }

        public string employeeTitle { get; set; }
        public string employeePhone { get; set; }

        public string employeeMail { get; set; }

        public decimal employeeWage { get; set; }

        public int shipmentID { get; set; }

    }
}
