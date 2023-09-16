using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Shipment
    {
        public int shipmentID { get; set; }

        public string shipmentName { get; set; }

        public string shipmentDispatch {get; set; }

        public string shipmentTransportation { get; set; }  

        public string shipmentDistance { get; set; }

        public decimal shipmentSum { get; set; }
        
        public int vehicleID { get; set; }
    }
}
