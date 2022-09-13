using Microsoft.AspNetCore.Mvc;
using Mvc.ViewModels;

namespace Mvc.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    private static List<Product>? products = new();

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult AddProduct() => View();

    [HttpPost]
    public IActionResult AddProduct(Product model)
    {
        if(!ModelState.IsValid) return View(model);
        _logger.LogInformation("Post bo'ldi");
        products!.Add(model);
        return RedirectToAction("AllProducts");
    }

    public IActionResult AllProducts() => View(products);
}