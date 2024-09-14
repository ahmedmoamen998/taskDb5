using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5Db.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double price { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Sale> salesProduct { get; set; } = new List<Sale>();
    }
}
