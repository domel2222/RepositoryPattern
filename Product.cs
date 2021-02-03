using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class Product
    {
       public string ProductId { get; set; }
       public string ProductName { get; set; }
       public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
