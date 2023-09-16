using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class VEHCRUD
    {
        public static DataTable Listele3()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("VehicleList", Tools.baglanti);
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;


        }

        public static bool Add3(Vehicle veh)
        {
            SqlCommand cmd = new SqlCommand("VehicleAdd", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("vehicleName", veh.vehicleName);
            cmd.Parameters.AddWithValue("vehicleCapacity", veh.vehicleCapacity);
            cmd.Parameters.AddWithValue("vehicleDriver", veh.vehicleDriver);
            cmd.Parameters.AddWithValue("vehicleExpense", veh.vehicleExpense);
            return Tools.CoonectSet(cmd);
        }

        public static bool Update3(Vehicle veh)
        {
            SqlCommand cmd = new SqlCommand("VehicleUp", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("vehicleID", veh.vehicleID);
            cmd.Parameters.AddWithValue("vehicleName", veh.vehicleName);
            cmd.Parameters.AddWithValue("vehicleCapacity", veh.vehicleCapacity);
            cmd.Parameters.AddWithValue("vehicleDriver", veh.vehicleDriver);
            cmd.Parameters.AddWithValue("vehicleExpense", veh.vehicleExpense);
            return Tools.CoonectSet(cmd);
        }
        public static bool Delete3(Vehicle veh)
        {
            SqlCommand cmd = new SqlCommand("VehicleDel", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("vehicleID", veh.vehicleID);
            return Tools.CoonectSet(cmd);
        }


    }
}
