using ConsumeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumeApi.Controllers
{
    public class HomeController : Controller
    {
        private PostcodesApi _postcodesApi;

        public HomeController(PostcodesApi postcodesApi)
        {
            _postcodesApi = postcodesApi;
        }
        public ActionResult Index()
        {        
            ViewData["constituency"] = _postcodesApi.GetParliamentaryConstituency("ne46ap");
            return View();
        }

    }
}