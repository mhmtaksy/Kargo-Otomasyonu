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
    public class CUSTCRUDS
    {
        public static DataTable Listele() 
        {
            SqlDataAdapter adapter = new SqlDataAdapter("CustomerList",Tools.baglanti);
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public static bool Add(Customer customer) 
        { 
            SqlCommand sqlCommand = new SqlCommand("CustomerAdd",Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@NameSurname", customer.NameSurname);
            sqlCommand.Parameters.AddWithValue("@Adress", customer.Adress);
            sqlCommand.Parameters.AddWithValue("@Phone", customer.Phone);
            sqlCommand.Parameters.AddWithValue("@Mail", customer.Mail);
            sqlCommand.Parameters.AddWithValue("@PaymentSituation", customer.PaymentSituation);
            sqlCommand.Parameters.AddWithValue("@employeeID", customer.employeeID);
            return Tools.CoonectSet(sqlCommand);
        }
        public static bool Update(Customer customer) 
        {
            SqlCommand sqlCommand = new SqlCommand("CustomerUp", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@customerID", customer.customerID);
            sqlCommand.Parameters.AddWithValue("@NameSurname", customer.NameSurname);
            sqlCommand.Parameters.AddWithValue("@Adress", customer.Adress);
            sqlCommand.Parameters.AddWithValue("@Phone", customer.Phone);
            sqlCommand.Parameters.AddWithValue("@Mail", customer.Mail);
            sqlCommand.Parameters.AddWithValue("@PaymentSituation", customer.PaymentSituation);
            sqlCommand.Parameters.AddWithValue("@employeeID", customer.employeeID);
            return Tools.CoonectSet(sqlCommand);
        }

        public static bool Delete(Customer customer) 
        {
            SqlCommand sqlCommand = new SqlCommand("CustomerDel", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@customerID", customer.customerID);
            return Tools.CoonectSet(sqlCommand);
        }








    }
}
