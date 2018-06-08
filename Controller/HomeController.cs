using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace KaspersBurger.Controller
{
    public class HomeController : SurfaceController
    {
        private const string partialPath = "~/Views/Partials/Home/";

        public ActionResult RenderSpecials()
        {
            return PartialView(partialPath + "_Specials.cshtml");
        }

        public ActionResult RenderAbout()
        {
            return PartialView(partialPath + "_About.cshtml");
        }

        public ActionResult RenderMenu()
        {
            return PartialView(partialPath + "_Menu.cshtml");
        }

        public ActionResult RenderGallery()
        {
            return PartialView(partialPath + "_Gallery.cshtml");
        }

        public ActionResult RenderChef()
        {
            return PartialView(partialPath + "_Chef.cshtml");
        }

        public ActionResult RenderContact()
        {
            return PartialView(partialPath + "_Contact.cshtml");
        }
    }
}