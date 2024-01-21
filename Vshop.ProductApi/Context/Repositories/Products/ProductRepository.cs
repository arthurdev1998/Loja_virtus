using Microsoft.EntityFrameworkCore;
using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Context.Repositories.Products;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _db;

    public ProductRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task Create(Product product)
    {
        await _db.Products.AddAsync(product);
        await _db.SaveChangesAsync();
    }

    public void Delete(Product product)
    {
        _db.Products.Remove(product);
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _db.Products.OrderBy(x => x.Id).ToListAsync();
    }

    public async Task<Product?> GetById(int id)
    {
        return await _db.Products.OrderBy(x => x.Id).SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Product> Update(Product product)
    {
        _db.Entry(product).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return product;
    }
}