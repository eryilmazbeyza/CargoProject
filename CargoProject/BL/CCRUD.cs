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
    public class CCRUD
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("carList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add(CarClass CarClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("carAdd", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@carModelname", CarClass.carModelname);
            sqlCommand.Parameters.AddWithValue("@carCapacity", CarClass.carCapacity);
            sqlCommand.Parameters.AddWithValue("@carDriver", CarClass.carDriver);
            sqlCommand.Parameters.AddWithValue("@carExpense", CarClass.carExpense);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Update(CarClass CarClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("carUpdate", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@carNo", CarClass.carNo);
            sqlCommand.Parameters.AddWithValue("@carModelname", CarClass.carModelname);
            sqlCommand.Parameters.AddWithValue("@carCapacity", CarClass.carCapacity);
            sqlCommand.Parameters.AddWithValue("@carDriver", CarClass.carDriver);
            sqlCommand.Parameters.AddWithValue("@carExpense", CarClass.carExpense);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(CarClass CarClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("carDel", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@carNo", CarClass.carNo);
            return Tools.ConnectSet(sqlCommand);
        }
    }
}
