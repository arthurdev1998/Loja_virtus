using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Services.Categories;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync();
    Task<Category?> GetByIdCategory(int id);
    Task InsertCategoryAsync(Category category);
    Task<Category> UpdateCategoryAsync(Category category);
    void Delete(int Id);
}