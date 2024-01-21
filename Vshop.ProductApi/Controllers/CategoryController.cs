using Microsoft.AspNetCore.Mvc;
using Vshop.ProductApi.Models;
using Vshop.ProductApi.Services.Categories;

namespace Vshop.ProductApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    [HttpGet]
    [ProducesResponseType(typeof(Category[]), 200)]
    public async Task<ActionResult<IEnumerable<Category>>> GetallCategories()
    {
        var categories = await _categoryService.GetAllCategoriesAsync();
        if (categories != null)
        {
            return Ok(categories);
        }

        return NotFound("Não há registros de categorias");
    }

    [HttpDelete]
    public ActionResult Delete()
    {
        return Ok();
    }
}