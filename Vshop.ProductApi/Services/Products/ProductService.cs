using Vshop.ProductApi.Context.Repositories.Products;
using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Services.Products;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void Delete(int Id)
    {
        var entity = GetByIdCategory(Id);
        _productRepository.Delete(entity.Result);
    }

    public async Task<IEnumerable<Product>> GetAllCategoriesAsync()
    {
        return await _productRepository.GetAll();
    }

    public async Task<Product?> GetByIdCategory(int id)
    {
        return await _productRepository.GetById(id);
    }

    public async Task InsertCategoryAsync(Product product)
    {
        await _productRepository.Create(product);
    }

    public async Task<Product> UpdateCategoryAsync(Product product)
    {
        return await _productRepository.Update(product);
    }
}