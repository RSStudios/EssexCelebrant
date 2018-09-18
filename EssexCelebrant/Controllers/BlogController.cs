using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;

namespace EssexCelebrant.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            string url = "http://snowprints.blogspot.com/feeds/posts/default";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                string subject = item.Title.Text;
                string summary = item.Summary.Text;
            }
            return View();
        }
    }
}