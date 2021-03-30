using MVC_Model_Tutorial.Models;
using System.Web.Mvc;

namespace MVC_Model_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Example 1
            //List<string> names = new List<string>
            //{
            //    "Adam",
            //    "Brett",
            //    "Carter"
            //};

            //return View(names);

            //Example 2
            //int number = 5;

            //return View(number);

            //EXAMPLE 3 -- creating a model file
            User user = new User();
            user.Id = 1;
            user.Fname = "Bob";
            user.Lname = "Jackson";
            user.Age = 57;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}