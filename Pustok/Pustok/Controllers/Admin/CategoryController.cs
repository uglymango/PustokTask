using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pustok.Database;
using System.Linq;

namespace Pustok.Controllers.Admin
{
    [Route("admin/categories")]

    public class CategoryController : Controller
    {

        private readonly PustokDbContext _pustokDbContext;
        private readonly ILogger<ProductController> _logger;

        public CategoryController(PustokDbContext pustokDbContext)
        {
            _pustokDbContext = pustokDbContext;
        }

        public IActionResult Categories()
        {
            var categories = _pustokDbContext.Categories.ToList();

            return View("Views/Admin/Category/Categories.cshtml", categories);
        }
    }
}
