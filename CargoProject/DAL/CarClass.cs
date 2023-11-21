using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarClass
    {
        public int carNo { get; set; }
        public string carModelname { get; set; }
        public int carCapacity { get; set; }
        public string carDriver { get; set; }
        public decimal carExpense { get; set; }

    }
}
