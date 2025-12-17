using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateProduct(Product product)
        {
            _manager.Product.Create(product);
            _manager.Save();
        }

        public IEnumerable<Product> GetAllProducts(bool trackchanges)
        {
            return _manager.Product.GetAllProducts(trackchanges);
        }

        public Product? GetOneProduct(int id, bool trackchanges)
        {
            var product = _manager.Product.GetOneProduct(id,trackchanges);
            if(product == null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public void UpdateOneProduct(Product product)
        {
            var entity = _manager.Product.GetOneProduct(product.ProductId,true);
            entity.ProductName = product.ProductName;
            entity.Price = product.Price;
            _manager.Save();
        }
    }
}