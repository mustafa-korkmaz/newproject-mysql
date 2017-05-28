using System.Web.Mvc;
using System.Web.Routing;

namespace WebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "NewEmailVerification",                                           // Route name
                "NewEmailVerification",                            // URL with parameters
                new { controller = "User", action = "NewEmailVerification" }  // Parameter defaults
            );

            routes.MapRoute(
                "AddNewDbMigration",                                           // Route name
                "AddNewDbMigration",                            // URL with parameters
                new { controller = "Home", action = "AddNewDbMigration" }  // Parameter defaults
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{parameter}",
                defaults: new { controller = "Home", action = "Index", parameter = UrlParameter.Optional }
            );
        }
    }
}
