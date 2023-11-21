using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BL
{
    public class ECRUD
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("employeeList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add(EmployeeClass EmployeeClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("employeeAdd", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@nameSurname", EmployeeClass.nameSurname);
            sqlCommand.Parameters.AddWithValue("@task", EmployeeClass.task);
            sqlCommand.Parameters.AddWithValue("@title", EmployeeClass.title);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", EmployeeClass.phoneNumber);
            sqlCommand.Parameters.AddWithValue("@mail", EmployeeClass.mail);
            sqlCommand.Parameters.AddWithValue("@salary", EmployeeClass.salary);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Update(EmployeeClass EmployeeClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("employeeUpdate", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@employeeNo", EmployeeClass.employeeNo);
            sqlCommand.Parameters.AddWithValue("@nameSurname", EmployeeClass.nameSurname);
            sqlCommand.Parameters.AddWithValue("@task", EmployeeClass.task);
            sqlCommand.Parameters.AddWithValue("@title", EmployeeClass.title);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", EmployeeClass.phoneNumber);
            sqlCommand.Parameters.AddWithValue("@mail", EmployeeClass.mail);
            sqlCommand.Parameters.AddWithValue("@salary", EmployeeClass.salary);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(EmployeeClass EmployeeClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("employeeDel", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@employeeNo", EmployeeClass.employeeNo);
            return Tools.ConnectSet(sqlCommand);
        }
    }
}
