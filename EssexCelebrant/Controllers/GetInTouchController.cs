using EssexCelebrant.Models;
using EssexCelebrant.Models.GetInTouch;
using System.Text;
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
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrEmpty(model.Name))
            {
                errorMessage.Append("Please enter your name <br/>");
            }

            if (string.IsNullOrEmpty(model.Email))
            {
                errorMessage.Append("Please enter an email address<br />");
            }

            if (string.IsNullOrEmpty(model.Message))
            {
                errorMessage.Append("Please enter a message");
            }

            var success = false;
            if (errorMessage.Length == 0)
            {
                success = true;
                string msg = $"{model.Name} has sent the following message.<br /><br /> Their email address is: {model.Email}.<br /><br />  The message reads:<br /> " + model.Message;
                var result = Helper.SendEmail(Helper.AppSetting("Email.ToAddress"), "Get in Touch", msg, string.Empty);

                if (!string.IsNullOrEmpty(result))
                    success = false;

                return Json(new { success, errorMsg = result }, JsonRequestBehavior.AllowGet);
            }

            var errorMsg = errorMessage.ToString();
            return Json(new { success, errorMsg }, JsonRequestBehavior.AllowGet);
        }
    }
}