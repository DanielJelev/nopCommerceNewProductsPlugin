using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using Nop.Core.Plugins;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Widgets.NewProducts
{
    [AdminAuthorize]
    public class NewProductsPlugin : BasePlugin, IWidgetPlugin
    {


        public IList<string> GetWidgetZones()
        {
            return new List<string>() { "home_page_before_products" };
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName,
            out RouteValueDictionary routeValues)
        {
            actionName = "NewProducts";
            controllerName = "WidgetsNewProducts";
            routeValues = new RouteValueDictionary
            {
                {"Namespaces", "Nop.Plugin.Widgets.NewProducts.Controllers"},
                {"area", null},
                {"widgetZone", widgetZone}
            };
        }

        public void GetConfigurationRoute(out string actionName, out string controllerName,
            out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "WidgetsNewProducts";
            routeValues = new RouteValueDictionary()
            {
                { "Namespaces", "Nop.Plugin.Widgets.NewProducts.Controllers" },
                { "area", null }
            };
        }
    }
}