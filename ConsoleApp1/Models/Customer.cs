using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5Db.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public string email { get; set; }   
        
        public string CreaditCardNumber { get; set; }


        public virtual ICollection<Sale> salesCustomer { get; set; } = new List<Sale>();


    }
}
