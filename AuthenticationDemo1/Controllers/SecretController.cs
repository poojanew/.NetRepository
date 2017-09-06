using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationDemo1.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        public ContentResult Secret()
        {
            return Content("Secret informations here");
        }
        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Public informations here");
        }

    }
}