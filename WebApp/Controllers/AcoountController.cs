using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AcoountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
