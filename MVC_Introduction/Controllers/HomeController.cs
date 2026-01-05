using Microsoft.AspNetCore.Mvc;
using MVC_Introduction.Models;

namespace MVC_Introduction.Controllers
{
    public class HomeController : Controller
    {
       //public string Index (){

       //     return "Anasayfa";
       //}
       public IActionResult Index() 
       {
            List<string> list= new List<string>
            {
                "Data1","data2","data3"
            };
            return View(list);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel contactModel)
        {
            return View();
        }
    }
}
