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

        public HomeController()
        {
            _postcodesApi = new PostcodesApi();
        }

        public ActionResult Index()
        {        
            ViewData["constituency"] = _postcodesApi.GetParliamentaryConstituency("m147th");
            ViewData["ccg"] = _postcodesApi.GetClinicalCommissioningGroup("rm109yz");
            return View();
        }

    }
}