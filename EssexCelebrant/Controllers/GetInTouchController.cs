using EssexCelebrant.Models;
using EssexCelebrant.Models.GetInTouch;
using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class GetInTouchController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendTheMessage(GetInTouch model)
        {
            string msg = $"{model.Name} has sent the following message.<br /><br /> Their email address is: {model.Email}.<br /><br />  The message reads:<br /> " + model.Message;
            Helper.SendEmail(Helper.AppSetting("Email.ToAddress"), "Get in Touch", msg, string.Empty);

            return Json("test", JsonRequestBehavior.AllowGet);
        }
    }
}