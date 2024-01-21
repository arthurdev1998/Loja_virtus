using Vshop.ProductApi.Context.Repositories.Categories;
using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Services.Categories;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void Delete(int Id)
    {
        var entity = GetByIdCategory(Id);
        _categoryRepository.Delete(entity.Result);
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await _categoryRepository.GetAllAsync();
    }

    public async Task<Category?> GetByIdCategory(int id)
    {
        return await _categoryRepository.GetById(id);
    }

    public async Task InsertCategoryAsync(Category category)
    {
        await _categoryRepository.InsertAsync(category);
    }

    public async Task<Category> UpdateCategoryAsync(Category category)
    {
        return await _categoryRepository.UpdateAsync(category);
    }
}