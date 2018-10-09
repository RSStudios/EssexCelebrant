using EssexCelebrant.Models;
using EssexCelebrant.Models.Blog;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace EssexCelebrant.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            var blogUrl = Helper.AppSetting("BlogUrl");
            XmlReader reader = XmlReader.Create(Helper.AppSetting("BlogRssFeedUrl"));
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            List<BlogPost> blogPosts = new List<BlogPost>();

            foreach (SyndicationItem item in feed.Items)
            {
                var post = new BlogPost()
                {
                    Link = blogUrl + item.Links[1].Uri.AbsolutePath,
                    Title = item.Title.Text
                };

                if (item.ElementExtensions.Where(p => p.OuterName == "thumbnail").Count() != 0)
                    post.Image = item.ElementExtensions.Where(p => p.OuterName == "thumbnail").First().GetObject<XElement>().Attribute("url").Value;

                if (item.Summary != null)
                    post.Summary = item.Summary.Text;

                blogPosts.Add(post);
            }

            return View(blogPosts);
        }
    }
}