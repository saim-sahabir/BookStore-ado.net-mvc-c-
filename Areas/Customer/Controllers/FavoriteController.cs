using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Customer.Controllers;
[Area("Customer")]
public class FavoriteController : Controller
{
    
    private readonly ILogger<FavoriteController> _logger;

    public FavoriteController(ILogger<FavoriteController> logger)
    {
        _logger = logger;
    } 
    // GET
    public IActionResult Index()
    {
        return View();
        
    }

    public IActionResult Add()
    {
        _logger.LogInformation("this is add action");
        return View();
    }

   // public IActionResult Remove()
//    {
        
  //  }
}