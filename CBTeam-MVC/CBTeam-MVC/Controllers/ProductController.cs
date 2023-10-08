using CBTeam_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using ProductService;

namespace CBTeam_MVC.Controllers
{
    [Route("Products")]
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            Product product = new Product
            {
                Name = "Fernet",
                Description = "Fernet Branca",
                Stock = 30,
                Price = 2300,
            };

            return View(product);
        }

        [Route("GetFromService")]
        public async Task<IActionResult> GetFromService()
        {
            List<Product> products = new List<Product>();
            var productService = new ProductClient();

            var productList = await productService.GetProductsAsync();

            foreach (var product in productList)
            {
                products.Add(new Product
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock =product.Stock,
                });
            }

            return View("ProductsFromService", products);
        }
    }
}
