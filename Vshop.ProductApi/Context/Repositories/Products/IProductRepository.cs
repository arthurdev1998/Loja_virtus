using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Context.Repositories.Products;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product?> GetById(int id);
    Task Create(Product product);
    Task<Product> Update(Product product);
    void Delete(Product product);
}