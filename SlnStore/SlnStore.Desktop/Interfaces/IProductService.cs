using SlnStore.Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnStore.Desktop.Interfaces
{
    public interface IProductService
    {
        List<Product> ObtenerAllProduct();

        void CreateProduct(Product newProduct);

        Product ObtenerProductId(int idProduct);

        void updateProduct(Product modelProduct);

        void DeleteProduct(int idProduct);
    }
}
