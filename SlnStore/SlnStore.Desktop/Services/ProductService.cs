using SlnStore.Desktop.Interfaces;
using SlnStore.Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnStore.Desktop.Services
{
    public class ProductService : IProductService
    {
        private readonly ModelStoreContext _dbContext;

        public ProductService()
        {
            _dbContext = new ModelStoreContext();
        }

        public List<Product> ObtenerAllProduct()
        {
            return _dbContext.Product.ToList();
        }

        public Product ObtenerProductId(int idProduct)
        {
            return _dbContext.Product.Find(idProduct);
        }

        public void CreateProduct(Product newProduct)
        {
            _dbContext.Product.Add(newProduct);
            _dbContext.SaveChanges();
        }

        public void updateProduct(Product modelProduct)
        {
            Product pro = _dbContext.Product.Find(modelProduct.IdProduct);

            pro.NameProduct = modelProduct.NameProduct;
            pro.PriceUnit = modelProduct.PriceUnit;
            pro.Stock = modelProduct.Stock;
            pro.ExpirationDate = DateTime.Now;
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int idProduct)
        {
            var Produc = _dbContext.Product.Find(idProduct);
            _dbContext.Product.Remove(Produc);
            _dbContext.SaveChanges();
        }
    }
}
