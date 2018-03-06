using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eCommerceFLANCO.Areas.Admin
{
        internal static class BundleConfig
        {
            internal static void RegisterBundles(BundleCollection bundles)
            {
                bundles.Add(new StyleBundle("~/Content/bootstrap/dist/css/css").Include(
                    "~/Content/bootstrap/dist/css/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/dist/css").Include(
                    "~/Content/dist/toastr.css"));

            bundles.Add(new StyleBundle("~/Content/DataTables/css/css").Include(
                    "~/Content/DataTables/css/dataTables.bootstrap.css"));

                bundles.Add(new StyleBundle("~/Content/font-awesome/css/css").Include(
                    "~/Content/font-awesome/css/font-awesome.min.css"));


                bundles.Add(new StyleBundle("~/Content/Ionicons/css/css").Include(
                    "~/Content/Ionicons/css/ionicons.min.css"));

                bundles.Add(new StyleBundle("~/Content/dist/css/css").Include(
                    "~/Content/dist/css/AdminLTE.min.css"));

                bundles.Add(new StyleBundle("~/Content/dist/css/skins/css").Include(
                    "~/Content/dist/css/skins/skin-blue.min.css"));

                bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/respond.js",
                    "~/Scripts/customs/Admin/dist/js/adminlte.min.js",
                    "~/Scripts/DataTables/jquery.dataTables.js",
                    "~/Scripts/DataTables/dataTables.bootstrap.js",
                    "~/Scripts/toastr.js",
                    "~/Scripts/bootbox.js"));
        }

        }
    
}