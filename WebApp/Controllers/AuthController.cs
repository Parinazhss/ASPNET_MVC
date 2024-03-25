using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel); // Returnera vyn med viewModel
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)

    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        return RedirectToAction("SignIn","Auth");
    }


    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel); // Returnera vyn med viewModel
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)

    {
        if (!ModelState.IsValid)
        
          return View(viewModel);
        



        viewModel.ErrorMessage = "Incorecct email or password";
        return View(viewModel);
    }
}




