using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Format.Applibs;

namespace Format.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string mail, string tel, string message)
        {
            string title = "Format 系統聯繫";
            string mailbody = "姓名:" + name +
                              "<br /> E-mail:" + mail +
                              "<br /> 電話:" + tel +
                              "<br /> 訊息內容:" + message;

            CommonUtility.SendEmail(title, mailbody);

            return View();
        }
    }
}
