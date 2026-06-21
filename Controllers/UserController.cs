using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers;

[Route("user")]
public class UserController : Controller
{
    [Route("home")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("login")]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [Route("login")]
    public IActionResult Login(UserModel user)
    {
        ViewBag.username = user.username;
        ViewBag.email = user.email;
        ViewBag.password = user.password;
        return View();
    }

    [HttpGet]
    [Route("registration")]
    public IActionResult Registration()
    {
        return View();
    }

    [HttpPost]
    [Route("registration")]
    public IActionResult Registration(UserModel user)
    {
        ViewBag.username = user.username;
        ViewBag.fullname = user.fullname;
        ViewBag.email = user.email;
        ViewBag.password = user.password;
        return View();
    }
}