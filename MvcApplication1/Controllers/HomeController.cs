using MvcApplication1.SqlAcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            var shops = ShopAcessor.SelShops();
            return View(shops);
        }
    }
}
