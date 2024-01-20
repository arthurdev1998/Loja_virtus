using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Context.Repositories.Categories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category?> GetById(int id);
    Task InsertAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    void Delete(Category category);
}