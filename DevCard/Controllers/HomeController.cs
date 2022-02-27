using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using DevCard.Data;

namespace DevCard.Controllers
{
    //[Route("/arash/products")]
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>()
        {
            new Service(1, "برنزه ای"),
            new Service(2, "نقره ای"),
            new Service(3, "طلایی"),
            new Service(4, "پلاتینی"),
            new Service(5, "زمردی")
        };

        //[Route("MyIndex/{name}/{model}")]
        // localhost:5001/arash/site/MyIndex
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {
            var project = ProjectData.GetProjectBy(id);
            return View(project);
        }

        public IActionResult ArticleDetails(long id)
        {
            var article = LatestArticlesData.GetArticleBy(id);
            return View(article);
        }

        [HttpGet]
        //[Route("ContactPage/{id?}")]
        // localhost:5001/arash/site/ContactPage
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            //if(ModelState.IsValid == false)
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست! لطفا دوباره تلاش کنید.";
                return View(model);
            }

            ModelState.Clear();

            model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ارسال شد!";
            return View(model);
            //return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
