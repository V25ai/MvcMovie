using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    //public int Add (int a, int b)
    //{ return a + b; }
        
    public IActionResult Welcome(string name, int numtimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numtimes;

        return View();
    }
    public string ByeBye()
    {
        return "SeeYouTmorrow:)";
    }
}