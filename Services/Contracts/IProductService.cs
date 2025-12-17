using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackchanges);
        Product? GetOneProduct(int id,bool trackchanges);
        void CreateProduct(Product product);
        void UpdateOneProduct(Product product);
    }
}