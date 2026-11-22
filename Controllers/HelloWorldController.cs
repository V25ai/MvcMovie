using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public int Add (int a, int b)
    { return a + b; }
        
    //public string Welcome(string name, int numtimes = 1)
    //{
      //  return HtmlEncoder.Default.Encode
      //     ($"Hello {name}, NumTime is:{numtimes}");
    //}
    public string ByeBye()
    {
        return "SeeYouTmorrow:)";
    }
}