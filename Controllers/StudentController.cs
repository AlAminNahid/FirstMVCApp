using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {   
        ViewBag.Title = "Student List";
        ViewData["SubTitle"] = "Enrolled Students this semester";

        var students = new List<string>
        {
            "Al Amin", "Noor", "Ferdus", "Trishan"
        };
        
        return View(students);
    }

    public IActionResult Details(int id)
    {
        ViewBag.StudentID = id;
        return View();
    }

    public IActionResult About()
    {
        return Content("This is the Student Module");
    }
}