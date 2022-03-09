using System.Web.Mvc;
using System.Web.Routing;

namespace practice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "kuchbhi",
                url: "insert",
                defaults: new { controller = "Home", action = "insert"}
            );

            routes.MapRoute(
                name: "kuchbhi2",
                url: "display",
                defaults: new { controller = "Home", action = "Display" }
            );

            routes.MapRoute(
                name: "kuchbhi3",
                url: "display/GetEdit",
                defaults: new { controller = "Home", action = "GetEdit" }
            );

            routes.MapRoute(
                name: "kuchbhi4",
                url: "display/EditSubmit",
                defaults: new { controller = "Home", action = "EditSubmit" }
            );

            routes.MapRoute(
                name: "kuchbhi5",
                url: "submit",
                defaults: new { controller = "Home", action = "insertSubmit" }
            );

            routes.MapRoute(
               name: "kuchbhi6",
               url: "delete",
               defaults: new { controller = "Home", action = "delete" }
           );


            routes.MapRoute(
               name: "kuchbhi7",
               url: "table",
               defaults: new { controller = "Home", action = "table" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
