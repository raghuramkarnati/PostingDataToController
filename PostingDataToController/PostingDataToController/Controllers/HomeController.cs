using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostingDataToController.Helpers;

namespace PostingDataToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Charles Parker",
                    Email = "abc@xyz.com",
                    PhoneNumber = 11111111,
                    Country = "UK"
                },
                new User
                {
                    Id = 2,
                    Name = "Mark Clifford",
                    Email = "def@xyz.com",
                    PhoneNumber = 2222222,
                    Country = "Australia"
                },
                new User
                {
                    Id = 3,
                    Name = "Jade Edward",
                    Email = "ghi@xyz.com",
                    PhoneNumber = 33333333,
                    Country = "America"
                },
                new User
                {
                    Id = 4,
                    Name = "Martin Robinson",
                    Email = "jkl@xyz.com",
                    PhoneNumber = 44444444,
                    Country = "France"
                },
                new User
                {
                    Id = 5,
                    Name = "Adrian Barker",
                    Email = "mno@xyz.com",
                    PhoneNumber = 55555555,
                    Country = "Egypt"
                }
            };

            return View(users);
        }
    }
}