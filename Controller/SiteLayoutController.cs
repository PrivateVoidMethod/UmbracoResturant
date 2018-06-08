using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace KaspersBurger.Controller
{
    public class SiteLayoutController : SurfaceController
    {
        private const string partialPath = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderHeader()
        {
            return PartialView(partialPath + "_Header.cshtml");
        }
        public ActionResult RenderFooter()
        {
            return PartialView(partialPath + "_Footer.cshtml");
        }
    }
}