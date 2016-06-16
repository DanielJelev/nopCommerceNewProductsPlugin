namespace Nop.Plugin.Widgets.NewProducts.Controllers
{
    using System.Web.Mvc;

    using Nop.Core;
    using Nop.Plugin.Widgets.NewProducts.Models;
    using Nop.Services.Catalog;
    using Nop.Services.Configuration;

    using Web.Framework.Controllers;

    [AdminAuthorize]
    public class WidgetsNewProductsController : BasePluginController
    {
    

        public ActionResult Configure()
        {
            var model = new ConfigurationModel();

            return View("~/Plugins/Widgets.NewProducts/Views/WidgetsNewProducts/Configure.cshtml", model);

        }

        public ActionResult NewProducts()
        {

            var model = new object();
           

            return View("~/Plugins/Widgets.NewProducts/Views/WidgetsNewProducts/NewProduct.cshtml", model);

        }

    }
}
