using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NardnobCrafts.Models;
using NardnobCrafts.Services;

namespace NardnobCrafts.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService ProductService { get; private set; }

        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        //[HttpPost]
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string productId,
            [FromQuery] int rating)
        {
            ProductService.AddRating(productId, rating);
            return Ok();
        }
    }
}
