using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore22Intro.Controllers
{
    [Route("[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public ContentResult Name()
        {
            return Content("Björn");
        }
        public ContentResult Country()
        {
            return Content("Sweden");
        }
        public ContentResult Index()
        {
            return Content("Hello from Employee");
        }
    }
}
