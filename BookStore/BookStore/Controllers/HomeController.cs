using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            ViewBag.title = "QWE";

            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Nitish";

            ViewBag.Data = data;

            ViewData["book"] = new BookModel()
            {
                Id = 003,
                Author = "new",
                Description = "fdf"
            };

            //view data attributes
            CustomProperty = "Custom Value";
            Title = "Home from Controller";


            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
