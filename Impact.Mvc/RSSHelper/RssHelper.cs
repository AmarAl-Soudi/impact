using Impact.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace Impact.Mvc.RSSHelper
{
    public class RssHelper
    {
        public static IEnumerable<RssModel> GetRssFeed()
        {
            string link = "http://www.dr.dk/nyheder/service/feeds/allenyheder";

            XDocument feedXml = XDocument.Load(link);
            var feeds = from feed in feedXml.Descendants("item")
                        select new RssModel
                        {
                            Title = feed.Element("title").Value,
                            Link = feed.Element("link").Value,
                            Description = Regex.Match(feed.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value
                        };

            return feeds;

        }
    }
}