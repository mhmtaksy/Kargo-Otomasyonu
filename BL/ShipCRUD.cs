using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class ShipCRUD
    {
        public static DataTable Listele2() 
        { 
            SqlDataAdapter adapter = new SqlDataAdapter("ShipmentList",Tools.baglanti);
            adapter.SelectCommand.CommandType= System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static bool Add2(Shipment ship) 
        {
            SqlCommand sqlCommand = new SqlCommand("ShipmentAdd",Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("shipmentName", ship.shipmentName);
            sqlCommand.Parameters.AddWithValue("shipmentDispatch", ship.shipmentDispatch);
            sqlCommand.Parameters.AddWithValue("shipmentTransportation", ship.shipmentTransportation);
            sqlCommand.Parameters.AddWithValue("shipmentDistance", ship.shipmentDistance);
            sqlCommand.Parameters.AddWithValue("shipmentSum", ship.shipmentSum);
            sqlCommand.Parameters.AddWithValue("vehicleID", ship.vehicleID);
            return Tools.CoonectSet(sqlCommand);

        }
        public static bool Update2(Shipment ship) 
        {
            SqlCommand sqlCommand = new SqlCommand("ShipmentUp", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("shipmentID", ship.shipmentID);
            sqlCommand.Parameters.AddWithValue("shipmentName", ship.shipmentName);
            sqlCommand.Parameters.AddWithValue("shipmentDispatch", ship.shipmentDispatch);
            sqlCommand.Parameters.AddWithValue("shipmentTransportation", ship.shipmentTransportation);
            sqlCommand.Parameters.AddWithValue("shipmentDistance", ship.shipmentDistance);
            sqlCommand.Parameters.AddWithValue("shipmentSum", ship.shipmentSum);
            sqlCommand.Parameters.AddWithValue("vehicleID", ship.vehicleID);
            return Tools.CoonectSet(sqlCommand);
        }
        public static bool Delete2(Shipment ship) 
        {
            SqlCommand sqlCommand = new SqlCommand("ShipmentUp", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("shipmentID", ship.shipmentID);
            return Tools.CoonectSet(sqlCommand);
        }

    }
}
