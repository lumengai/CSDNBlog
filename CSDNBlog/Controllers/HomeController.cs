using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSDNBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 博客
        /// </summary>
        /// <returns></returns>
        public ActionResult Blog()
        {
            return View();
        }

        /// <summary>
        /// 学院 
        /// </summary>
        /// <returns></returns>
        public ActionResult College()
        {
            return View();
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <returns></returns>
        public ActionResult Download()
        {
            return View();
        }

    }
}
