using System.Web;
using System.Web.Optimization;

namespace eCommerceFLANCO
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/Scripts/customs/smoothscroll.js",
                "~/Scripts/customs/jquery.debouncedresize.js",
                "~/Scripts/customs/retina.min.js",
                "~/Scripts/customs/jquery.placeholder.js",
                "~/Scripts/customs/jquery.hoverIntent.min.js",
                "~/Scripts/customs/twitter/jquery.tweet.min.js",
                "~/Scripts/customs/jquery.flexslider-min.js",
                "~/Scripts/customs/owl.carousel.min.js",
                "~/Scripts/pagination.js",
                "~/Scripts/customs/main.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/customs/customs.css",
                "~/Content/customs/font-awesome.min.css",
                "~/Content/customs/prettyPhoto.css",
                "~/Content/customs/owl.carousel.css",
                "~/Content/customs/style.css",
                "~/Content/customs/Admin/Ionicons/css/ionicons.min.css",
                "~/Content/customs/Admin/dist/css/skins/skin-blue.min.css",
                "~/Content/customs/Admin/dist/css/AdminLTE.min.css",
                "~/Content/customs/responsive.css"));

        }
    }
            
}
