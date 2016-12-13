using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impact.Mvc.Controllers
{
    public class RssController : Controller
    {
        // GET: Rss
        public ActionResult GetRssFeeds()
        {
            return View(Impact.Mvc.RSSHelper.RssHelper.GetRssFeed());
        }
    }
}