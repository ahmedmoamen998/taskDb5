using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5Db.Models
{
    public class Sale
    {
//        •	Product
//•	Customer
//•	Store

        public int SaleId{ get; set; }
        public int Product { get; set; }
        public int Customer { get; set; }
        public int Store { get; set; }
        public DateTime DateTime { get; set; }
        public Customer custId { get; set; } = null!;
        public Store StoreId { get; set; } = null!;
        public Product ProductId { get; set; } = null!;


    }
}
