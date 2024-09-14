using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5Db.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sale> salesStore { get; set; } = new List<Sale>();
    }
}
