using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;

namespace eCommerceFLANCO.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        private void RegisterBundles()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            RegisterBundles();

            context.Routes.MapHttpRoute(
                "Admin_Secondary",
                "admin/api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            ); 

            context.MapRoute(
                "Admin",
                "admin",
                new { controller = "Admin", action = "Index" }
            );

            context.MapRoute(
                "Admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}