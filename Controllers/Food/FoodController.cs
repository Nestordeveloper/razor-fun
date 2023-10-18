using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class FoodController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        List<string> StringList = new List<string>() { "Apple Pie", "Pizza", "Cinnamon Rolls", "Lasagna", "Donuts", "Chocolate Cake", "Burritos" };
        return View(StringList);
    }
}
