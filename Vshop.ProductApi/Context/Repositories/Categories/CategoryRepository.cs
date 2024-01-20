using Microsoft.EntityFrameworkCore;
using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Context.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db)
        {
            _db = db;
        }
        public void Delete(Category category)
        {
            _db.Categories.Remove(category);
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _db.Categories.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<Category?> GetById(int id)
        {
            return await _db.Categories.OrderBy(x => x.Id).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(Category category)
        {
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _db.Entry(category).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return category;
        }
    }
}