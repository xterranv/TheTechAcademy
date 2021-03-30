using System.Web.Mvc;

namespace MVC_Tutorial1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Log to a file
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"c:\users\xterr\desktop\SAMPLE_LOG.TXT", text);

            //Perform some logic -- example get a random number
            //Random randomNbr = new Random(3);
            //int num = randomNbr.Next();
            //ViewBag.RandomNumber = num;

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //Return Text
            //return Content("HELLOOOO");

            //Return a redirect
            return RedirectToAction("Contact");


            return View();
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