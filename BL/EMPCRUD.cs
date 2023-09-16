using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class EMPCRUD
    {
        public static DataTable Listele1()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EmployeeList", Tools.baglanti);
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public static bool Add1(Employee emp) 
        { 
            SqlCommand sqlCommand = new SqlCommand("EmployeeAdd", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@NameSurname", emp.NameSurname);
            sqlCommand.Parameters.AddWithValue("@employeeDuty", emp.employeeDuty);
            sqlCommand.Parameters.AddWithValue("@employeeTitle", emp.employeeTitle);
            sqlCommand.Parameters.AddWithValue("@employeePhone", emp.employeePhone);
            sqlCommand.Parameters.AddWithValue("@employeeMail", emp.employeeMail);
            sqlCommand.Parameters.AddWithValue("@employeeWage", emp.employeeWage);
            sqlCommand.Parameters.AddWithValue("@shipmentID", emp.shipmentID);
            return Tools.CoonectSet(sqlCommand);
        }

        public static bool Update1(Employee emp) 
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeUp", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@employeeID", emp.employeeID);
            sqlCommand.Parameters.AddWithValue("@NameSurname", emp.NameSurname);
            sqlCommand.Parameters.AddWithValue("@employeeDuty", emp.employeeDuty);
            sqlCommand.Parameters.AddWithValue("@employeeTitle", emp.employeeTitle);
            sqlCommand.Parameters.AddWithValue("@employeePhone", emp.employeePhone);
            sqlCommand.Parameters.AddWithValue("@employeeMail", emp.employeeMail);
            sqlCommand.Parameters.AddWithValue("@employeeWage", emp.employeeWage);
            sqlCommand.Parameters.AddWithValue("@shipmentID", emp.shipmentID);
            return Tools.CoonectSet(sqlCommand);

        }
        public static bool Delete1(Employee emp) 
        {
            SqlCommand sqlCommand = new SqlCommand("EmployeeDel", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@employeeID", emp.employeeID);
            return Tools.CoonectSet(sqlCommand);

        }


    }
}
