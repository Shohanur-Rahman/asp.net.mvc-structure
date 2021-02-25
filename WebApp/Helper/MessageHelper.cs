using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Helper
{
    public class MessageHelper
    {
        public static string SuccessMeesage(Controller controller, bool isSet, string message)
        {
            if (isSet == true)
                controller.TempData["SuccessMessage"] = message;
            else
                return controller.TempData["SuccessMessage"] != null ? controller.TempData["SuccessMessage"].ToString() : null;

            return null;
        }
    }
}