using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Services.Products;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllCategoriesAsync();
    Task<Product?> GetByIdCategory(int id);
    Task InsertCategoryAsync(Product product);
    Task<Product> UpdateCategoryAsync(Product product);
    void Delete(int Id);
}