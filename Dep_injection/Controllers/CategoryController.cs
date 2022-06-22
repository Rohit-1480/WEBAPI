using Microsoft.AspNetCore.Mvc;

namespace Dep_injection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        [HttpGet]
        //[Route("GetCat")]

        public async Task<IActionResult> GetCat()
        {
            try
            {
                CategoryRepository cr = new CategoryRepository();
                List<Category> categories = new List<Category>();
                categories = cr.GetCategories();
                return Ok(categories);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

    }


}
