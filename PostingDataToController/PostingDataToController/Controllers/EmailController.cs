using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostingDataToController.Helpers;

namespace PostingDataToController.Controllers
{
    public class EmailController : Controller
    {
        [HttpPost]
        public ActionResult Index(List<User> usersData)
        {
            return Content("Success");
        }
    }
}