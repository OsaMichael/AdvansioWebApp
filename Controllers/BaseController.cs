using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AdvanWeb.Controllers.Common.Enum;

namespace AdvanWeb.Controllers
{
    public class BaseController : Controller
    {
        public void Alert(string message, dynamic content, NotificationType notificationType)
        {
            var msg = "<script language='javascript'>swal('" + notificationType.ToString().ToUpper() + "','" + content + "', '" + message + "','" + notificationType + "')" + " </script>";
            TempData["notification"] = msg;

        }
    }
}
