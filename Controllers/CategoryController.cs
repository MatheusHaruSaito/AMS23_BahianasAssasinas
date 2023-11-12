using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_Carousel.Models;
using AMS23_Carousel.Data;
using AMS23_Carousel.Models.Category;


namespace AMS23_Carousel.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    public readonly ICategoryRepository _categoryRepository;

    public CategoryController(ILogger<CategoryController> logger, ICategoryRepository categoryRepository)
    {
        _logger = logger;
        _categoryRepository = categoryRepository;
    }
    public IActionResult AddCat(CategoryModel category)
    {
        _categoryRepository.Add(category);
        _categoryRepository.SaveChangesAsync();
        return View();
    }
    public IActionResult Add()
    {
        return View();
    }
 
    public IActionResult Index()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
