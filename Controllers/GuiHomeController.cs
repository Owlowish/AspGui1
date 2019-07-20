using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AspGui1.Controllers
{
    public class GuiHomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}