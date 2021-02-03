using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProduct();

        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(Product product);
    }
}
