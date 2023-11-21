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
    public class CUCRUD
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("customerList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add(CustomerClass CustomerClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("customerAdd", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@nameSurname", CustomerClass.nameSurname);
            sqlCommand.Parameters.AddWithValue("@address", CustomerClass.address);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", CustomerClass.phoneNumber);
            sqlCommand.Parameters.AddWithValue("@mail", CustomerClass.mail);
            sqlCommand.Parameters.AddWithValue("@paymentStatus", CustomerClass.paymentStatus);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Update(CustomerClass CustomerClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("customerUpdate", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@customerNo", CustomerClass.customerNo);
            sqlCommand.Parameters.AddWithValue("@nameSurname", CustomerClass.nameSurname);
            sqlCommand.Parameters.AddWithValue("@address", CustomerClass.address);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", CustomerClass.phoneNumber);
            sqlCommand.Parameters.AddWithValue("@mail", CustomerClass.mail);
            sqlCommand.Parameters.AddWithValue("@paymentStatus", CustomerClass.paymentStatus);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(CustomerClass CustomerClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("customerDel", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@customerNo", CustomerClass.customerNo);
            return Tools.ConnectSet(sqlCommand);
        }
    }
}
