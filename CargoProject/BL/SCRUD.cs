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
    public class SCRUD
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("shipmentList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Add(ShipmentClass ShipmentClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("shipmentAdd", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@shipmentName", ShipmentClass.shipmentName);
            sqlCommand.Parameters.AddWithValue("@dispatchPoint", ShipmentClass.dispatchPoint);
            sqlCommand.Parameters.AddWithValue("@transportationPoint", ShipmentClass.transportationPoint);
            sqlCommand.Parameters.AddWithValue("@distance", ShipmentClass.distance);
            sqlCommand.Parameters.AddWithValue("@price", ShipmentClass.price);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Update(ShipmentClass ShipmentClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("shipmentUpdate", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@shipmentNo", ShipmentClass.shipmentNo);
            sqlCommand.Parameters.AddWithValue("@shipmentName", ShipmentClass.shipmentName);
            sqlCommand.Parameters.AddWithValue("@dispatchPoint", ShipmentClass.dispatchPoint);
            sqlCommand.Parameters.AddWithValue("@transportationPoint", ShipmentClass.transportationPoint);
            sqlCommand.Parameters.AddWithValue("@distance", ShipmentClass.distance);
            sqlCommand.Parameters.AddWithValue("@price", ShipmentClass.price);
            return Tools.ConnectSet(sqlCommand);
        }
        public static bool Delete(ShipmentClass ShipmentClass)
        {
            //ilk olarak arayüze gitti textler verileri aldı generation içerisinde atadı daha sonra o degerler add methoduna paramtere  olarak geldi 
            SqlCommand sqlCommand = new SqlCommand("shipmentDel", Tools.baglanti);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@shipmentNo", ShipmentClass.shipmentNo);
            return Tools.ConnectSet(sqlCommand);
        }
    }
}
