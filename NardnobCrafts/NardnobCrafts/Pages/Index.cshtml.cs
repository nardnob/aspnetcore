using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NardnobCrafts.Models;
using NardnobCrafts.Services;

namespace NardnobCrafts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly JsonFileProductService _productService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public void OnGet()
        {
            Products = _productService.GetProducts();
        }
    }
}