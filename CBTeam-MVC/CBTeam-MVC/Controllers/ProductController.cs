using CBTeam_MVC.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
