using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        [HttpGet]
        public ActionResult Index()
        {
            BlogDataEntity entity = new BlogDataEntity();
            return View(from BlogData in entity.blogs select BlogData);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            BlogDataEntity entity = new BlogDataEntity();
            var blog = (from BlogData in entity.blogs.Where(b => b.id == id) select BlogData).FirstOrDefault();
            return View(blog);
        }
    }
}